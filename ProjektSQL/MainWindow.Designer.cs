namespace ProjektSQL
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.buttonWstaw = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.comboBoxWybor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelZalogowano = new System.Windows.Forms.Label();
            this.buttonPagingLower = new System.Windows.Forms.Button();
            this.buttonPagingUpper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.Location = new System.Drawing.Point(9, 76);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(263, 51);
            this.buttonZaloguj.TabIndex = 0;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(284, 12);
            this.dataGV.MaximumSize = new System.Drawing.Size(1600, 800);
            this.dataGV.MinimumSize = new System.Drawing.Size(810, 497);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(810, 497);
            this.dataGV.TabIndex = 1;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorLabel.Location = new System.Drawing.Point(9, 418);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(263, 91);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "Info Box";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyszukaj.Location = new System.Drawing.Point(9, 178);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(263, 58);
            this.buttonWyszukaj.TabIndex = 5;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
            // 
            // buttonWstaw
            // 
            this.buttonWstaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWstaw.Location = new System.Drawing.Point(9, 242);
            this.buttonWstaw.Name = "buttonWstaw";
            this.buttonWstaw.Size = new System.Drawing.Size(263, 60);
            this.buttonWstaw.TabIndex = 6;
            this.buttonWstaw.Text = "Wstaw";
            this.buttonWstaw.UseVisualStyleBackColor = true;
            this.buttonWstaw.Click += new System.EventHandler(this.buttonWstaw_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsun.Location = new System.Drawing.Point(9, 308);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(263, 57);
            this.buttonUsun.TabIndex = 7;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // comboBoxWybor
            // 
            this.comboBoxWybor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWybor.FormattingEnabled = true;
            this.comboBoxWybor.Location = new System.Drawing.Point(9, 133);
            this.comboBoxWybor.Name = "comboBoxWybor";
            this.comboBoxWybor.Size = new System.Drawing.Size(263, 24);
            this.comboBoxWybor.TabIndex = 8;
            this.comboBoxWybor.SelectedIndexChanged += new System.EventHandler(this.comboBoxWybor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasło";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(101, 9);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(171, 22);
            this.textBoxUsername.TabIndex = 11;
            this.textBoxUsername.Text = "ProjektUser";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(101, 42);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(171, 22);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.Text = "PU";
            // 
            // labelZalogowano
            // 
            this.labelZalogowano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZalogowano.Location = new System.Drawing.Point(9, 378);
            this.labelZalogowano.Name = "labelZalogowano";
            this.labelZalogowano.Size = new System.Drawing.Size(263, 23);
            this.labelZalogowano.TabIndex = 13;
            this.labelZalogowano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPagingLower
            // 
            this.buttonPagingLower.Location = new System.Drawing.Point(835, 515);
            this.buttonPagingLower.Name = "buttonPagingLower";
            this.buttonPagingLower.Size = new System.Drawing.Size(84, 32);
            this.buttonPagingLower.TabIndex = 14;
            this.buttonPagingLower.Text = "<<<";
            this.buttonPagingLower.UseVisualStyleBackColor = true;
            this.buttonPagingLower.Click += new System.EventHandler(this.buttonPagingLower_Click);
            // 
            // buttonPagingUpper
            // 
            this.buttonPagingUpper.Location = new System.Drawing.Point(1010, 515);
            this.buttonPagingUpper.Name = "buttonPagingUpper";
            this.buttonPagingUpper.Size = new System.Drawing.Size(84, 32);
            this.buttonPagingUpper.TabIndex = 15;
            this.buttonPagingUpper.Text = ">>>";
            this.buttonPagingUpper.UseVisualStyleBackColor = true;
            this.buttonPagingUpper.Click += new System.EventHandler(this.buttonPagingUpper_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 553);
            this.Controls.Add(this.buttonPagingUpper);
            this.Controls.Add(this.buttonPagingLower);
            this.Controls.Add(this.labelZalogowano);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxWybor);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonWstaw);
            this.Controls.Add(this.buttonWyszukaj);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.buttonZaloguj);
            this.Name = "MainWindow";
            this.Text = "SQL Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZaloguj;
        public System.Windows.Forms.DataGridView dataGV;
        public System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.Button buttonWstaw;
        private System.Windows.Forms.Button buttonUsun;
        public System.Windows.Forms.ComboBox comboBoxWybor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelZalogowano;
        private System.Windows.Forms.Button buttonPagingLower;
        private System.Windows.Forms.Button buttonPagingUpper;
    }
}

