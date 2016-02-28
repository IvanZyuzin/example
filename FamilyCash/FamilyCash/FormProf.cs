using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyCash
{
    public partial class FormProf : Form
    {
        private FormProf()
        {  }

        public bool AddOrEdit { get; set; }
        public int Number { get; set; }

        public FormProf(bool AddOrEdit, int Number = 0)
        {
            this.AddOrEdit = AddOrEdit;
            this.Number = Number;
            InitializeComponent();
            btnCancel.Click += (sender, args) => { Close(); };
            ShowPersons();

            if (AddOrEdit)
            {
                Text = "Добавление доходов";
                btnAddEditProf.Text = "Добавить";
                btnAddEditProf.Click += AddProfit;
            }
            else
            {
                Text = "Редактирование доходов";
                btnAddEditProf.Text = "Редактировать";
                btnAddEditProf.Click += EditProfit;
                using (ModelContainer db = new ModelContainer())
                {
                    Profit profit = db.ProfitSet.Find(Number);
                    dateProf.Value = profit.ProfDate;
                    DescriptionProfit.Text = profit.ProfDescription;
                    SumEntrance.Text = profit.SumEntrance.ToString();
                    SumAdded.Text = profit.SumAdded.ToString();
                    comboPerson.SelectedIndex = profit.Persons.Id - 1;
                }
            }
        }

        private void ShowPersons()
        {
            using (ModelContainer db = new ModelContainer())
            {
                comboPerson.Items.AddRange(db.PersonSet.AsNoTracking().Select(x => x.FirstName).Take(3).ToArray());
                comboPerson.SelectedIndex = 0;
            }
        }

        private void AddProfit(object sender, EventArgs args)
        {
            decimal SumEntr, SumAdd;
            if (string.IsNullOrWhiteSpace(DescriptionProfit.Text)
                | !decimal.TryParse(SumEntrance.Text, out SumEntr)
                | !decimal.TryParse(SumAdded.Text, out SumAdd))
            {
                MessageBox.Show("Вы не заполнили поля/ввели неверные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Profit profit = new Profit();
                    profit.ProfDate = dateProf.Value;
                    profit.ProfDescription = DescriptionProfit.Text;
                    profit.SumEntrance = SumEntr;
                    profit.SumAdded = SumAdd;
                    profit.PersonId = comboPerson.SelectedIndex + 1;
                    db.ProfitSet.Add(profit);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void EditProfit(object sender, EventArgs args)
        {
            decimal SumEntr, SumAdd;
            if (string.IsNullOrWhiteSpace(DescriptionProfit.Text)
                | !decimal.TryParse(SumEntrance.Text, out SumEntr)
                | !decimal.TryParse(SumAdded.Text, out SumAdd))
            {
                MessageBox.Show("Вы не заполнили поля/ввели неверные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Profit profit = db.ProfitSet.Find(Number);
                    profit.ProfDate = dateProf.Value;
                    profit.ProfDescription = DescriptionProfit.Text;
                    profit.SumEntrance = SumEntr;
                    profit.SumAdded = SumAdd;
                    profit.Persons.Id = comboPerson.SelectedIndex + 1;
                    db.Entry(profit).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
