using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyCash
{
    class DataFunctions
    {
        public static DateTime GetSubtractDate(int Months)
        {
            DateTime now = DateTime.Now;
            return new DateTime(now.Year, now.Month, 1).AddMonths(-Months);
        }

        public static List<Expence> GetExpencesByPeriod(int Months = 1)
        {
            using (ModelContainer db = new ModelContainer())
            {
                return db.ExpenceSet.AsNoTracking().Where(x => x.ExpDate > GetSubtractDate(Months)).OrderByDescending(x => x.ExpDate).ToList();
            }
        }

        public static List<Profit> GetProfitByPeriod(int Months = 1)
        {
            using (ModelContainer db = new ModelContainer())
            {
                return db.ProfitSet.AsNoTracking().Where(x => x.ProfDate > GetSubtractDate(Months)).OrderByDescending(x => x.ProfDate).ToList();
            }
        }

        public static List<string> GetTypeExpencesDescription()
        {
            using (ModelContainer db = new ModelContainer())
            {
                return db.TypeExpenceSet.AsNoTracking().Select(x => x.TypeExpDescription).ToList();

            }
        }

        public static List<string> GetFamilyMembersName()
        {
            using (ModelContainer db = new ModelContainer())
            {
                return db.PersonSet.AsNoTracking().Select(x => x.FirstName).Take(3).ToList();
            }
        }

        public static IQueryable GetExpenceAndProfitByMonth(int Months)
        {
            using (ModelContainer db = new ModelContainer())
            {
                var ExpenceAndProfit = from e in (from e in db.ExpenceSet.AsNoTracking()
                                        where e.ExpDate > GetSubtractDate(Months) && e.ExpDate < DateTime.Now
                                        group e by new { e.ExpDate.Month, e.ExpDate.Year } into newExp
                                        select new
                                        {
                                            Month = newExp.Key.Month,
                                            Year = newExp.Key.Year,
                                            Summa = newExp.Sum(x => x.Summa)
                                        })
                             join p in (from p in db.ProfitSet.AsNoTracking()
                                        where p.ProfDate > GetSubtractDate(Months) && p.ProfDate < DateTime.Now
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
                return ExpenceAndProfit;
            }
        }
    }
}
