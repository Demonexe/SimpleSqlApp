namespace ProjektSQL
{
    partial class DeleteWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxWieksze = new System.Windows.Forms.CheckBox();
            this.checkBoxMniejsze = new System.Windows.Forms.CheckBox();
            this.checkBoxRowne = new System.Windows.Forms.CheckBox();
            this.comboBoxKolumny = new System.Windows.Forms.ComboBox();
            this.textBoxWartosc = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.dateTimePickerUsun = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usunietych danych nie da sie przywrocic!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxWieksze
            // 
            this.checkBoxWieksze.AutoSize = true;
            this.checkBoxWieksze.Location = new System.Drawing.Point(12, 161);
            this.checkBoxWieksze.Name = "checkBoxWieksze";
            this.checkBoxWieksze.Size = new System.Drawing.Size(100, 20);
            this.checkBoxWieksze.TabIndex = 1;
            this.checkBoxWieksze.Text = "Wieksze niz";
            this.checkBoxWieksze.UseVisualStyleBackColor = true;
            // 
            // checkBoxMniejsze
            // 
            this.checkBoxMniejsze.AutoSize = true;
            this.checkBoxMniejsze.Location = new System.Drawing.Point(12, 135);
            this.checkBoxMniejsze.Name = "checkBoxMniejsze";
            this.checkBoxMniejsze.Size = new System.Drawing.Size(101, 20);
            this.checkBoxMniejsze.TabIndex = 2;
            this.checkBoxMniejsze.Text = "Mniejsze niz";
            this.checkBoxMniejsze.UseVisualStyleBackColor = true;
            // 
            // checkBoxRowne
            // 
            this.checkBoxRowne.AutoSize = true;
            this.checkBoxRowne.Location = new System.Drawing.Point(12, 187);
            this.checkBoxRowne.Name = "checkBoxRowne";
            this.checkBoxRowne.Size = new System.Drawing.Size(71, 20);
            this.checkBoxRowne.TabIndex = 3;
            this.checkBoxRowne.Text = "Rowne";
            this.checkBoxRowne.UseVisualStyleBackColor = true;
            // 
            // comboBoxKolumny
            // 
            this.comboBoxKolumny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKolumny.FormattingEnabled = true;
            this.comboBoxKolumny.Location = new System.Drawing.Point(15, 77);
            this.comboBoxKolumny.Name = "comboBoxKolumny";
            this.comboBoxKolumny.Size = new System.Drawing.Size(179, 24);
            this.comboBoxKolumny.TabIndex = 4;
            // 
            // textBoxWartosc
            // 
            this.textBoxWartosc.Location = new System.Drawing.Point(15, 107);
            this.textBoxWartosc.Name = "textBoxWartosc";
            this.textBoxWartosc.Size = new System.Drawing.Size(179, 22);
            this.textBoxWartosc.TabIndex = 5;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(9, 238);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(185, 57);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Info Box";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(119, 135);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 72);
            this.buttonUsun.TabIndex = 7;
            this.buttonUsun.Text = "Usun!";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // dateTimePickerUsun
            // 
            this.dateTimePickerUsun.Location = new System.Drawing.Point(12, 213);
            this.dateTimePickerUsun.Name = "dateTimePickerUsun";
            this.dateTimePickerUsun.Size = new System.Drawing.Size(182, 22);
            this.dateTimePickerUsun.TabIndex = 8;
            // 
            // DeleteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 304);
            this.Controls.Add(this.dateTimePickerUsun);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxWartosc);
            this.Controls.Add(this.comboBoxKolumny);
            this.Controls.Add(this.checkBoxRowne);
            this.Controls.Add(this.checkBoxMniejsze);
            this.Controls.Add(this.checkBoxWieksze);
            this.Controls.Add(this.label1);
            this.Name = "DeleteWindow";
            this.Text = "Usuwanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxWieksze;
        private System.Windows.Forms.CheckBox checkBoxMniejsze;
        private System.Windows.Forms.CheckBox checkBoxRowne;
        public System.Windows.Forms.ComboBox comboBoxKolumny;
        private System.Windows.Forms.TextBox textBoxWartosc;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.DateTimePicker dateTimePickerUsun;
    }
}