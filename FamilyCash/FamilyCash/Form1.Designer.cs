namespace FamilyCash
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expencesToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.profitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiillexpprofToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.filltypeExpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fillprofpersonToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fillproffamilyToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fiilprofitfamilyToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new FamilyCash.TabControlWithoutTabs();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.btnDelExp = new System.Windows.Forms.Button();
            this.btnAddExp = new System.Windows.Forms.Button();
            this.btnEditExp = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.btnAddProf = new System.Windows.Forms.Button();
            this.btnEditProf = new System.Windows.Forms.Button();
            this.btnDelProf = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.data3 = new System.Windows.Forms.DataGridView();
            this.btnAddRev = new System.Windows.Forms.Button();
            this.btnEditRev = new System.Windows.Forms.Button();
            this.btnDelRev = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.expbyonetypeToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.графикиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenu});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenu.Text = "Выход";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expencesToolStripMenu,
            this.profitToolStripMenu,
            this.revenueToolStripMenu});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // expencesToolStripMenu
            // 
            this.expencesToolStripMenu.Name = "expencesToolStripMenu";
            this.expencesToolStripMenu.Size = new System.Drawing.Size(202, 22);
            this.expencesToolStripMenu.Text = "Расходы";
            // 
            // profitToolStripMenu
            // 
            this.profitToolStripMenu.Name = "profitToolStripMenu";
            this.profitToolStripMenu.Size = new System.Drawing.Size(202, 22);
            this.profitToolStripMenu.Text = "Доходы";
            // 
            // revenueToolStripMenu
            // 
            this.revenueToolStripMenu.Name = "revenueToolStripMenu";
            this.revenueToolStripMenu.Size = new System.Drawing.Size(202, 22);
            this.revenueToolStripMenu.Text = "Ведомость по зарплате";
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiillexpprofToolStripMenu,
            this.filltypeExpToolStripMenu,
            this.fillprofpersonToolStripMenu,
            this.fillproffamilyToolStripMenu,
            this.fiilprofitfamilyToolStripMenu,
            this.expbyonetypeToolStripMenu});
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.графикиToolStripMenuItem.Text = "Графики";
            // 
            // fiillexpprofToolStripMenu
            // 
            this.fiillexpprofToolStripMenu.Name = "fiillexpprofToolStripMenu";
            this.fiillexpprofToolStripMenu.Size = new System.Drawing.Size(248, 22);
            this.fiillexpprofToolStripMenu.Text = "Доходы и расходы за период";
            // 
            // filltypeExpToolStripMenu
            // 
            this.filltypeExpToolStripMenu.Name = "filltypeExpToolStripMenu";
            this.filltypeExpToolStripMenu.Size = new System.Drawing.Size(248, 22);
            this.filltypeExpToolStripMenu.Text = "Расходы по типу";
            // 
            // fillprofpersonToolStripMenu
            // 
            this.fillprofpersonToolStripMenu.Name = "fillprofpersonToolStripMenu";
            this.fillprofpersonToolStripMenu.Size = new System.Drawing.Size(248, 22);
            this.fillprofpersonToolStripMenu.Text = "Доходы одного члена семьи";
            // 
            // fillproffamilyToolStripMenu
            // 
            this.fillproffamilyToolStripMenu.Name = "fillproffamilyToolStripMenu";
            this.fillproffamilyToolStripMenu.Size = new System.Drawing.Size(248, 22);
            this.fillproffamilyToolStripMenu.Text = "Доходы всей семьи";
            // 
            // fiilprofitfamilyToolStripMenu
            // 
            this.fiilprofitfamilyToolStripMenu.Name = "fiilprofitfamilyToolStripMenu";
            this.fiilprofitfamilyToolStripMenu.Size = new System.Drawing.Size(248, 22);
            this.fiilprofitfamilyToolStripMenu.Text = "Прибыль семьи";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограмеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограмеToolStripMenuItem
            // 
            this.оПрограмеToolStripMenuItem.Name = "оПрограмеToolStripMenuItem";
            this.оПрограмеToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.оПрограмеToolStripMenuItem.Text = "О програме";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerStrip
            // 
            this.timerStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerStrip.Name = "timerStrip";
            this.timerStrip.Size = new System.Drawing.Size(118, 17);
            this.timerStrip.Text = "toolStripStatusLabel1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(668, 403);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.data1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDelExp);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddExp);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditExp);
            this.splitContainer1.Size = new System.Drawing.Size(654, 371);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data1.Location = new System.Drawing.Point(0, 0);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data1.Size = new System.Drawing.Size(654, 319);
            this.data1.TabIndex = 0;
            // 
            // btnDelExp
            // 
            this.btnDelExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelExp.Location = new System.Drawing.Point(256, 12);
            this.btnDelExp.Name = "btnDelExp";
            this.btnDelExp.Size = new System.Drawing.Size(101, 23);
            this.btnDelExp.TabIndex = 2;
            this.btnDelExp.Text = "Удалить";
            this.btnDelExp.UseVisualStyleBackColor = true;
            this.btnDelExp.Click += new System.EventHandler(this.btnDelExp_Click);
            // 
            // btnAddExp
            // 
            this.btnAddExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExp.Location = new System.Drawing.Point(10, 12);
            this.btnAddExp.Name = "btnAddExp";
            this.btnAddExp.Size = new System.Drawing.Size(101, 23);
            this.btnAddExp.TabIndex = 3;
            this.btnAddExp.Text = "Добавить";
            this.btnAddExp.UseVisualStyleBackColor = true;
            this.btnAddExp.Click += new System.EventHandler(this.btnAddExp_Click);
            // 
            // btnEditExp
            // 
            this.btnEditExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditExp.Location = new System.Drawing.Point(117, 12);
            this.btnEditExp.Name = "btnEditExp";
            this.btnEditExp.Size = new System.Drawing.Size(133, 23);
            this.btnEditExp.TabIndex = 4;
            this.btnEditExp.Text = "Редактировать";
            this.btnEditExp.UseVisualStyleBackColor = true;
            this.btnEditExp.Click += new System.EventHandler(this.btnEditExp_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.data2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnAddProf);
            this.splitContainer2.Panel2.Controls.Add(this.btnEditProf);
            this.splitContainer2.Panel2.Controls.Add(this.btnDelProf);
            this.splitContainer2.Size = new System.Drawing.Size(654, 371);
            this.splitContainer2.SplitterDistance = 319;
            this.splitContainer2.TabIndex = 0;
            // 
            // data2
            // 
            this.data2.AllowUserToAddRows = false;
            this.data2.AllowUserToDeleteRows = false;
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data2.Location = new System.Drawing.Point(0, 0);
            this.data2.Name = "data2";
            this.data2.ReadOnly = true;
            this.data2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data2.Size = new System.Drawing.Size(654, 319);
            this.data2.TabIndex = 0;
            // 
            // btnAddProf
            // 
            this.btnAddProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProf.Location = new System.Drawing.Point(10, 12);
            this.btnAddProf.Name = "btnAddProf";
            this.btnAddProf.Size = new System.Drawing.Size(101, 23);
            this.btnAddProf.TabIndex = 2;
            this.btnAddProf.Text = "Добавить";
            this.btnAddProf.UseVisualStyleBackColor = true;
            this.btnAddProf.Click += new System.EventHandler(this.btnAddProf_Click);
            // 
            // btnEditProf
            // 
            this.btnEditProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditProf.Location = new System.Drawing.Point(117, 12);
            this.btnEditProf.Name = "btnEditProf";
            this.btnEditProf.Size = new System.Drawing.Size(133, 23);
            this.btnEditProf.TabIndex = 3;
            this.btnEditProf.Text = "Редактировать";
            this.btnEditProf.UseVisualStyleBackColor = true;
            this.btnEditProf.Click += new System.EventHandler(this.btnEditProf_Click);
            // 
            // btnDelProf
            // 
            this.btnDelProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelProf.Location = new System.Drawing.Point(256, 12);
            this.btnDelProf.Name = "btnDelProf";
            this.btnDelProf.Size = new System.Drawing.Size(101, 23);
            this.btnDelProf.TabIndex = 4;
            this.btnDelProf.Text = "Удалить";
            this.btnDelProf.UseVisualStyleBackColor = true;
            this.btnDelProf.Click += new System.EventHandler(this.btnDelProf_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(660, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.data3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnAddRev);
            this.splitContainer3.Panel2.Controls.Add(this.btnEditRev);
            this.splitContainer3.Panel2.Controls.Add(this.btnDelRev);
            this.splitContainer3.Size = new System.Drawing.Size(660, 377);
            this.splitContainer3.SplitterDistance = 319;
            this.splitContainer3.TabIndex = 0;
            // 
            // data3
            // 
            this.data3.AllowUserToAddRows = false;
            this.data3.AllowUserToDeleteRows = false;
            this.data3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data3.Location = new System.Drawing.Point(0, 0);
            this.data3.Name = "data3";
            this.data3.ReadOnly = true;
            this.data3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data3.Size = new System.Drawing.Size(660, 319);
            this.data3.TabIndex = 0;
            // 
            // btnAddRev
            // 
            this.btnAddRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRev.Location = new System.Drawing.Point(8, 14);
            this.btnAddRev.Name = "btnAddRev";
            this.btnAddRev.Size = new System.Drawing.Size(101, 23);
            this.btnAddRev.TabIndex = 5;
            this.btnAddRev.Text = "Добавить";
            this.btnAddRev.UseVisualStyleBackColor = true;
            this.btnAddRev.Click += new System.EventHandler(this.btnAddRev_Click);
            // 
            // btnEditRev
            // 
            this.btnEditRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditRev.Location = new System.Drawing.Point(115, 14);
            this.btnEditRev.Name = "btnEditRev";
            this.btnEditRev.Size = new System.Drawing.Size(133, 23);
            this.btnEditRev.TabIndex = 6;
            this.btnEditRev.Text = "Редактировать";
            this.btnEditRev.UseVisualStyleBackColor = true;
            this.btnEditRev.Click += new System.EventHandler(this.btnEditRev_Click);
            // 
            // btnDelRev
            // 
            this.btnDelRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelRev.Location = new System.Drawing.Point(254, 14);
            this.btnDelRev.Name = "btnDelRev";
            this.btnDelRev.Size = new System.Drawing.Size(101, 23);
            this.btnDelRev.TabIndex = 7;
            this.btnDelRev.Text = "Удалить";
            this.btnDelRev.UseVisualStyleBackColor = true;
            this.btnDelRev.Click += new System.EventHandler(this.btnDelRev_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(660, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(519, 377);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // expbyonetypeToolStripMenu
            // 
            this.expbyonetypeToolStripMenu.Name = "expbyonetypeToolStripMenu";
            this.expbyonetypeToolStripMenu.Size = new System.Drawing.Size(248, 22);
            this.expbyonetypeToolStripMenu.Text = "Расходы по одной статье затрат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 449);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FamilyCash - ведение семейного бюджета";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timerStrip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expencesToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem profitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограмеToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView data2;
        public System.Windows.Forms.Button btnAddProf;
        public System.Windows.Forms.Button btnEditProf;
        public System.Windows.Forms.Button btnDelProf;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView data1;
        public System.Windows.Forms.Button btnDelExp;
        public System.Windows.Forms.Button btnAddExp;
        public System.Windows.Forms.Button btnEditExp;
        private TabControlWithoutTabs tabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView data3;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenu;
        public System.Windows.Forms.Button btnAddRev;
        public System.Windows.Forms.Button btnEditRev;
        public System.Windows.Forms.Button btnDelRev;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem fiillexpprofToolStripMenu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem filltypeExpToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fillprofpersonToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fillproffamilyToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fiilprofitfamilyToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem expbyonetypeToolStripMenu;
    }
}

