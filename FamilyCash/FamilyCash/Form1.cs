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
        private string[] headers_revenue = { "№", "Дата", "Тип дохода", "Сумма", "Работник" };

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Tick += (sender, args) => { timerStrip.Text = string.Format("Сегодня: {0}", DateTime.Now.ToString()); };
            expencesToolStripMenu.Click += (sender, args) => { tabControl.SelectedIndex = 0; };
            profitToolStripMenu.Click += (sender, args) => { tabControl.SelectedIndex = 1; };
            revenueToolStripMenu.Click += (sender, args) => { tabControl.SelectedIndex = 2; };
            //!!
            FillComboBoxPerson();
            //!!
            comboPerson.SelectedIndex = 0;
            comboPeriod.SelectedIndex = 0;
            comboType.SelectedIndex = 0;

            fiillexpprofToolStripMenu.Click += (sender, args) =>
            {
                tabControl.SelectedIndex = 3;
                comboViewDiagram.SelectedIndex = 0;
            };

            filltypeExpToolStripMenu.Click += (sender, args) =>
              {
                  tabControl.SelectedIndex = 3;
                  comboViewDiagram.SelectedIndex = 1;
              };
            fillprofpersonToolStripMenu.Click += (sender, args) =>
             {
                 tabControl.SelectedIndex = 3;
                 comboViewDiagram.SelectedIndex = 2;
             };
            fillproffamilyToolStripMenu.Click += (sender, args) =>
            {
                tabControl.SelectedIndex = 3;
                comboViewDiagram.SelectedIndex = 3;
            };
            
            fiilprofitfamilyToolStripMenu.Click += (sender, args) =>
            {
                tabControl.SelectedIndex = 3;
                comboViewDiagram.SelectedIndex = 4;
            };
            expbyonetypeToolStripMenu.Click += (sender, args) =>
            {
                tabControl.SelectedIndex = 3;
                comboViewDiagram.SelectedIndex = 5;
            };

            aboutboxToolStripMenu.Click += (sender, args) =>
              {
                  AboutBox form = new AboutBox();
                  form.ShowDialog();
              };

            tabControl.Selecting += UpdateData;
            Activated += UpdateData;
        }

        public void UpdateData(object sender, EventArgs args)
        {
            switch(tabControl.SelectedIndex)
            {
                case 0:
                    data1.DataSource = null;
                    ShowExpences();
                    break;
                case 1:
                    data1.DataSource = null;
                    ShowProfits();
                    break;
                case 2:
                    data1.DataSource = null;
                    ShowRevenues();
                    break;
            }
        }

        public void ShowExpences()
        {
            using (ModelContainer db = new ModelContainer())
            {
                data1.DataSource = db.ExpenceSet.AsNoTracking().Select(x => new { x.Id, x.ExpDate, x.ExpDescription, x.TypeExpences.TypeExpDescription, x.Summa }).OrderByDescending(x => x.ExpDate).ToList();
                for (int i = 0; i < headers_expence.Length; i++)
                {
                    data1.Columns[i].HeaderText = headers_expence[i];
                }
            }
        }

        public void ShowProfits()
        {
            using (ModelContainer db = new ModelContainer())
            {
                data2.DataSource = db.ProfitSet.AsNoTracking().Select(x => new { x.Id, x.ProfDate, x.ProfDescription, x.SumEntrance, x.SumAdded, x.Persons.FirstName }).OrderByDescending(x=>x.ProfDate).ToList();
                for (int i = 0; i < headers_profit.Length; i++)
                {
                    data2.Columns[i].HeaderText = headers_profit[i];
                }
            }
        }

        public void ShowRevenues()
        {
            using (ModelContainer db = new ModelContainer())
            {
                data3.DataSource = db.RevenueSet.AsNoTracking().Select(x => new { x.Id, x.RevDate, x.TypeRevenues.TypeRevDescription, x.RevSum, x.Person_Revenue.FirstName }).ToList();
                for (int i = 0; i < headers_revenue.Length; i++)
                {
                    data3.Columns[i].HeaderText = headers_revenue[i];
                }
            }
        }

        private void FillComboBoxPerson()
        {
            using (ModelContainer db = new ModelContainer())
            {
                var Names = db.PersonSet.AsNoTracking().Select(x => new { Name = x.FirstName }).Take(3).ToList();
                comboPerson.DataSource = Names;
                comboPerson.DisplayMember = "Name";
                comboPerson.ValueMember = "Name";
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

        private void btnBuild_Click(object sender, EventArgs e)
        {
            lblMember.Visible = false;
            comboPerson.Visible = false;
            lblTypeExp.Visible = false;
            comboType.Visible = false;
            string ResultDescription = string.Empty;
            switch (comboViewDiagram.SelectedIndex)
            {
                case 0:
                    chart1.ShowExpenceProfitByMonths(comboPeriod.SelectedIndex + 1, ref ResultDescription);
                    break;
                case 1:
                    chart1.ShowExpencesByTypeByMonths(comboPeriod.SelectedIndex + 1, ref ResultDescription);
                    break;
                case 2:
                    lblMember.Visible = true;
                    comboPerson.Visible = true;
                    chart1.ShowProfitByPersonByMonth(comboPerson.SelectedValue.ToString(), comboPeriod.SelectedIndex + 1, ref ResultDescription);
                    break;
                case 3:
                    chart1.ShowFamilyProfitByMonths(comboPeriod.SelectedIndex + 1, ref ResultDescription);
                    break;
                case 4:
                    chart1.ShowResultFamilyProfitByMonth(comboPeriod.SelectedIndex + 1, ref ResultDescription);
                    break;
                case 5:
                    lblTypeExp.Visible = true;
                    comboType.Visible = true;
                    chart1.ShowExpenceByTypeByMonth(comboType.SelectedIndex + 1, comboPeriod.SelectedIndex + 1, ref ResultDescription);
                    break;
            }
            lblDesc.Text = ResultDescription;
        }

        private void comboViewDiagram_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboViewDiagram.SelectedIndex)
            {
                case 0:
                case 1:
                case 3:
                case 4:
                    lblMember.Visible = false;
                    comboPerson.Visible = false;
                    lblTypeExp.Visible = false;
                    comboType.Visible = false;
                    break;
                case 2:
                    lblMember.Visible = true;
                    comboPerson.Visible = true;
                    lblTypeExp.Visible = false;
                    comboType.Visible = false;
                    break;
                case 5:
                    lblMember.Visible = false;
                    comboPerson.Visible = false;
                    lblTypeExp.Visible = true;
                    comboType.Visible = true;
                    break;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void btnBackToGraphics_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }
    }
}
