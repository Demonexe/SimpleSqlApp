using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal static class SqlQueries
    {
        public static async Task<int> SqlNonQuery(OracleCommand cmd)
        {
            int deleted;
            Globals.dbManager.connection.Open();
            deleted = cmd.ExecuteNonQuery();
            cmd.Dispose();
            Globals.dbManager.connection.Close();
            return deleted;
        }

        public static async Task<DataTable> SqlSelect(OracleCommand cmd)
        {
            Globals.dbManager.connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Dispose();
            Globals.dbManager.connection.Close();
            return dt;
        }

        public static bool CheckForeignKey(string sqlCmd)
        {
            Globals.dbManager.connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Globals.dbManager.connection;
            cmd.CommandText = sqlCmd;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmd.Dispose();
            Globals.dbManager.connection.Close();
            if (dt.Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
}
