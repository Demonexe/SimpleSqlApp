using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal class DBManager
    {
        public Oracle.ManagedDataAccess.Client.OracleConnection connection;
        private string connectionString;

        public string SetConnection(string userName, string password)
        {
             connectionString = "Data Source=(DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST =localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = LOCAL)" +
                "(SERVICE_NAME = XEPDB1)));" +
                "User Id=" + userName + ";Password=" + password +";";
            try
            {
                connection = new Oracle.ManagedDataAccess.Client.OracleConnection(connectionString);
                connection.Open();
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
