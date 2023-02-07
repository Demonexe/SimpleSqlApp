using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ProjektSQL
{
    public partial class SelectWindow : Form
    {
        public SelectWindow()
        {
            InitializeComponent();
        }

        private async void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxWyszukaj.Text == "")
            {
                labelWyszukajInfo.Text = "Nie wybrano nazwy kolumny!";
                return;
            }
            
            SelectSqlStatement statement = new SelectSqlStatement(
                checkBoxMniejsze.Checked, checkBoxWieksze.Checked, checkBoxMin.Checked,
                checkBoxMax.Checked, comboBoxWyszukaj.Text, 
                Globals.mainWindow.comboBoxTables.Text, textBoxWyszukaj.Text, 
                dateTimePickerWyszukaj.Value,
                (await (SqlQueries.SqlSelect(new OracleCommand() { 
                    CommandText = $"Select data_type from all_tab_columns where column_name = " +
                    $"'{comboBoxWyszukaj.Text}' and table_name = '{Globals.mainWindow.comboBoxTables.Text}'",
                    Connection = Globals.dbManager.connection })))
                    .Rows[0][0].ToString()
                );
            OracleCommand cmd = statement.BuildCommand();
            if (cmd == null)
            {
                labelWyszukajInfo.Text = "Z wybranymi opcjami nie moge wyszukac!";
                return;
            }
            try
            {
                Globals.mainWindow.dataGV.DataSource = await SqlQueries.SqlSelect(cmd);
            }
            catch(Exception ex)
            {
                labelWyszukajInfo.Text = ex.Message.Split(';').Last();
            }
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Globals.mainWindow.Enabled = true;
        }
    }
}
