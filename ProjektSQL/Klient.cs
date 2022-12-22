using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;

namespace ProjektSQL
{
    internal class Klient
    {
        string imie;
        string nazwisko;
        string numer_tel;
        string adres;
        string email;
        string kod_pocztowy;

        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into KLIENT values(KLIENCI_SEQ.NEXTVAL, " +
                "'" +imie + "', '"+nazwisko + "', '"+numer_tel + "', '"+ adres+
                "', '"+email+"', '" +kod_pocztowy+"')";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data) 
        {
            if (!(data[0].Length > 0 && data[0].Length < 41)) // imie
                return false;
            if (!(data[1].Length > 0 && data[1].Length < 81)) // nazwisko
                return false;
            if (!(data[2].Length > 0 && data[2].Length < 14)) // numer_tel
                return false;
            if (!(data[3].Length > 0 && data[3].Length < 201)) //adres
                return false;
            if (!(data[4].Length > 0 && data[4].Length < 101)) //e-mail
                return false;
            if (!(data[5].Length > 0 && data[5].Length < 7)) // kod pocztowy
                return false;
            imie = data[0];
            nazwisko = data[1];
            numer_tel = data[2];
            adres = data[3];
            email = data[4];
            kod_pocztowy = data[5];
            return true;
        }

    }
}
