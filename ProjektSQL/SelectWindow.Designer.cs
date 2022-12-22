namespace ProjektSQL
{
    partial class SelectWindow
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
            this.comboBoxWyszukaj = new System.Windows.Forms.ComboBox();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.textBoxWyszukaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerWyszukaj = new System.Windows.Forms.DateTimePicker();
            this.labelWyszukajInfo = new System.Windows.Forms.Label();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.checkBoxWieksze = new System.Windows.Forms.CheckBox();
            this.checkBoxMniejsze = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxWyszukaj
            // 
            this.comboBoxWyszukaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWyszukaj.FormattingEnabled = true;
            this.comboBoxWyszukaj.Location = new System.Drawing.Point(23, 34);
            this.comboBoxWyszukaj.Name = "comboBoxWyszukaj";
            this.comboBoxWyszukaj.Size = new System.Drawing.Size(243, 24);
            this.comboBoxWyszukaj.TabIndex = 0;
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Location = new System.Drawing.Point(23, 140);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(82, 20);
            this.checkBoxMin.TabIndex = 1;
            this.checkBoxMin.Text = "Minimum";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.Location = new System.Drawing.Point(23, 166);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(86, 20);
            this.checkBoxMax.TabIndex = 2;
            this.checkBoxMax.Text = "Maximum";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            // 
            // textBoxWyszukaj
            // 
            this.textBoxWyszukaj.Location = new System.Drawing.Point(23, 96);
            this.textBoxWyszukaj.Name = "textBoxWyszukaj";
            this.textBoxWyszukaj.Size = new System.Drawing.Size(243, 22);
            this.textBoxWyszukaj.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wybierz kolumnę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dla atrybutów tekstowych lub liczbowych";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dla atrybutów czasowych";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dla atrybutów czasowych lub liczbowych";
            // 
            // dateTimePickerWyszukaj
            // 
            this.dateTimePickerWyszukaj.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerWyszukaj.Location = new System.Drawing.Point(23, 208);
            this.dateTimePickerWyszukaj.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerWyszukaj.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerWyszukaj.Name = "dateTimePickerWyszukaj";
            this.dateTimePickerWyszukaj.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerWyszukaj.TabIndex = 10;
            this.dateTimePickerWyszukaj.Value = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            // 
            // labelWyszukajInfo
            // 
            this.labelWyszukajInfo.Location = new System.Drawing.Point(23, 244);
            this.labelWyszukajInfo.Name = "labelWyszukajInfo";
            this.labelWyszukajInfo.Size = new System.Drawing.Size(166, 51);
            this.labelWyszukajInfo.TabIndex = 11;
            this.labelWyszukajInfo.Text = "Info Box";
            this.labelWyszukajInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Location = new System.Drawing.Point(195, 244);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(81, 51);
            this.buttonWyszukaj.TabIndex = 12;
            this.buttonWyszukaj.Text = "Wyszukaj!";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // checkBoxWieksze
            // 
            this.checkBoxWieksze.AutoSize = true;
            this.checkBoxWieksze.Location = new System.Drawing.Point(128, 140);
            this.checkBoxWieksze.Name = "checkBoxWieksze";
            this.checkBoxWieksze.Size = new System.Drawing.Size(81, 20);
            this.checkBoxWieksze.TabIndex = 13;
            this.checkBoxWieksze.Text = "Wieksze";
            this.checkBoxWieksze.UseVisualStyleBackColor = true;
            // 
            // checkBoxMniejsze
            // 
            this.checkBoxMniejsze.AutoSize = true;
            this.checkBoxMniejsze.Location = new System.Drawing.Point(127, 166);
            this.checkBoxMniejsze.Name = "checkBoxMniejsze";
            this.checkBoxMniejsze.Size = new System.Drawing.Size(82, 20);
            this.checkBoxMniejsze.TabIndex = 14;
            this.checkBoxMniejsze.Text = "Mniejsze";
            this.checkBoxMniejsze.UseVisualStyleBackColor = true;
            // 
            // SelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 309);
            this.Controls.Add(this.checkBoxMniejsze);
            this.Controls.Add(this.checkBoxWieksze);
            this.Controls.Add(this.buttonWyszukaj);
            this.Controls.Add(this.labelWyszukajInfo);
            this.Controls.Add(this.dateTimePickerWyszukaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWyszukaj);
            this.Controls.Add(this.checkBoxMax);
            this.Controls.Add(this.checkBoxMin);
            this.Controls.Add(this.comboBoxWyszukaj);
            this.Name = "SelectWindow";
            this.Text = "Wyszukaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxWyszukaj;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.CheckBox checkBoxMax;
        private System.Windows.Forms.TextBox textBoxWyszukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWyszukajInfo;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.CheckBox checkBoxWieksze;
        private System.Windows.Forms.CheckBox checkBoxMniejsze;
        public System.Windows.Forms.DateTimePicker dateTimePickerWyszukaj;
    }
}