using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Sklep : ITable
    {
        string adres;
        string kod_pocztowy;

        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into SKLEP values(SKLEPY.NEXTVAL, " +
                "'" + adres + "', '" + kod_pocztowy + "')";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            if (!(data[0].Length > 0 && data[0].Length < 201)) // adres
                return false;
            if (!(data[1].Length > 0 && data[1].Length < 7)) // kod_pocztowy
                return false;
            adres = data[0];
            kod_pocztowy = data[1];
            return true;
        }
    }
}
