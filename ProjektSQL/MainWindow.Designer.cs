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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelZalogowano = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.buttonPagingUpper = new System.Windows.Forms.Button();
            this.buttonPagingLower = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(296, 556);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // labelZalogowano
            // 
            this.labelZalogowano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZalogowano.Location = new System.Drawing.Point(15, 381);
            this.labelZalogowano.Name = "labelZalogowano";
            this.labelZalogowano.Size = new System.Drawing.Size(263, 23);
            this.labelZalogowano.TabIndex = 27;
            this.labelZalogowano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(107, 45);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(171, 22);
            this.textBoxPassword.TabIndex = 26;
            this.textBoxPassword.Text = "PU";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(107, 12);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(171, 22);
            this.textBoxUsername.TabIndex = 25;
            this.textBoxUsername.Text = "ProjektUser";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(12, 45);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(89, 22);
            this.labelPassword.TabIndex = 24;
            this.labelPassword.Text = "Hasło";
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(12, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(89, 30);
            this.labelLogin.TabIndex = 23;
            this.labelLogin.Text = "Login";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(15, 136);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(263, 24);
            this.comboBoxTables.TabIndex = 22;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(15, 311);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(263, 57);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInsert.Location = new System.Drawing.Point(15, 245);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(263, 60);
            this.buttonInsert.TabIndex = 20;
            this.buttonInsert.Text = "Wstaw";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.Location = new System.Drawing.Point(15, 181);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(263, 58);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Wyszukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorLabel.Location = new System.Drawing.Point(15, 421);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(263, 91);
            this.ErrorLabel.TabIndex = 18;
            this.ErrorLabel.Text = "Info Box";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(15, 79);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(263, 51);
            this.buttonLogin.TabIndex = 17;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(296, 504);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(693, 52);
            this.splitter2.TabIndex = 28;
            this.splitter2.TabStop = false;
            // 
            // buttonPagingUpper
            // 
            this.buttonPagingUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPagingUpper.Location = new System.Drawing.Point(737, 524);
            this.buttonPagingUpper.Name = "buttonPagingUpper";
            this.buttonPagingUpper.Size = new System.Drawing.Size(241, 32);
            this.buttonPagingUpper.TabIndex = 30;
            this.buttonPagingUpper.Text = ">>>";
            this.buttonPagingUpper.UseVisualStyleBackColor = true;
            this.buttonPagingUpper.Click += new System.EventHandler(this.buttonPagingUpper_Click);
            // 
            // buttonPagingLower
            // 
            this.buttonPagingLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPagingLower.Location = new System.Drawing.Point(302, 524);
            this.buttonPagingLower.Name = "buttonPagingLower";
            this.buttonPagingLower.Size = new System.Drawing.Size(241, 32);
            this.buttonPagingLower.TabIndex = 29;
            this.buttonPagingLower.Text = "<<<";
            this.buttonPagingLower.UseVisualStyleBackColor = true;
            this.buttonPagingLower.Click += new System.EventHandler(this.buttonPagingLower_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeight = 29;
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV.Location = new System.Drawing.Point(296, 0);
            this.dataGV.MinimumSize = new System.Drawing.Size(600, 400);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(693, 504);
            this.dataGV.TabIndex = 31;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 556);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.buttonPagingUpper);
            this.Controls.Add(this.buttonPagingLower);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.labelZalogowano);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.splitter1);
            this.MinimumSize = new System.Drawing.Size(819, 600);
            this.Name = "MainWindow";
            this.Text = "SQL Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelZalogowano;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button buttonPagingUpper;
        private System.Windows.Forms.Button buttonPagingLower;
        public System.Windows.Forms.DataGridView dataGV;
    }
}

