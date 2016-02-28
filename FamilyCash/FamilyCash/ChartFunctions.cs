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
        /// <summary>
        /// Расчет доходов и расходов за определенный период
        /// </summary>
        /// <param name="Months">Количество месяцев
        public static void FillExpProfByMonths(this Chart chart, int Months)
        {
            //label2.Text = "Расходы и доходы за " + (c + 1) + " месяца/ев:";
            //label3.Text = string.Empty;
            chart.Series.Clear();
            chart.Series.Add("Расходы");
            chart.Series.Add("Получено");
            chart.Series.Add("Начислено");

            using (ModelContainer db = new ModelContainer())
            {
                #region SomeComments
                /*var expences = db.ExpenceSet.AsNoTracking()
                    .Select(x => new { x.ExpDate.Month, x.ExpDate.Year, x.Summa })
                    .GroupBy(x => new { x.Month, x.Year })
                    .Select(y => new
                    {
                        y.Key.Month,
                        y.Key.Year,
                        SumExp = y.Sum(k => k.Summa)
                    }).ToList();

                var profits = db.ProfitSet.AsNoTracking()
                    .Select(x => new
                    {
                        x.ProfDate.Month,
                        x.ProfDate.Year,
                        x.SumEntrance,
                        x.SumAdded
                    })
                        .GroupBy(x => new { x.Month, x.Year })
                        .Select(y => new
                        {
                            y.Key.Month,
                            y.Key.Year,
                            SumEntProf = y.Sum(k => k.SumEntrance),
                            SumAddProf = y.Sum(k => k.SumAdded)
                        }).ToList();*/
                #endregion
                /*var result = db.Database.SqlQuery<ResultBuffer>(@"SELECT MONTH(e.ExpDate), YEAR(e.ExpDate), SUM(e.Summa), SUM(p.SumEntrance), SUM(p.SumAdded) 
                    FROM ProfitSet as p, ExpenceSet as e 
                    GROUP BY MONTH(e.ExpDate), YEAR(e.ExpDate) 
                    ORDER BY YEAR(e.ExpDate) DESC, MONTH(e.ExpDate) ASC");*/
                var result = (from m in (from e in db.ExpenceSet
                                         from p in db.ProfitSet.Where(x => x.ProfDate.Year == e.ExpDate.Year && x.ProfDate.Month == e.ExpDate.Month).DefaultIfEmpty()
                                         select new
                                         {
                                             e.ExpDate.Month,
                                             e.ExpDate.Year,
                                             e.Summa,
                                             p.SumEntrance,
                                             p.SumAdded
                                         })
                              group m by new { m.Month, m.Year } into newGroup
                              let Summa = newGroup.Sum(x => x.Summa)
                              let SumEntrance = newGroup.Sum(x => x.SumEntrance)
                              let SumAdded = newGroup.Sum(x => x.SumAdded)
                              orderby newGroup.Key.Year descending, newGroup.Key.Month descending
                              select new
                              {
                                  newGroup.Key.Month,
                                  newGroup.Key.Year,
                                  Summa,
                                  SumEntrance,
                                  SumAdded
                              }).Take(Months);

                foreach (var elem in result)
                {
                    chart.Series[0].Points.AddXY(elem.Month + " " + elem.Year, elem.Summa);
                    chart.Series[0].Label = "#VALY";
                    chart.Series[1].Points.AddXY(elem.Month + " " + elem.Year, elem.SumEntrance);
                    chart.Series[1].Label = "#VALY";
                    chart.Series[2].Points.AddXY(elem.Month + " " + elem.Year, elem.SumAdded);
                    chart.Series[2].Label = "#VALY";
                }
            }
            //label3.Text += string.Format("{0} {1} г. : поступило {2} руб., начислено {3} руб., расходы {4} руб.\n", months[reader.GetInt32(0) - 1], reader.GetInt32(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetDecimal(4));
        }

        /// <summary>
        /// Функция рисования графика по статьям расходов за определенный период
        /// </summary>
        /// <param name="Months">Количество месяцев
        public static void FillTypeExpencesByMonths(this Chart chart, int Months)
        {
            //label3.Text = "Статьи расходов за " + (c + 1) + " месяца/ев:\n";
            chart.Series.Clear();

            using (ModelContainer db = new ModelContainer())
            {
                DateTime now = DateTime.Now;
                DateTime prev_date = new DateTime(now.Year, now.Month, 1).AddMonths(-Months);

                var types_headers = db.TypeExpenceSet.Select(x => x.TypeExpDescription);
                foreach (string elem in types_headers)
                {
                    chart.Series.Add(elem);
                }

                var Types = from m in (from e in db.ExpenceSet
                                       where e.ExpDate > prev_date && e.ExpDate < now
                                       select new
                                       {
                                           e.ExpDate.Month,
                                           e.ExpDate.Year,
                                           e.TypeExpenceId,
                                           e.Summa,
                                       })
                            group m by new { m.Year, m.Month, m.TypeExpenceId } into newGroup
                            let Summa = newGroup.Sum(x => x.Summa)
                            orderby newGroup.Key.Year descending, newGroup.Key.Month descending, newGroup.Key.TypeExpenceId ascending
                            select new
                            {
                                newGroup.Key.Month,
                                newGroup.Key.Year,
                                newGroup.Key.TypeExpenceId,
                                Summa
                            };
                int buf_i = 1;

                foreach (var elem in Types)
                {
                    while (buf_i != elem.TypeExpenceId)
                    {
                        chart.Series[buf_i - 1].Points.AddXY(string.Format("{0}.{1}", elem.Month, elem.Year), 0);
                        buf_i++;
                        if (buf_i > types_headers.Count()) buf_i = 1;
                    }
                    chart.Series[elem.TypeExpenceId - 1].Points.AddXY(string.Format("{0}.{1}", elem.Month, elem.Year), elem.Summa);
                    chart.Series[elem.TypeExpenceId - 1].Label = "#VALY";
                    //label3.Text += string.Format("{0} - {1} {2} : {3} руб.\n", buf[reader.GetInt32(0) - 1], months[reader.GetInt32(1) - 1], reader.GetInt32(2), reader.GetDecimal(3));
                }
            }
        }

        /// <summary>
        /// Функция отображения доходов одного члена семьи
        /// </summary>
        /// <param name="name">Имя члена семьи (передавать через ComboBox.SelectedIndex.Value</param>
        /// <param name="Months">Количество месяцев</param>
        public static void ProfitByPersonByMonth(this Chart Chart, string Name, int Months)
        {
            //label3.Text = "Доход члена семьи - " + name + " за " + (Months + 1) + " месяца/ев:\n";
            Chart.Series.Clear();
            Chart.Series.Add("Начислено");
            Chart.Series.Add("Поступило");
            using (ModelContainer db = new ModelContainer())
            {
                DateTime now = DateTime.Now;
                DateTime prev_date = new DateTime(now.Year, now.Month, 1).AddMonths(-Months);

                var Profit = from m in (from p in db.ProfitSet
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
                foreach (var elem in Profit)
                {
                    Chart.Series[0].Points.AddXY(elem.Month + "." + elem.Year, elem.SumEntrance);
                    Chart.Series[0].Label = "#VALY";
                    Chart.Series[1].Points.AddXY(elem.Month + "." + elem.Year, elem.SumAdded);
                    Chart.Series[1].Label = "#VALY";
                    //label3.Text += string.Format("{0} {1} г. : поступило {2} руб., начислено {3} руб.\n", months[reader.GetInt32(0) - 1], reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                }
            }
        }

        /// <summary>
        /// Функция отображения доходов семьи за определенный период
        /// </summary>
        /// <param name="Months">Количество месяцев</param>
        public static void ProfitByFamilyByMonths(this Chart Chart, int Months)
        {
            //label3.Text = "Доход семьи за " + (c + 1) + " месяца/ев:\n";
            Chart.Series.Clear();
            using (ModelContainer db = new ModelContainer())
            {
                var Names = db.PersonSet.AsNoTracking().Select(x => x.FirstName).Take(3).ToList();
                Names.ForEach((name) =>
                {
                    Chart.Series.Add("Получено: " + name);
                    Chart.Series.Add("Начислено: " + name);
                });
                DateTime now = DateTime.Now;
                DateTime prev_date = new DateTime(now.Year, now.Month, 1).AddMonths(-Months);
                var Profit = from m in (from p in db.ProfitSet
                                        where p.ProfDate > prev_date && p.ProfDate < now
                                        select new
                                        {
                                            p.PersonId,
                                            p.ProfDate.Year,
                                            p.ProfDate.Month,
                                            p.SumEntrance,
                                            p.SumAdded
                                        })
                             group m by new { m.Year, m.Month, m.PersonId } into newGroup
                             let SumEntrance = newGroup.Sum(x => x.SumEntrance)
                             let SumAdded = newGroup.Sum(x => x.SumAdded)
                             orderby newGroup.Key.Year descending, newGroup.Key.Month descending, newGroup.Key.PersonId
                             select new
                             {
                                 newGroup.Key.PersonId,
                                 newGroup.Key.Month,
                                 newGroup.Key.Year,
                                 SumEntrance,
                                 SumAdded
                             };
                foreach (var elem in Profit)
                {
                    switch (elem.PersonId)
                    {
                        case 1:
                            Chart.Series[elem.PersonId - 1].Points.AddXY(elem.Month + "." + elem.Year, elem.SumEntrance);
                            Chart.Series[elem.PersonId - 1].Label = "#VALY";
                            Chart.Series[elem.PersonId].Points.AddXY(elem.Month + "." + elem.Year, elem.SumAdded);
                            Chart.Series[elem.PersonId].Label = "#VALY";
                            //label3.Text += string.Format("{0} - {1} {2} г. : поступило {3} руб., начислено {4} руб.\n", Names[reader.GetInt32(0) - 1], months[reader.GetInt32(1) - 1], reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString());
                            break;
                        case 2:
                            Chart.Series[elem.PersonId].Points.AddXY(elem.Month + "." + elem.Year, elem.SumEntrance);
                            Chart.Series[elem.PersonId].Label = "#VALY";
                            Chart.Series[elem.PersonId + 1].Points.AddXY(elem.Month + "." + elem.Year, elem.SumAdded);
                            Chart.Series[elem.PersonId + 1].Label = "#VALY";
                            //label3.Text += string.Format("{0} - {1} {2} г. : поступило {3} руб., начислено {4} руб.\n", Names[reader.GetInt32(0) - 1], months[reader.GetInt32(1) - 1], reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString());
                            break;
                        case 3:
                            Chart.Series[elem.PersonId + 1].Points.AddXY(elem.Month + "." + elem.Year, elem.SumEntrance);
                            Chart.Series[elem.PersonId + 1].Label = "#VALY";
                            Chart.Series[elem.PersonId + 2].Points.AddXY(elem.Month + "." + elem.Year, elem.SumAdded);
                            Chart.Series[elem.PersonId + 2].Label = "#VALY";
                            //label3.Text += string.Format("{0} - {1} {2} г. : поступило {3} руб., начислено {4} руб.\n", Names[reader.GetInt32(0) - 1], months[reader.GetInt32(1) - 1], reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString());
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Функция вычисления прибыли за определенный период
        /// </summary>
        /// <param name="Months">Количество месяцев</param>
        public static void FillProfitByMonth(this Chart Chart, int Months)
        {
            //label2.Text = "Прибыль за " + (months + 1) + " месяца/ев:";
            //label3.Text = string.Empty;
            Chart.Series.Clear();
            Chart.Series.Add("Прибыль по начислению");
            Chart.Series.Add("Прибыль по получению");
            using (ModelContainer db = new ModelContainer())
            {
                DateTime now = DateTime.Now;
                DateTime prev_date = new DateTime(now.Year, now.Month, 1).AddMonths(-Months);
                var ExpProfit = (from m in (from e in db.ExpenceSet.Where(x => x.ExpDate > prev_date && x.ExpDate < now)
                                            from p in db.ProfitSet.Where(x => x.ProfDate > prev_date && x.ProfDate < now)
                                            where e.ExpDate.Month == p.ProfDate.Month && e.ExpDate.Year == p.ProfDate.Year
                                            select new
                                            {
                                                e.ExpDate.Month,
                                                e.ExpDate.Year,
                                                e.Summa,
                                                p.SumEntrance,
                                                p.SumAdded
                                            })
                                 group m by new { m.Year, m.Month } into newGroup
                                 let Summa = newGroup.Sum(x => x.Summa)
                                 let SumEntrance = newGroup.Sum(x => x.SumEntrance)
                                 let SumAdded = newGroup.Sum(x => x.SumAdded)
                                 orderby newGroup.Key.Year descending, newGroup.Key.Month descending
                                 select new
                                 {
                                     newGroup.Key.Month,
                                     newGroup.Key.Year,
                                     Summa,
                                     SumEntrance,
                                     SumAdded
                                 }).ToList();

                foreach (var elem in ExpProfit)
                {
                    Chart.Series[0].Points.AddXY(elem.Month + "." + elem.Year, elem.SumEntrance - elem.Summa);
                    Chart.Series[0].Label = "#VALY";
                    Chart.Series[1].Points.AddXY(elem.Month + "." + elem.Year, elem.SumAdded - elem.Summa);
                    Chart.Series[1].Label = "#VALY";
                    //label3.Text += string.Format("{0} {1} г. : прибыль по получению {2} руб., прибыль по начислению {3} руб.\n", months[reader.GetInt32(0) - 1], reader.GetInt32(1), reader.GetDecimal(2) - reader.GetDecimal(4), reader.GetDecimal(3) - reader.GetDecimal(4));
                }
            }
        }

        /// <summary>
        /// Функция выведения расходов по одному типу статьи за определенный период
        /// </summary>
        /// <param name="i">Индекс выбранного элемента</param>
        /// <param name="c">Количество месяцев</param>
        public static void ExpByTypeByMonth(this Chart Chart, int Index, int Months)
        {
            //label2.Text = "Расход по  статье " + n + " за " + (c + 1) + " месяца/ев:";
            //label3.Text = string.Empty;
            using (ModelContainer db = new ModelContainer())
            {
                Chart.Series.Clear();
                Chart.Series.Add(db.TypeExpenceSet.Find(Index).TypeExpDescription);

                DateTime now = DateTime.Now;
                DateTime prev_date = new DateTime(now.Year, now.Month, 1).AddMonths(-Months);
                var Expence = from m in (from e in db.ExpenceSet
                                         where e.ExpDate > prev_date && e.ExpDate < now && e.TypeExpenceId == Index
                                         select new
                                         {
                                             e.ExpDate.Month,
                                             e.ExpDate.Year,
                                             e.Summa
                                         })
                              group m by new { m.Year, m.Month } into newGroup
                              let Summa = newGroup.Sum(x => x.Summa)
                              orderby newGroup.Key.Year descending, newGroup.Key.Month descending
                              select new
                              {
                                  newGroup.Key.Month,
                                  newGroup.Key.Year,
                                  Summa
                              };

                foreach (var elem in Expence)
                {
                    Chart.Series[0].Points.AddXY(string.Format("{0}.{1}", elem.Month, elem.Year), elem.Summa);
                    Chart.Series[0].Label = "#VALY";
                    //label3.Text += string.Format("{0} - {1} {2} : {3} руб.\n", reader.GetString(0), months[reader.GetInt32(1) - 1], reader.GetInt32(2), reader.GetDecimal(3));
                }
            }
        }
    }
}
