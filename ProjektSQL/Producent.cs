using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Producent : ITable
    {
        string nazwa;
        string adres;
        string numer_tel;

        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into PRODUCENT values(PRODUCENCI_SEQ.NEXTVAL, " +
                "'" + nazwa + "', '" + adres + "', '" + numer_tel + "')";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            if (!(data[0].Length > 0 && data[0].Length < 201)) // nazwa
                return false;
            if (!(data[1].Length > 0 && data[1].Length < 201)) // adres
                return false;
            if (!(data[2].Length > 0 && data[2].Length < 14)) // numer_tel
                return false;
            nazwa = data[0];
            adres = data[1];
            numer_tel = data[2];
            return true;
        }
    }
}
