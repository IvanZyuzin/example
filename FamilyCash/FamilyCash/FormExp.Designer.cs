namespace FamilyCash
{
    partial class FormExp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboTypeExp = new System.Windows.Forms.ComboBox();
            this.SumExp = new System.Windows.Forms.TextBox();
            this.DescriptionExp = new System.Windows.Forms.TextBox();
            this.dateExp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEditExp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboTypeExp
            // 
            this.comboTypeExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeExp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboTypeExp.FormattingEnabled = true;
            this.comboTypeExp.Location = new System.Drawing.Point(159, 173);
            this.comboTypeExp.Name = "comboTypeExp";
            this.comboTypeExp.Size = new System.Drawing.Size(175, 27);
            this.comboTypeExp.TabIndex = 47;
            // 
            // SumExp
            // 
            this.SumExp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumExp.Location = new System.Drawing.Point(159, 218);
            this.SumExp.Name = "SumExp";
            this.SumExp.Size = new System.Drawing.Size(100, 26);
            this.SumExp.TabIndex = 46;
            // 
            // DescriptionExp
            // 
            this.DescriptionExp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionExp.Location = new System.Drawing.Point(159, 53);
            this.DescriptionExp.Multiline = true;
            this.DescriptionExp.Name = "DescriptionExp";
            this.DescriptionExp.Size = new System.Drawing.Size(175, 110);
            this.DescriptionExp.TabIndex = 45;
            // 
            // dateExp
            // 
            this.dateExp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateExp.Location = new System.Drawing.Point(159, 12);
            this.dateExp.Name = "dateExp";
            this.dateExp.Size = new System.Drawing.Size(175, 26);
            this.dateExp.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Сумма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Тип расходов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Статья расходов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Дата:";
            // 
            // btnAddEditExp
            // 
            this.btnAddEditExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEditExp.Location = new System.Drawing.Point(75, 264);
            this.btnAddEditExp.Name = "btnAddEditExp";
            this.btnAddEditExp.Size = new System.Drawing.Size(103, 34);
            this.btnAddEditExp.TabIndex = 48;
            this.btnAddEditExp.Text = "Добавить";
            this.btnAddEditExp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(184, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 34);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEditExp);
            this.Controls.Add(this.comboTypeExp);
            this.Controls.Add(this.SumExp);
            this.Controls.Add(this.DescriptionExp);
            this.Controls.Add(this.dateExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormExp";
            this.Text = "FormExp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTypeExp;
        private System.Windows.Forms.TextBox SumExp;
        private System.Windows.Forms.TextBox DescriptionExp;
        private System.Windows.Forms.DateTimePicker dateExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEditExp;
        private System.Windows.Forms.Button btnCancel;
    }
}