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
        public static void FillExpProf(this Chart chart, int c)
        {
            //label2.Text = "Расходы и доходы за " + (c + 1) + " месяца/ев:";
            //label3.Text = string.Empty;
            chart.Series.Clear();
            chart.Series.Add("Расходы");
            chart.Series.Add("Получено");
            chart.Series.Add("Начислено");

            //c = c * (-1);

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
                var result = from m in (from e in db.ExpenceSet
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
                             orderby newGroup.Key.Year descending, newGroup.Key.Month ascending
                             select new
                             {
                                 newGroup.Key.Month,
                                 newGroup.Key.Year,
                                 Summa,
                                 SumEntrance,
                                 SumAdded
                             };

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
    }
}
