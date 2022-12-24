using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Transakcja : ITable
    {
        DateTime data_zawarcia;
        int id_prac;
        int id_klienta;
        int id_dostawcy;
        DateTime data_dostawy;
        char czy_faktura;
        int id_koszyka;
        char czy_odbior_wlasny;

        public string GenerateSqlDDL() //wklejanie daty: to_date('" + data + "','YY/MM/DD')
        {
            string sqlCmd = "Insert into TRANSAKCJA values(TRANSAKCJE_SEQ.NEXTVAL, to_date('" +data_zawarcia.ToString() + "','YY/MM/DD'), "+
                 id_prac + ", " + id_klienta + ", " + id_dostawcy + ", to_date('" + data_dostawy.ToString() + "','YY/MM/DD'), '"+
                czy_faktura + "', " + id_koszyka + ", '"+czy_odbior_wlasny+"')";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            int a;
            if (data[0].Length > 0 && data[0].Length < 5 && int.TryParse(data[4], out a)) // id_prac
            {
                if (!SqlQueries.CheckForeignKey("SELECT * FROM PRACOWNICY WHERE ID_PRAC = " + data[0]))
                    return false;
            }
            if (data[1].Length > 0 && data[1].Length < 9 && int.TryParse(data[4], out a)) // id_klienta
            {
                if (!SqlQueries.CheckForeignKey("SELECT * FROM KLIENT WHERE ID_KLIENTA = " + data[1]))
                    return false;
            }
            if (data[2].Length > 0 && data[2].Length < 4 && int.TryParse(data[4], out a)) // id_dostawcy
            {
                if (!SqlQueries.CheckForeignKey("SELECT * FROM DOSTAWCA WHERE ID_DOSTAWCY = " + data[2]))
                    return false;
            }
            if (!(data[3].Length == 1 && (data[3].ToLower() == "T" || data[3].ToLower() == "N"))) //czy_faktura
                return false;
            if (data[4].Length > 0 && data[4].Length < 13 && int.TryParse(data[4],out a)) //id_koszyka
            {
                if (!SqlQueries.CheckForeignKey("SELECT * FROM KOSZYK WHERE ID_KOSZYKA = "+ data[4]))
                    return false;
            }
            if (!(data[5].Length == 1 && (data[5].ToLower() == "T" || data[5].ToLower() == "N"))) // czy_odbior_wlasny
                return false;
            data_dostawy = Globals.insertWindow.dateTimePicker1.Value.Date;
            data_zawarcia = Globals.insertWindow.dateTimePicker2.Value.Date;
            id_prac = int.Parse(data[0]);
            id_klienta = int.Parse(data[1]);
            id_dostawcy = int.Parse(data[2]);
            czy_faktura = Convert.ToChar(data[3]);
            id_koszyka = int.Parse(data[4]);
            czy_odbior_wlasny = Convert.ToChar(data[5]);
            return true;
        }
    }
}
