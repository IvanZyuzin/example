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
    public partial class Form1 : Form
    {
        private string[] headers = { "№", "Дата приобретения", "Описание", "Тип расходов", "Сумма покупки" };

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Tick += TimerMoving;
            ShowExpences();
        }

        private void TimerMoving(object sender, EventArgs args)
        {
            timerStrip.Text = string.Format("Сегодня: {0}", DateTime.Now.ToString());
        }

        private void btnAddExp_Click(object sender, EventArgs e)
        {
            FormExp form = new FormExp(true);
            form.ShowDialog();
        }

        private void btnEditExp_Click(object sender, EventArgs e)
        {
            if (data1.Rows.Count == 0 | data1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали объект для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormExp form = new FormExp(false, Convert.ToInt32(data1.SelectedRows[0].Cells[0].Value));
            form.ShowDialog();
        }

        private void btnDelExp_Click(object sender, EventArgs e)
        {
            if (data1.Rows.Count == 0 | data1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали объект для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Expence expence = db.ExpenceSet.Find(int.Parse(data1.SelectedRows[0].Cells[0].Value.ToString()));
                    db.ExpenceSet.Remove(expence);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowExpences()
        {
            using (ModelContainer db = new ModelContainer())
            {
                data1.DataSource = db.ExpenceSet.AsNoTracking().Select(x => new { x.Id, x.ExpDate, x.ExpDescription, x.TypeExpences.TypeExpDescription, x.Summa }).ToList();
                for (int i = 0; i < headers.Length; i++)
                {
                    data1.Columns[i].HeaderText = headers[i];
                }
            }
        }
    }
}
