using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ProjektSQL
{
    public partial class DeleteWindow : Form
    {
        public DeleteWindow()
        {
            InitializeComponent();
        }

        private async void buttonUsun_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = null;
            DeleteSqlStatement sqlCommand = new DeleteSqlStatement(checkBoxMniejsze.Checked, checkBoxWieksze.Checked, checkBoxRowne.Checked,
                Globals.mainWindow.comboBoxTables.Text, comboBoxKolumny.Text, dateTimePickerUsun.Value, textBoxWartosc.Text,
                (await SqlQueries.SqlSelect(new OracleCommand($"Select data_type from all_tab_columns where column_name = {Globals.mainWindow.comboBoxTables.Text} and table_name = {comboBoxKolumny.Text}"))).Rows[0][0].ToString());
            cmd = sqlCommand.BuildCommand();
            if(cmd == null)
            {
                labelInfo.Text = "Nie moge usunac z wybranymi opcjami";
                return;
            }
            try
            {
                labelInfo.Text = $"Usunieto {await SqlQueries.SqlNonQuery(cmd)}rekordow!";
            }
            catch(Exception ex)
            {
                labelInfo.Text = ex.Message.Split(new[] {':'},2)[1];
            }
            Globals.mainWindow.dataGV.DataSource = await SqlQueries.SqlSelect(new OracleCommand($"Select * from {Globals.mainWindow.comboBoxTables.Text}"));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Globals.mainWindow.Enabled = true;
        }
    }
}
