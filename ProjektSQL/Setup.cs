using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal static class Setup
    {
        public static void SetVisibleLabelsAndTB(int howMany, bool value)
        {
            for (int i = 0; i < howMany; i++)
            {
                Globals.labels[i].Visible = value;
                Globals.textBoxes[i].Visible = value;
            }
        }

        public static void SetLabelsText(DataTable columnNames, int howManyNames)
        {
            int i = 0;
            foreach (DataRow row in columnNames.Rows)
            {
                Globals.labels[i].Text = row["column_name"].ToString();
                i++;
            }
        }

        public static void InitLabelsAndTB()
        {
            Globals.labels[0] = Globals.insertWindow.label1;
            Globals.labels[1] = Globals.insertWindow.label2;
            Globals.labels[2] = Globals.insertWindow.label3;
            Globals.labels[3] = Globals.insertWindow.label4;
            Globals.labels[4] = Globals.insertWindow.label5;
            Globals.labels[5] = Globals.insertWindow.label6;
            Globals.labels[6] = Globals.insertWindow.label7;

            Globals.textBoxes[0] = Globals.insertWindow.textBox1;
            Globals.textBoxes[1] = Globals.insertWindow.textBox2;
            Globals.textBoxes[2] = Globals.insertWindow.textBox3;
            Globals.textBoxes[3] = Globals.insertWindow.textBox4;
            Globals.textBoxes[4] = Globals.insertWindow.textBox5;
            Globals.textBoxes[5] = Globals.insertWindow.textBox6;
            Globals.textBoxes[6] = Globals.insertWindow.textBox7;
        }

        public static int ManageDateTables(DataTable columnName)
        {
            int howMany = columnName.Rows.Count;
            Globals.insertWindow.labelData1.Visible = false;
            Globals.insertWindow.labelData2.Visible = false;
            Globals.insertWindow.dateTimePicker1.Visible = false;
            Globals.insertWindow.dateTimePicker2.Visible = false;

            if (howMany == 0)
                return 0;
            if (howMany == 1)
            {
                Globals.insertWindow.labelData1.Visible = true;
                Globals.insertWindow.labelData1.Text = columnName.Rows[0]["column_name"].ToString();
                Globals.insertWindow.dateTimePicker1.Visible = true;
                return 1;
            }
            if (howMany == 2)
            {
                Globals.insertWindow.labelData1.Visible = true;
                Globals.insertWindow.labelData2.Visible = true;
                Globals.insertWindow.labelData1.Text = columnName.Rows[0]["column_name"].ToString();
                Globals.insertWindow.labelData2.Text = columnName.Rows[1]["column_name"].ToString();
                Globals.insertWindow.dateTimePicker1.Visible = true;
                Globals.insertWindow.dateTimePicker2.Visible = true;
                return 2;
            }
            return 0;
        }
    }
}
