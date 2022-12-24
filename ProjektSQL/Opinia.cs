using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Opinia : ITable
    {
        string opinia;
        int id_produktu;
        string nazwa_kategorii;
        int id_producenta;

        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into OPINIA values(OPINIA_SEQ.NEXTVAL, " +
                "'" + opinia + "', " + id_produktu + ", '" + nazwa_kategorii + "', " + id_producenta +
                ")";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            int a;
            if (!(data[0].Length > 0 && data[0].Length < 501)) // opinia
                return false;
            if (data[1].Length > 0 && data[1].Length < 7 && int.TryParse(data[1], out a)) // id_produktu
            {
                if (!SqlQueries.CheckForeignKey("SELECT * FROM PRODUKT WHERE ID_PRODUKTU = " + data[1]))
                    return false;
            }
            if (data[2].Length > 0 && data[2].Length < 51) // nazwa_kategorii
            {
                if (!SqlQueries.CheckForeignKey("SELECT * FROM KATEGORIE WHERE NAZWA_KATEGORII = '" + data[2]+"'"))
                    return false;
            }
            if (data[3].Length > 0 && data[3].Length < 5 && int.TryParse(data[3], out a)) //id_producenta
            {
                if (!SqlQueries.CheckForeignKey("SELECT * FROM PRODUCENT WHERE ID_PRODUCENTA = " + data[3]))
                    return false;
            }
            opinia = data[0];
            id_produktu = int.Parse(data[1]);
            nazwa_kategorii = data[2];
            id_producenta = int.Parse(data[3]);
            return true;
        }
    }
}
