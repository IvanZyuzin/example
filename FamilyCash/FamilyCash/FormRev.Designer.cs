﻿namespace FamilyCash
{
    partial class FormRev
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
            this.comboWorker = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTypeRev = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SumRev = new System.Windows.Forms.TextBox();
            this.dateRev = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEditRev = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboWorker
            // 
            this.comboWorker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboWorker.FormattingEnabled = true;
            this.comboWorker.Location = new System.Drawing.Point(118, 114);
            this.comboWorker.Name = "comboWorker";
            this.comboWorker.Size = new System.Drawing.Size(200, 27);
            this.comboWorker.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Работник:";
            // 
            // comboTypeRev
            // 
            this.comboTypeRev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboTypeRev.FormattingEnabled = true;
            this.comboTypeRev.Items.AddRange(new object[] {
            "Аванс",
            "Выручка",
            "Изделия фирмы",
            "Отпускные",
            "Подработка",
            "Свои изделия"});
            this.comboTypeRev.Location = new System.Drawing.Point(118, 44);
            this.comboTypeRev.Name = "comboTypeRev";
            this.comboTypeRev.Size = new System.Drawing.Size(200, 27);
            this.comboTypeRev.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Тип выручки:";
            // 
            // SumRev
            // 
            this.SumRev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumRev.Location = new System.Drawing.Point(118, 77);
            this.SumRev.Name = "SumRev";
            this.SumRev.Size = new System.Drawing.Size(109, 26);
            this.SumRev.TabIndex = 33;
            // 
            // dateRev
            // 
            this.dateRev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateRev.Location = new System.Drawing.Point(118, 12);
            this.dateRev.Name = "dateRev";
            this.dateRev.Size = new System.Drawing.Size(200, 26);
            this.dateRev.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Сумма:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Дата:";
            // 
            // btnAddEditRev
            // 
            this.btnAddEditRev.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEditRev.Location = new System.Drawing.Point(59, 158);
            this.btnAddEditRev.Name = "btnAddEditRev";
            this.btnAddEditRev.Size = new System.Drawing.Size(121, 35);
            this.btnAddEditRev.TabIndex = 40;
            this.btnAddEditRev.Text = "Добавить";
            this.btnAddEditRev.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(186, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 201);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEditRev);
            this.Controls.Add(this.comboWorker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTypeRev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumRev);
            this.Controls.Add(this.dateRev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRev";
            this.Text = "FormRev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTypeRev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SumRev;
        private System.Windows.Forms.DateTimePicker dateRev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEditRev;
        private System.Windows.Forms.Button btnCancel;
    }
}