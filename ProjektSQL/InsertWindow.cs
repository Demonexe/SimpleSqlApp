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
    public partial class InsertWindow : Form
    {
        public InsertWindow()
        {
            InitializeComponent();
        }

        private string[] readData()
        {
            string[] data = new string[9];
            data[0] = textBox1.Text;
            data[1] = textBox2.Text;
            data[2] = textBox3.Text;
            data[3] = textBox4.Text;
            data[4] = textBox5.Text;
            data[5] = textBox6.Text;
            data[6] = textBox7.Text;
            data[7] = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            data[8] = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            return data;
        }

        private async void buttonWstaw_Click(object sender, EventArgs e)
        {
            OracleCommand sqlCmd = QueryGenerator.CmdInsert(readData(), Globals.mainWindow.comboBoxTables.Text.ToUpper());
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            if (sqlCmd == null)
            {
                labelInfo.Text = "Podane dane nie są we właściwym formacie!";
                return;
            }
            try
            {
                await SqlQueries.SqlNonQuery(sqlCmd);
                labelInfo.Text = "Wstawiono!";
            }
            catch(Exception ex)
            {
                labelInfo.Text = ex.Message.Split(new[] {':'},2)[1];
            } 
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Globals.mainWindow.Enabled = true;
        }
    }
}
