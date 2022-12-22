using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSQL
{
    public partial class SelectWindow : Form
    {
        public SelectWindow()
        {
            InitializeComponent();
        }

        private int CalculateControlSum()
        {
            return Globals.BoolToInt(checkBoxMin.Checked) +
                Globals.BoolToInt(checkBoxMax.Checked) +
                Globals.BoolToInt(checkBoxWieksze.Checked) + Globals.BoolToInt(checkBoxMniejsze.Checked);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxWyszukaj.Text == "")
            {
                labelWyszukajInfo.Text = "Nie wybrano nazwy kolumny!";
                return;
            }
            int controlSum = CalculateControlSum();
            string sqlQuery = null;
            string table_name = Globals.mainWindow.comboBoxWybor.Text;
            string column_name = comboBoxWyszukaj.Text;
            string value = textBoxWyszukaj.Text;
            string date = dateTimePickerWyszukaj.Value.ToString("yyyy-MM-dd");
            string type = SqlQueries.SqlSelect("Select data_type from all_tab_columns where column_name = '" + column_name + "' and table_name = '" + table_name + "'").Rows[0][0].ToString();
            if(type == "DATE")
                sqlQuery = QueryGenerator.dateSelect(controlSum, checkBoxMin.Checked,checkBoxMax.Checked,
                    checkBoxMniejsze.Checked,checkBoxWieksze.Checked,column_name,table_name,date);
            else if (controlSum == 0 && value != "" && type == "VARCHAR2")// string, rowne
                sqlQuery = "select * from " + table_name + " where " + column_name + "= '" + value + "'";
            else if(type == "NUMBER")
                sqlQuery = QueryGenerator.numberSelect(controlSum, checkBoxMin.Checked, checkBoxMax.Checked,
                    checkBoxMniejsze.Checked, checkBoxWieksze.Checked, column_name, table_name,value);
            else
            {
                labelWyszukajInfo.Text = "Z wybranymi opcjami nie moge wyszukac!";
                return;
            }
            if (sqlQuery == null)
            {
                labelWyszukajInfo.Text = "Z wybranymi opcjami nie moge wyszukac!";
                return;
            }
            try
            {
                Globals.mainWindow.dataGV.DataSource = SqlQueries.SqlSelect(sqlQuery);
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
