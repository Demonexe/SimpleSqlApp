using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Produkt_w_koszyku : ITable
    {
        int id_produktu;
        string nazwa_kategorii;
        int id_producenta;
        int ilosc;
        int id_koszyka;
        float znizka;

        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into PRODUKT_W_KOSZYKU values(PRODUKT_W_KOSZYKU_SEQ.NEXTVAL, " 
                + id_produktu + "', '" + nazwa_kategorii + "', " + id_producenta + ", " + ilosc +
                ", " + id_koszyka + ", " + znizka + ")";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            if (!(data[0].Length > 0 && data[0].Length < 41)) // id_produktu
                return false;
            if (!(data[1].Length > 0 && data[1].Length < 81)) // nazwa_kategorii
                return false;
            if (!(data[2].Length > 0 && data[2].Length < 14)) // id_producenta
                return false;
            if (!(data[3].Length > 0 && data[3].Length < 201)) // ilosc
                return false;
            if (!(data[4].Length > 0 && data[4].Length < 101)) // id_koszyka
                return false;
            if (!(data[5].Length > 0 && data[5].Length < 7)) // znizka
                return false;
            id_produktu = int.Parse(data[0]);
            nazwa_kategorii = data[1];
            id_producenta = int.Parse(data[2]);
            ilosc = int.Parse(data[3]);
            id_koszyka = int.Parse(data[4]);
            znizka = float.Parse(data[5]);
            return true;
        }
    }
}
