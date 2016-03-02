using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FamilyCash
{
    public static class ChartFunctions
    {
        public static void ClearChart(this Chart Chart)
        {
            Chart.Series.Clear();
            Chart.Legends.Clear();
            Chart.Titles.Clear();
        }
        /// <summary>
        /// Расчет доходов и расходов за определенный период
        /// </summary>
        /// <param name="Months">Количество месяцев
        public static void ShowExpenceProfitByMonths(this Chart Chart, int Months, ref string Description)
        {
            Chart.ClearChart();
            Chart.Titles.Add("Расходы и доходы за " + Months + " месяца/ев:");
            Chart.Series.Add("Расходы");
            Chart.Series.Add("Получено");
            Chart.Series.Add("Начислено");
            StringBuilder str_buf = new StringBuilder();
            DateTime now = DateTime.Now;
            DateTime prev_date = DataFunctions.GetSubtractDate(Months);
            #region MigrateSolution
            using (ModelContainer db = new ModelContainer())
            {
                var result = from e in (from e in db.ExpenceSet.AsNoTracking()
                                        where e.ExpDate > prev_date && e.ExpDate < now
                                        group e by new { e.ExpDate.Month, e.ExpDate.Year } into newExp
                                        select new
                                        {
                                            Month = newExp.Key.Month,
                                            Year = newExp.Key.Year,
                                            Summa = newExp.Sum(x => x.Summa)
                                        })
                             join p in (from p in db.ProfitSet.AsNoTracking()
                                        where p.ProfDate > prev_date && p.ProfDate < now
                                        group p by new { p.ProfDate.Month, p.ProfDate.Year } into newProf
                                        select new
                                        {
                                            Month = newProf.Key.Month,
                                            Year = newProf.Key.Year,
                                            SumEntrance = newProf.Sum(x => x.SumEntrance),
                                            SumAdded = newProf.Sum(x => x.SumAdded)
                                        })
                                        on new { e.Month, e.Year } equals new { p.Month, p.Year }
                             select new
                             {
                                 Month = e.Month,
                                 Year = e.Year,
                                 Summa = e.Summa,
                                 SumEntrance = p.SumEntrance,
                                 SumAdded = p.SumAdded
                             };
            #endregion
            //var ExpenceAndProfit = DataFunctions.GetExpenceAndProfitByMonth(Months);
                foreach (var item in result)
                {
                    Chart.Series[0].Points.AddXY(item.Month + " " + item.Year, item.Summa);
                    Chart.Series[0].Label = "#VALY";
                    Chart.Series[1].Points.AddXY(item.Month + " " + item.Year, item.SumEntrance);
                    Chart.Series[1].Label = "#VALY";
                    Chart.Series[2].Points.AddXY(item.Month + " " + item.Year, item.SumAdded);
                    Chart.Series[2].Label = "#VALY";
                    str_buf.AppendFormat("{0} {1} г. : поступило {2} руб., начислено {3} руб., расходы {4} руб.\r\n", item.Month, item.Year, item.SumEntrance, item.SumAdded, item.Summa);
                }
            }
            Description = str_buf.ToString();
        }

        /// <summary>
        /// Функция рисования графика по статьям расходов за определенный период
        /// </summary>
        /// <param name="Months">Количество месяцев
        public static void ShowExpencesByTypeByMonths(this Chart Chart, int Months, ref string Description)
        {
            Chart.ClearChart();
            Chart.Titles.Add("Статьи расходов за " + Months + " месяца/ев:");
            StringBuilder str_buf = new StringBuilder();
            DateTime now = DateTime.Now;
            DateTime prev_date = DataFunctions.GetSubtractDate(Months);
            using (ModelContainer db = new ModelContainer())
            {
                var type_headers = DataFunctions.GetTypeExpencesDescription();
                foreach (string item in type_headers)
                {
                    Chart.Series.Add(item);
                }

                var ExpencesByType = from m in (from e in db.ExpenceSet
                                       where e.ExpDate > prev_date && e.ExpDate < now
                                       select e)
                            group m by new { m.ExpDate.Year, m.ExpDate.Month, m.TypeExpenceId } into newGroup
                            orderby newGroup.Key.Year descending, newGroup.Key.Month descending, newGroup.Key.TypeExpenceId ascending
                            select new
                            {
                                Month = newGroup.Key.Month,
                                Year = newGroup.Key.Year,
                                TypeExpenceId = newGroup.Key.TypeExpenceId,
                                Summa = newGroup.Sum(x => x.Summa)
                            };
                int buf_i = 1;

                foreach (var item in ExpencesByType)
                {
                    while (buf_i != item.TypeExpenceId)
                    {
                        Chart.Series[buf_i - 1].Points.AddXY(string.Format("{0}.{1}", item.Month, item.Year), 0);
                        buf_i++;
                        if (buf_i > type_headers.Count()) buf_i = 1;
                    }
                    Chart.Series[item.TypeExpenceId - 1].Points.AddXY(string.Format("{0}.{1}", item.Month, item.Year), item.Summa);
                    Chart.Series[item.TypeExpenceId - 1].Label = "#VALY";
                    str_buf.AppendFormat("{0} - {1}.{2} : {3} руб.\r\n", item.TypeExpenceId, item.Month, item.Year, item.Summa);
                }
            }
            Description = str_buf.ToString();
        }

        /// <summary>
        /// Доходы одного члена семьи за определенный период
        /// </summary>
        /// <param name="Name">Имя члена семьи</param>
        /// <param name="Months">Количество месяцев</param>
        public static void ShowProfitByPersonByMonth(this Chart Chart, string Name, int Months, ref string Description)
        {
            Chart.ClearChart();
            Chart.Titles.Add("Доход члена семьи - " + Name + " за " + Months + " месяца/ев:");
            Chart.Series.Add("Начислено");
            Chart.Series.Add("Поступило");
            StringBuilder str_buf = new StringBuilder();
            DateTime now = DateTime.Now;
            DateTime prev_date = DataFunctions.GetSubtractDate(Months);
            using (ModelContainer db = new ModelContainer())
            {
                var ProfitByPerson = from m in (from p in db.ProfitSet
                                        where p.ProfDate > prev_date && p.ProfDate < now && p.Persons.FirstName == Name
                                        select new
                                        {
                                            p.ProfDate.Year,
                                            p.ProfDate.Month,
                                            p.SumEntrance,
                                            p.SumAdded
                                        })
                             group m by new { m.Year, m.Month } into newGroup
                             let SumEntrance = newGroup.Sum(x => x.SumEntrance)
                             let SumAdded = newGroup.Sum(x => x.SumAdded)
                             orderby newGroup.Key.Year descending, newGroup.Key.Month descending
                             select new
                             {
                                 newGroup.Key.Month,
                                 newGroup.Key.Year,
                                 SumEntrance,
                                 SumAdded
                             };
                foreach (var item in ProfitByPerson)
                {
                    Chart.Series[0].Points.AddXY(item.Month + "." + item.Year, item.SumEntrance);
                    Chart.Series[0].Label = "#VALY";
                    Chart.Series[1].Points.AddXY(item.Month + "." + item.Year, item.SumAdded);
                    Chart.Series[1].Label = "#VALY";
                    str_buf.AppendFormat("{0}.{1} г. : поступило {2} руб., начислено {3} руб.\n", item.Month, item.Year, item.SumAdded, item.SumEntrance);
                }
            }
            Description = str_buf.ToString();
        }

        /// <summary>
        /// Отображение доходов семьи за определенный период
        /// </summary>
        /// <param name="Months">Количество месяцев</param>
        public static void ShowFamilyProfitByMonths(this Chart Chart, int Months, ref string Description)
        {
            Chart.ClearChart();
            Chart.Titles.Add("Доход семьи за " + Months + " месяца / ев:");
            StringBuilder str_buf = new StringBuilder();
            using (ModelContainer db = new ModelContainer())
            {
                var Members = DataFunctions.GetFamilyMembersName();
                Members.ForEach((name) =>
                {
                    Chart.Series.Add("Получено: " + name);
                    Chart.Series.Add("Начислено: " + name);
                });
                DateTime now = DateTime.Now;
                DateTime prev_date = new DateTime(now.Year, now.Month, 1).AddMonths(-Months);
                var Profit = db.ProfitSet.AsNoTracking().Where(x => x.ProfDate > prev_date && x.ProfDate < now).Select(x => new
                {
                    x.PersonId,
                    x.ProfDate.Month,
                    x.ProfDate.Year,
                    x.SumEntrance,
                    x.SumAdded
                }).GroupBy(m => new { m.Year, m.Month, m.PersonId })
                .Select(y => new
                {
                    PersonId = y.Key.PersonId,
                    Month = y.Key.Month,
                    Year = y.Key.Year,
                    SumEntrance = y.Sum(c => c.SumEntrance),
                    SumAdded = y.Sum(c => c.SumAdded)
                }).OrderByDescending(x => new { x.Year, x.Month }).ThenBy(x => x.PersonId).ToList();
                foreach (var item in Profit)
                {
                    switch (item.PersonId)
                    {
                        case 1:
                            Chart.Series[item.PersonId - 1].Points.AddXY(item.Month + "." + item.Year, item.SumEntrance);
                            Chart.Series[item.PersonId - 1].Label = "#VALY";
                            Chart.Series[item.PersonId].Points.AddXY(item.Month + "." + item.Year, item.SumAdded);
                            Chart.Series[item.PersonId].Label = "#VALY";
                            break;
                        case 2:
                            Chart.Series[item.PersonId].Points.AddXY(item.Month + "." + item.Year, item.SumEntrance);
                            Chart.Series[item.PersonId].Label = "#VALY";
                            Chart.Series[item.PersonId + 1].Points.AddXY(item.Month + "." + item.Year, item.SumAdded);
                            Chart.Series[item.PersonId + 1].Label = "#VALY";
                            break;
                        case 3:
                            Chart.Series[item.PersonId + 1].Points.AddXY(item.Month + "." + item.Year, item.SumEntrance);
                            Chart.Series[item.PersonId + 1].Label = "#VALY";
                            Chart.Series[item.PersonId + 2].Points.AddXY(item.Month + "." + item.Year, item.SumAdded);
                            Chart.Series[item.PersonId + 2].Label = "#VALY";
                            break;
                    }
                    str_buf.AppendFormat("{0} - {1}.{2} г. : поступило {3} руб., начислено {4} руб.\n", Members[item.PersonId - 1], item.Month, item.Year, item.SumEntrance, item.SumAdded);
                }
            }
            Description = str_buf.ToString();
        }

        /// <summary>
        /// Вычисление прибыли за определенный период
        /// </summary>
        /// <param name="Months">Количество месяцев</param>
        public static void ShowResultFamilyProfitByMonth(this Chart Chart, int Months, ref string Description)
        {
            Chart.ClearChart();
            Chart.Titles.Add("Прибыль за " + Months + " месяца / ев:");
            Chart.Series.Add("Прибыль по начислению");
            Chart.Series.Add("Прибыль по получению");
            StringBuilder str_buf = new StringBuilder();
            DateTime now = DateTime.Now;
            DateTime prev_date = DataFunctions.GetSubtractDate(Months);
            using (ModelContainer db = new ModelContainer())
            {
                var result = from e in (from e in db.ExpenceSet.AsNoTracking()
                                        where e.ExpDate > prev_date && e.ExpDate < now
                                        group e by new { e.ExpDate.Month, e.ExpDate.Year } into newExp
                                        select new
                                        {
                                            Month = newExp.Key.Month,
                                            Year = newExp.Key.Year,
                                            Summa = newExp.Sum(x => x.Summa)
                                        })
                             join p in (from p in db.ProfitSet.AsNoTracking()
                                        where p.ProfDate > prev_date && p.ProfDate < now
                                        group p by new { p.ProfDate.Month, p.ProfDate.Year } into newProf
                                        select new
                                        {
                                            Month = newProf.Key.Month,
                                            Year = newProf.Key.Year,
                                            SumEntrance = newProf.Sum(x => x.SumEntrance),
                                            SumAdded = newProf.Sum(x => x.SumAdded)
                                        })
                                        on new { e.Month, e.Year } equals new { p.Month, p.Year }
                             select new
                             {
                                 Month = e.Month,
                                 Year = e.Year,
                                 Summa = e.Summa,
                                 SumEntrance = p.SumEntrance,
                                 SumAdded = p.SumAdded
                             };
                foreach (var item in result)
                {
                    Chart.Series[0].Points.AddXY(item.Month + "." + item.Year, item.SumEntrance - item.Summa);
                    Chart.Series[0].Label = "#VALY";
                    Chart.Series[1].Points.AddXY(item.Month + "." + item.Year, item.SumAdded - item.Summa);
                    Chart.Series[1].Label = "#VALY";
                    str_buf.AppendFormat("{0}.{1} г. : прибыль по получению {2} руб., прибыль по начислению {3} руб.\n",item.Month, item.Year, item.SumEntrance - item.Summa, item.SumAdded - item.Summa);
                }
            }
            Description = str_buf.ToString();
        }
    

        /// <summary>
        /// Расходов по одному типу статьи за определенный период
        /// </summary>
        /// <param name="Index">Индекс выбранного элемента</param>
        /// <param name="Months">Количество месяцев</param>
        public static void ShowExpenceByTypeByMonth(this Chart Chart, int Index, int Months, ref string Description)
        {
            Chart.ClearChart();
            StringBuilder str_buf = new StringBuilder();
            string ExpenceName = string.Empty;
            DateTime now = DateTime.Now;
            DateTime prev_date = DataFunctions.GetSubtractDate(Months);
            using (ModelContainer db = new ModelContainer())
            {
                ExpenceName = db.TypeExpenceSet.Find(Index).TypeExpDescription;
                var Expence = from m in (from e in db.ExpenceSet
                                         where e.ExpDate > prev_date && e.ExpDate < now && e.TypeExpenceId == Index
                                         select new
                                         {
                                             e.ExpDate.Month,
                                             e.ExpDate.Year,
                                             e.Summa
                                         })
                              group m by new { m.Year, m.Month } into newGroup
                              orderby newGroup.Key.Year descending, newGroup.Key.Month descending
                              select new
                              {
                                  Month =  newGroup.Key.Month,
                                  Year = newGroup.Key.Year,
                                  Summa = newGroup.Sum(x => x.Summa)
                              };
                Chart.Series.Add(ExpenceName);
                Chart.Titles.Add("Расход по  статье " + ExpenceName + " за " + Months + " месяца/ев:");
                foreach (var item in Expence)
                {
                    Chart.Series[0].Points.AddXY(string.Format("{0}.{1}", item.Month, item.Year), item.Summa);
                    Chart.Series[0].Label = "#VALY";
                    str_buf.AppendFormat("{0} - {1}.{2} : {3} руб.\n", ExpenceName, item.Month, item.Year, item.Summa);
                }
            }
            Description = str_buf.ToString();
        }
    }
}
