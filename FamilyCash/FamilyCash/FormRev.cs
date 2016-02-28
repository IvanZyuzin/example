using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyCash
{
    public partial class FormRev : Form
    {
        private FormRev()
        { }

        public bool AddOrEdit { get; set; }
        public int Number { get; set; }

        public FormRev(bool AddOrEdit, int Number = 0)
        {
            this.AddOrEdit = AddOrEdit;
            this.Number = Number;
            InitializeComponent();
            ShowTypesRevenue_Workers();
            btnCancel.Click += (sender, args) => { Close(); };

            if (AddOrEdit)
            {
                Text = "Добавление ведомости по зарплате";
                btnAddEditRev.Text = "Добавить";
                btnAddEditRev.Click += AddRevenue;
            }
            else
            {
                Text = "Редактирование ведомости по зарплате";
                btnAddEditRev.Text = "Редактировать";
                btnAddEditRev.Click += EditRevenue;
                using (ModelContainer db = new ModelContainer())
                {
                    Revenue rev = db.RevenueSet.Find(Number);
                    dateRev.Value = rev.RevDate;
                    comboTypeRev.SelectedIndex = rev.TypeRevenueId - 1;
                    SumRev.Text = rev.RevSum.ToString();
                    comboWorker.SelectedIndex = rev.PersonId - 3;
                }
            }
        }
        private void ShowTypesRevenue_Workers()
        {
            using (ModelContainer db = new ModelContainer())
            {
                comboTypeRev.Items.AddRange(db.TypeRevenueSet.AsNoTracking().Select(x => x.TypeRevDescription).ToArray());
                comboWorker.Items.AddRange(db.PersonSet.AsNoTracking().OrderBy(x => x.Id).Skip(2).Select(x => x.FirstName).ToArray());
                comboTypeRev.SelectedIndex = 0;
                comboWorker.SelectedIndex = 0;
            }
        }

        private void AddRevenue(object sender, EventArgs args)
        {
            decimal Summa;
            if (!decimal.TryParse(SumRev.Text, out Summa))
            {
                MessageBox.Show("Вы не заполнили поля/ввели неверные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Revenue rev = new Revenue();
                    rev.RevDate = dateRev.Value;
                    rev.RevSum = Summa;
                    rev.TypeRevenueId = comboTypeRev.SelectedIndex + 1;
                    rev.PersonId = comboWorker.SelectedIndex + 3;
                    db.RevenueSet.Add(rev);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void EditRevenue(object sender, EventArgs args)
        {
            decimal Summa;
            if (!decimal.TryParse(SumRev.Text, out Summa))
            {
                MessageBox.Show("Вы не заполнили поля/ввели неверные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Revenue rev = db.RevenueSet.Find(Number);
                    rev.RevDate = dateRev.Value;
                    rev.TypeRevenueId = comboTypeRev.SelectedIndex + 1;
                    rev.RevSum = Summa;
                    rev.PersonId = comboWorker.SelectedIndex + 3;
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
