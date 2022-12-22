using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Pracownik
    {
        string imie;
        string nazwisko;
        DateTime data_zatrudnienia;
        int id_sklep;
        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into PRACOWNIK values(PRACOWNIK_SEQ.NEXTVAL, " +
                "'" + imie + "', '" + nazwisko + "', to_date('" + data_zatrudnienia.ToString() + "','YY/MM/DD'), " + id_sklep +
                ")";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            int a;
            if (!(data[0].Length > 0 && data[0].Length < 41)) // imie
                return false;
            if (!(data[1].Length > 0 && data[1].Length < 81)) // nazwisko
                return false;
            if (data[2].Length > 0 && data[2].Length < 4 && int.TryParse(data[2], out a)) // id_sklep
            {
                if (!SqlQueries.CheckForeignKey("SELECT * FROM SKLEP WHERE ID_SKLEP = " + data[2]))
                    return false;
            }
            imie = data[0];
            nazwisko = data[1];
            data_zatrudnienia = Globals.insertWindow.dateTimePicker1.Value.Date;
            id_sklep = int.Parse(data[2]);
            return true;
        }
    }
}
