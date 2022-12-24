using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal interface ITable
    {
        string GenerateSqlDDL();
        bool CheckIfDataIsValid(string[] data);
    }
}
