using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal static class Globals
    {
        public static DBManager dbManager;
        public static MainWindow mainWindow;
        public static SelectWindow selectWindow;
        public static DeleteWindow deleteWindow;
        public static InsertWindow insertWindow;
        public static System.Windows.Forms.Label[] labels = new System.Windows.Forms.Label[7];
        public static System.Windows.Forms.TextBox[] textBoxes = new System.Windows.Forms.TextBox[7];

        public static int BoolToInt(bool a)
        {
            return a ? 1 : 0;
        }

        public static bool CheckIntSize(int number, int length)
        {
            return number.ToString().Length < length ? true : false;
        }

        public static bool CheckStringSize(string sentence, int length)
        {
            return sentence.Length < length ? true : false;
        }
    }
}
