using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Produkt
    {
        string nazwa;
        string cena_jedn; // w tabeli jest to wartosc float
        string opis;
        int id_producenta;
        string nazwa_kategorii;
        string specyfikacja;

        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into PRODUKT values(PRODUKT_SEQ.NEXTVAL, " +
                 cena_jedn + ", '" + opis + "', " + id_producenta + ", '" + nazwa_kategorii +
                "', '" + specyfikacja + "')";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            int a;
            float b;
            if (!(data[1].Length > 0 && data[1].Length < 101)) // nazwa
                return false;
            if (data[1].Length > 0 && data[1].Length < 10 && float.TryParse(data[1],out b)) // cena_jedn
            {
                string[] s = data[0].Split(',');
                if (!(s[0].Length > 0 && s[0].Length < 7 && s[1].Length < 3))
                    return false;
            }
            if (!(data[2].Length > 0 && data[2].Length < 501)) // opis
                return false;
            if (data[3].Length > 0 && data[3].Length < 5 && int.TryParse(data[3], out a)) // id_producenta
            {
                if (SqlQueries.CheckForeignKey("SELECT * FROM PRODUCENT WHERE ID_PRODUCENTA = " + data[3]))
                    return false;
            }
            if (!(data[4].Length > 0 && data[4].Length < 51)) //nazwa_kategorii
            {
                if (SqlQueries.CheckForeignKey("SELECT * FROM KATEGORIE WHERE NAZWA_KATEGORII = '" + data[4] + "'"))
                    return false;
            }
            if (!(data[5].Length > 0 && data[5].Length < 501)) //specyfikacja
                return false;
            nazwa = data[0];
            cena_jedn = data[1].Replace(',','.');
            opis = data[2];
            id_producenta = int.Parse(data[3]);
            nazwa_kategorii = data[4];
            specyfikacja = data[5];
            return true;
        }


    }
}
