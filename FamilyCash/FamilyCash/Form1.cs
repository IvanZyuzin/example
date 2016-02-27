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
        private string[] headers_expence = { "№", "Дата приобретения", "Описание", "Тип расходов", "Сумма покупки" };
        private string[] headers_profit = { "№", "Дата поступления", "Описание", "Начислено", "Получено", "Член семьи" };

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Tick += TimerMoving;
            expencesToolStripMenu.Click += ExpencesToolStripMenu_Click;
            profitToolStripMenu.Click += ProfitToolStripMenu_Click;
            revenueToolStripMenu.Click += RevenueToolStripMenu_Click;

            /*
            ShowExpences();
            ShowProfits();
            */
        }

        private void ExpencesToolStripMenu_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void ProfitToolStripMenu_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void RevenueToolStripMenu_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void TimerMoving(object sender, EventArgs args)
        {
            timerStrip.Text = string.Format("Сегодня: {0}", DateTime.Now.ToString());
        }

        private void ShowExpences()
        {
            using (ModelContainer db = new ModelContainer())
            {
                data1.DataSource = db.ExpenceSet.AsNoTracking().Select(x => new { x.Id, x.ExpDate, x.ExpDescription, x.TypeExpences.TypeExpDescription, x.Summa }).ToList();
                for (int i = 0; i < headers_expence.Length; i++)
                {
                    data1.Columns[i].HeaderText = headers_expence[i];
                }
            }
        }

        private void ShowProfits()
        {
            using (ModelContainer db = new ModelContainer())
            {
                data2.DataSource = db.ProfitSet.AsNoTracking().Select(x => new { x.Id, x.ProfDate, x.ProfDescription, x.SumEntrance, x.SumAdded, x.Persons.FirstName }).ToList();
                for (int i = 0; i < headers_profit.Length; i++)
                {
                    data2.Columns[i].HeaderText = headers_profit[i];
                }
            }
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
                MessageBox.Show("Вы не выбрали объект для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnAddProf_Click(object sender, EventArgs e)
        {
            FormProf form = new FormProf(true);
            form.ShowDialog();
        }

        private void btnEditProf_Click(object sender, EventArgs e)
        {
            if (data2.Rows.Count == 0 | data2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали объект для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormProf form = new FormProf(false, Convert.ToInt32(data2.SelectedRows[0].Cells[0].Value));
            form.ShowDialog();
        }

        private void btnDelProf_Click(object sender, EventArgs e)
        {
            if (data2.Rows.Count == 0 | data2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали объект для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Profit profit = db.ProfitSet.Find(int.Parse(data2.SelectedRows[0].Cells[0].Value.ToString()));
                    db.ProfitSet.Remove(profit);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRev_Click(object sender, EventArgs e)
        {
            FormRev form = new FormRev(true);
            form.ShowDialog();
        }

        private void btnEditRev_Click(object sender, EventArgs e)
        {
            if (data3.Rows.Count == 0 | data3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали объект для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormRev form = new FormRev(false, Convert.ToInt32(data3.SelectedRows[0].Cells[0].Value));
            form.ShowDialog();
        }

        private void btnDelRev_Click(object sender, EventArgs e)
        {
            if (data3.Rows.Count == 0 | data3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали объект для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            try
            {
                using (ModelContainer db = new ModelContainer())
                {
                    Revenue rev = db.RevenueSet.Find(int.Parse(data3.SelectedRows[0].Cells[0].Value.ToString()));
                    db.RevenueSet.Remove(rev);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            data1.DataSource = null;
            data2.DataSource = null;
            ShowExpences();
            ShowProfits();
        }
    }
}
