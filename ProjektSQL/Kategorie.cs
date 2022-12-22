using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Kategorie
    {
        string nazwa_kategorii;
        string opis;

        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into KATEGORIE values('" + nazwa_kategorii + "', '" + opis + "')";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            if (!(data[0].Length > 0 && data[0].Length < 51)) // nazwa kategorii
                return false;
            if (!(data[1].Length > 0 && data[1].Length < 1001)) // opis
                return false;
            nazwa_kategorii = data[0];
            opis = data[1];
            return true;
        }
    }
}
