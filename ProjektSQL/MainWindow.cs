using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSQL
{
    public partial class MainWindow : Form
    {
        public int nonDateColumns;
        public int dateColumns;
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void buttonZaloguj_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = await Globals.dbManager.SetConnection(textBoxUsername.Text, textBoxPassword.Text);
            if (ErrorLabel.Text == null)
                return;
            labelZalogowano.Text = "Zalogowano jako " + textBoxUsername.Text + "!";
            textBoxUsername.Text = textBoxPassword.Text = "";
            comboBoxWybor.Items.Clear();
            DataTable userTables = await SqlQueries.SqlSelect("select table_name from user_tables");
            foreach (DataRow row in userTables.Rows)
            {
                comboBoxWybor.Items.Add(row["table_name"].ToString());
                
            }
        }
        private string CheckState()
        {
            if (labelZalogowano.Text == "")
            {
                ErrorLabel.Text = "Nie zalogowano!";
                return null;
            }
            if (comboBoxWybor.Text == "")
            {
                ErrorLabel.Text = "Wybierz Tabele!";
                return null;
            }
            Globals.mainWindow.Enabled = false;
            return comboBoxWybor.Text.ToUpper();
        }
        private async void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            string table_name = CheckState();
            if (table_name == null)
                return;
            Globals.selectWindow = new SelectWindow();
            string sqlQuery = "SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = '" + table_name + "'";
            DataTable columns = await SqlQueries.SqlSelect(sqlQuery);
            foreach(DataRow row in columns.Rows)
            {
                Globals.selectWindow.comboBoxWyszukaj.Items.Add(row["column_name"].ToString());
            }
            Globals.selectWindow.Show();
        }

        private async void buttonWstaw_Click(object sender, EventArgs e)
        {
            string table_name = CheckState();
            if (table_name == "")
                return;
            Globals.insertWindow = new InsertWindow();
            Setup.InitLabelsAndTB();
            Setup.SetVisibleLabelsAndTB(7, false);
            nonDateColumns = int.Parse((await SqlQueries.SqlSelect("select count(*) from all_tab_columns where table_name = '" + table_name + "' and column_name NOT LIKE 'ID%' and data_type <> 'DATE'")).Rows[0][0].ToString());
            Setup.SetVisibleLabelsAndTB(nonDateColumns, true);
            DataTable columnNames = await SqlQueries.SqlSelect("select column_name from all_tab_columns where table_name = '" + table_name + "' and column_name NOT LIKE 'ID%' and data_type <> 'DATE'");
            Setup.SetLabelsText(columnNames, nonDateColumns);
            DataTable dataColumnNames = await SqlQueries.SqlSelect("select column_name from all_tab_columns where table_name = '" + table_name + "' and data_type = 'DATE'");
            dateColumns = Setup.ManageDateTables(dataColumnNames);
            Globals.insertWindow.Show();
        }

        private async void buttonUsun_Click(object sender, EventArgs e)
        {
            string table_name = CheckState();
            if (table_name == "")
                return;
            Globals.deleteWindow = new DeleteWindow();
            string sqlQuery = "SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = '" + table_name + "'";
            DataTable columns = await SqlQueries.SqlSelect(sqlQuery);
            foreach (DataRow row in columns.Rows)
            {
                Globals.deleteWindow.comboBoxKolumny.Items.Add(row["column_name"].ToString());
            }
            Globals.deleteWindow.Show();
        }

        private async void comboBoxWybor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Paging.SetDataSource( await SqlQueries.SqlSelect("select * from " + comboBoxWybor.Text));
        }

        private void buttonPagingLower_Click(object sender, EventArgs e)
        {
            Paging.DecreasePage();
        }

        private void buttonPagingUpper_Click(object sender, EventArgs e)
        {
            Paging.IncreasePage();
        }
    }
}
