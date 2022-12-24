using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal static class Paging
    {
        static int rowsPerPage = 3;
        static int currentPage = 1;
        static DataTable dataSource;
        public static void SetDataSource(DataTable dt)
        {
            int i = 0;
            dataSource = dt;
            DataTable dataTable = dt.Clone();
            foreach(DataRow row in dataSource.Rows)
            {
                dataTable.ImportRow(row);
                i++;
                if (i == rowsPerPage)
                    break;
            }
            Globals.mainWindow.dataGV.DataSource = dataTable;
        }

        public static void IncreasePage()
        {
            
            if (currentPage * rowsPerPage > dataSource.Rows.Count)
                return;
            int limit;
            if (dataSource.Rows.Count < (currentPage + 1) * rowsPerPage)
                limit = dataSource.Rows.Count;
            else
                limit = (currentPage + 1) * rowsPerPage;
            DataTable dataTable = dataSource.Clone();
            for (int i=currentPage * rowsPerPage; i<limit;i++)
            {
                dataTable.ImportRow(dataSource.Rows[i]);
            }
            currentPage++;
            Globals.mainWindow.dataGV.DataSource = dataTable;
        }

        public static void DecreasePage()
        {
            if (currentPage == 1)
                return;
            DataTable dataTable = dataSource.Clone();
            for (int i = (currentPage - 2) * rowsPerPage; i < (currentPage-1) * rowsPerPage; i++)
            {
                dataTable.ImportRow(dataSource.Rows[i]);
            }
            currentPage--;
            Globals.mainWindow.dataGV.DataSource = dataTable;
        }
    }
}
