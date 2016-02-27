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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlWithoutTabs1 = new FamilyCash.TabControlWithoutTabs();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelExp = new System.Windows.Forms.Button();
            this.btnEditExp = new System.Windows.Forms.Button();
            this.btnAddExp = new System.Windows.Forms.Button();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlWithoutTabs1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(537, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerStrip
            // 
            this.timerStrip.Name = "timerStrip";
            this.timerStrip.Size = new System.Drawing.Size(118, 17);
            this.timerStrip.Text = "toolStripStatusLabel1";
            // 
            // tabControlWithoutTabs1
            // 
            this.tabControlWithoutTabs1.Controls.Add(this.tabPage1);
            this.tabControlWithoutTabs1.Controls.Add(this.tabPage2);
            this.tabControlWithoutTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWithoutTabs1.Location = new System.Drawing.Point(0, 24);
            this.tabControlWithoutTabs1.Name = "tabControlWithoutTabs1";
            this.tabControlWithoutTabs1.SelectedIndex = 0;
            this.tabControlWithoutTabs1.Size = new System.Drawing.Size(537, 276);
            this.tabControlWithoutTabs1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelExp);
            this.tabPage1.Controls.Add(this.btnEditExp);
            this.tabPage1.Controls.Add(this.btnAddExp);
            this.tabPage1.Controls.Add(this.data1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelExp
            // 
            this.btnDelExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelExp.Location = new System.Drawing.Point(254, 221);
            this.btnDelExp.Name = "btnDelExp";
            this.btnDelExp.Size = new System.Drawing.Size(101, 23);
            this.btnDelExp.TabIndex = 1;
            this.btnDelExp.Text = "Удалить";
            this.btnDelExp.UseVisualStyleBackColor = true;
            this.btnDelExp.Click += new System.EventHandler(this.btnDelExp_Click);
            // 
            // btnEditExp
            // 
            this.btnEditExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditExp.Location = new System.Drawing.Point(115, 221);
            this.btnEditExp.Name = "btnEditExp";
            this.btnEditExp.Size = new System.Drawing.Size(133, 23);
            this.btnEditExp.TabIndex = 1;
            this.btnEditExp.Text = "Редактировать";
            this.btnEditExp.UseVisualStyleBackColor = true;
            this.btnEditExp.Click += new System.EventHandler(this.btnEditExp_Click);
            // 
            // btnAddExp
            // 
            this.btnAddExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExp.Location = new System.Drawing.Point(8, 221);
            this.btnAddExp.Name = "btnAddExp";
            this.btnAddExp.Size = new System.Drawing.Size(101, 23);
            this.btnAddExp.TabIndex = 1;
            this.btnAddExp.Text = "Добавить";
            this.btnAddExp.UseVisualStyleBackColor = true;
            this.btnAddExp.Click += new System.EventHandler(this.btnAddExp_Click);
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(3, 3);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(523, 200);
            this.data1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 322);
            this.Controls.Add(this.tabControlWithoutTabs1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlWithoutTabs1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timerStrip;
        private TabControlWithoutTabs tabControlWithoutTabs1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDelExp;
        private System.Windows.Forms.Button btnEditExp;
        private System.Windows.Forms.Button btnAddExp;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
    }
}

