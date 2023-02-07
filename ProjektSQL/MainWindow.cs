using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string response = await Globals.dbManager.SetConnection(textBoxUsername.Text, textBoxPassword.Text);
            if (response != null)
            {
                ErrorLabel.Text = response;
                return;
            }
            labelZalogowano.Text = "Zalogowano jako " + textBoxUsername.Text + "!";
            textBoxUsername.Text = textBoxPassword.Text = "";
            comboBoxTables.Items.Clear();
            DataTable userTables = await SqlQueries.SqlSelect(
                new OracleCommand("select table_name from user_tables", Globals.dbManager.connection));
            foreach (DataRow row in userTables.Rows)
            {
                comboBoxTables.Items.Add(row["table_name"].ToString());
            }
        }
        private string CheckState()
        {
            if (labelZalogowano.Text == "")
            {
                ErrorLabel.Text = "Nie zalogowano!";
                return null;
            }
            if (comboBoxTables.Text == "")
            {
                ErrorLabel.Text = "Wybierz Tabele!";
                return null;
            }
            Globals.mainWindow.Enabled = false;
            return comboBoxTables.Text.ToUpper();
        }
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string table_name = CheckState();
            if (table_name == null)
                return;
            SelectWindow selectWindow = new SelectWindow();
            DataTable columns = await SqlQueries.SqlSelect(new OracleCommand() 
            { CommandText = $"SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = '{table_name}'",
                Connection = Globals.dbManager.connection });
            foreach(DataRow row in columns.Rows)
            {
                selectWindow.comboBoxWyszukaj.Items.Add(row["column_name"].ToString());
            }
            selectWindow.Show();
        }
        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            string table_name = CheckState();
            if (table_name == "")
                return;
            Globals.insertWindow = new InsertWindow();
            Setup.InitLabelsAndTB();
            Setup.SetVisibleLabelsAndTB(7, false);
            nonDateColumns = int.Parse((await SqlQueries.SqlSelect(new OracleCommand() { CommandText = "select count(*) from all_tab_columns where table_name = '" + table_name + "' and column_name NOT LIKE 'ID%' and data_type <> 'DATE'", Connection = Globals.dbManager.connection })).Rows[0][0].ToString());
            Setup.SetVisibleLabelsAndTB(nonDateColumns, true);
            DataTable columnNames = await SqlQueries.SqlSelect(new OracleCommand() { CommandText = "select column_name from all_tab_columns where table_name = '" + table_name + "' and column_name NOT LIKE 'ID%' and data_type <> 'DATE'", Connection = Globals.dbManager.connection });
            Setup.SetLabelsText(columnNames, nonDateColumns);
            DataTable dataColumnNames = await SqlQueries.SqlSelect(new OracleCommand() { CommandText = "select column_name from all_tab_columns where table_name = '" + table_name + "' and data_type = 'DATE'", Connection = Globals.dbManager.connection });
            dateColumns = Setup.ManageDateTables(dataColumnNames);
            Globals.insertWindow.Show();
        }
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string table_name = CheckState();
            if (table_name == "")
                return;
            DeleteWindow deleteWindow = new DeleteWindow();
            DataTable columns = await SqlQueries.SqlSelect(new OracleCommand() 
            { CommandText = $"SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = '{table_name}'",
                Connection = Globals.dbManager.connection});
            foreach (DataRow row in columns.Rows)
            {
                deleteWindow.comboBoxKolumny.Items.Add(row["column_name"].ToString());
            }
            deleteWindow.Show();
        }
        private async void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            Paging.SetDataSource( await SqlQueries.SqlSelect(new OracleCommand() { CommandText = "select * from " + comboBoxTables.Text, Connection = Globals.dbManager.connection}));
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
