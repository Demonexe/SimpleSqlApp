using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal static class SqlQueries
    {
        public static int SqlNonQuery(string sqlCmd)
        {
            int deleted;
            Globals.dbManager.connection.Open();
            Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
            cmd.Connection = Globals.dbManager.connection;
            cmd.CommandText = sqlCmd;
            deleted = cmd.ExecuteNonQuery();
            Globals.dbManager.connection.Close();
            return deleted;
        }

        public static DataTable SqlSelect(string sqlCmd)
        {
            Globals.dbManager.connection.Open();
            Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
            cmd.Connection = Globals.dbManager.connection;
            cmd.CommandText = sqlCmd;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Globals.dbManager.connection.Close();
            return dt;
        }

        public static bool CheckForeignKey(string sqlCmd)
        {
            Globals.dbManager.connection.Open();
            Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
            cmd.Connection = Globals.dbManager.connection;
            cmd.CommandText = sqlCmd;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Globals.dbManager.connection.Close();
            if (dt.Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
}
