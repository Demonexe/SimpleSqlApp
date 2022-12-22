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
    public partial class DeleteWindow : Form
    {
        public DeleteWindow()
        {
            InitializeComponent();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            string sqlNonQuery;
            int controlSum = Globals.BoolToInt(checkBoxMniejsze.Checked) +
                Globals.BoolToInt(checkBoxWieksze.Checked) + Globals.BoolToInt(checkBoxRowne.Checked);
            string table_name = Globals.mainWindow.comboBoxWybor.Text;
            string column_name = comboBoxKolumny.Text;
            string value = textBoxWartosc.Text;
            string date = dateTimePickerUsun.Value.ToString("yyy-MM-dd");
            string type = SqlQueries.SqlSelect("Select data_type from all_tab_columns where column_name = '" + column_name + "' and table_name = '" + table_name + "'").Rows[0][0].ToString();
            if(type == "NUMBER" && float.TryParse(textBoxWartosc.Text, out _) && controlSum == 1)
                sqlNonQuery = QueryGenerator.numberDelete(checkBoxMniejsze.Checked, checkBoxWieksze.Checked, checkBoxRowne.Checked,
                    table_name, column_name, value);
            else if(type == "VARCHAR2" && controlSum == 1 && checkBoxRowne.Checked)
                sqlNonQuery = "delete from " + table_name + " where " + column_name + " = '" + value+"'";
            else if(type == "DATE" && controlSum == 1)
                sqlNonQuery = QueryGenerator.dateDelete(checkBoxMniejsze.Checked, checkBoxWieksze.Checked, checkBoxRowne.Checked,
                    table_name, column_name, date);
            else
            {
                labelInfo.Text = "Nie moge usunac z wybranymi opcjami";
                return;
            }
            if(sqlNonQuery == null)
            {
                labelInfo.Text = "Nie moge usunac z wybranymi opcjami";
                return;
            }
            try
            {
                labelInfo.Text = "Usunieto " + SqlQueries.SqlNonQuery(sqlNonQuery) + " rekordow!";
            }
            catch(Exception ex)
            {
                labelInfo.Text = ex.Message.Split(new[] {':'},2)[1];
            }
            Globals.mainWindow.dataGV.DataSource = SqlQueries.SqlSelect("select * from " + Globals.mainWindow.comboBoxWybor.Text);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Globals.mainWindow.Enabled = true;
        }
    }
}
