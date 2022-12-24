using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class Dostawca : ITable
    {
        string nazwa;

        public string GenerateSqlDDL()
        {
            string sqlCmd = "Insert into DOSTAWCA values(DOSTAWCY_SEQ.NEXTVAL, '" + nazwa + "')";
            return sqlCmd;
        }

        public bool CheckIfDataIsValid(string[] data)
        {
            if (data[0].Length > 0 && data[0].Length < 201) // nazwa
            {
                nazwa = data[0];
                return true;
            }
            else
                return false;
        }
    }
}
