using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ProjektSQL
{
    internal class DBManager
    {
        public OracleConnection connection;

        public async Task<string> SetConnection(string userName, string password)
        {
            OracleConnection conn;
            string conString = "Data Source=(DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST =localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = LOCAL)" +
                "(SERVICE_NAME = XEPDB1)));" +
                "User Id=" + userName + ";Password=" + password +";";
            try
            {
                conn = new OracleConnection(conString);
                conn.Open();
                connection = conn;
                return null;
            }
            catch (Exception e)
            {
                return e.Message.Split(new[] {':'},2)[1];
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
