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
    public partial class FormExp : Form
    {
        public bool AddOrEdit { get; set; }
        public int Number { get; set; }
        private FormExp()
        { }

        public FormExp(bool AddOrEdit, int Number = 0)
        {
            this.AddOrEdit = AddOrEdit;
            this.Number = Number;
            InitializeComponent();
            btnCancel.Click += (sender, args) => { Close(); };
            ShowTypeExpence();

            if (AddOrEdit)
            {
                Text = "Добавление расходов";
                btnAddEditExp.Text = "Добавить";
                btnAddEditExp.Click += AddExpence;
            }
            else
            {
                Text = "Редактирование расходов";
                btnAddEditExp.Text = "Редактировать";
                btnAddEditExp.Click += EditExpence;
                using (ModelContainer db = new ModelContainer())
                {
                    Expence expence = db.ExpenceSet.Find(Number);

                    dateExp.Value = expence.ExpDate;
                    DescriptionExp.Text = expence.ExpDescription;
                    comboTypeExp.SelectedIndex = expence.TypeExpenceId - 1;
                    SumExp.Text = expence.Summa.ToString();
                }
            }
        }

        private void ShowTypeExpence()
        {
            using (ModelContainer db = new ModelContainer())
            {
                comboTypeExp.Items.AddRange(db.TypeExpenceSet.AsNoTracking().Select(x => x.TypeExpDescription).ToArray());
                comboTypeExp.SelectedIndex = 0;
            }
        }

        private void AddExpence(object sender, EventArgs args)
        {
            decimal Summa = 0;
            if (string.IsNullOrEmpty(DescriptionExp.Text) || !decimal.TryParse(SumExp.Text, out Summa))
            {
                MessageBox.Show("Вы не заполнили поля/ввели неверные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Expence expence = new Expence();
                    expence.ExpDate = dateExp.Value;
                    expence.ExpDescription = DescriptionExp.Text;
                    expence.TypeExpenceId = comboTypeExp.SelectedIndex + 1;
                    expence.Summa = Summa;
                    db.ExpenceSet.Add(expence);
                    db.SaveChanges();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditExpence(object sender, EventArgs args)
        {
            decimal Summa = 0;
            if (string.IsNullOrEmpty(DescriptionExp.Text) || !decimal.TryParse(SumExp.Text, out Summa))
            {
                MessageBox.Show("Вы не заполнили поля/ввели неверные данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Expence expence = db.ExpenceSet.Find(Number);
                    expence.ExpDate = dateExp.Value;
                    expence.ExpDescription = DescriptionExp.Text;
                    expence.TypeExpenceId = comboTypeExp.SelectedIndex + 1;
                    expence.Summa = Summa;
                    db.SaveChanges();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
