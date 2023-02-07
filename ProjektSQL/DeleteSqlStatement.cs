using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace ProjektSQL
{
    internal class DeleteSqlStatement
    {
        private string type { get; set; }
        private bool smaller { get; set; }
        private bool greater { get; set; }
        private bool equal { get; set; }
        private string table_name { get; set; }
        private string column_name { get; set; }
        private DateTime date { get; set; }
        private string value { get; set; }
        private OracleCommand cmd;

        public DeleteSqlStatement(bool smaller, bool greater, bool equal, string table_name, string column_name, DateTime date, string value, string type)
        {
            this.smaller = smaller;
            this.greater = greater;
            this.equal = equal;
            this.table_name = table_name;
            this.column_name = column_name;
            this.date = date;
            this.value = value;
            this.type = type;
            cmd = new OracleCommand
            {
                Connection = Globals.dbManager.connection
            };
        }

        public OracleCommand BuildCommand()
        {
            if ((greater ? 1:0) + (smaller ? 1 : 0) + (equal ? 1 : 0) != 1)
                return null;
            if (type == "NUMBER")
                NumberDelete();
            else if (type == "DATE")
                DateDelete();
            else if (type == "VARCHAR2")
                VarcharDelete();
            else
                return null;
            return cmd;
        }

        private void DateDelete()
        {
            string sign;
            if (smaller)
                sign = "<";
            //sqlNonQuery = "delete from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') < to_date('" + date + "','YY/MM/DD')";
            else if (greater)
                sign = ">";
            //sqlNonQuery = "delete from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') > to_date('" + date + "','YY/MM/DD')";
            else if (equal)
                sign = "=";
            //sqlNonQuery = "delete from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') = to_date('" + date + "','YY/MM/DD')";
            else
            {
                cmd = null;
                return;
            }
            cmd.CommandText = $"Delete from {table_name} where to_date({column_name}, 'YY/MM/DD') {sign} to_date(:datee, 'YY/MM/DD')";
            cmd.Parameters.Add(new OracleParameter("datee", OracleDbType.Date, date, ParameterDirection.Input));
        }

        private void NumberDelete()
        {
            string sign;
            if (smaller)
                sign = "<";
            //sqlNonQuery = "delete from " + table_name + " where " + column_name + " < " + value.Replace(',', '.');
            else if (greater)
                sign = ">";
            //sqlNonQuery = "delete from " + table_name + " where " + column_name + " > " + value.Replace(',', '.');
            else if (equal)
                sign = "=";
            //sqlNonQuery = "delete from " + table_name + " where " + column_name + " = " + value.Replace(',', '.');
            else
            {
                cmd = null;
                return;
            }
            cmd.CommandText = $"Delete from {table_name} where {column_name} {sign} :valuee";
            cmd.Parameters.Add(new OracleParameter("valuee", OracleDbType.Decimal, Decimal.Parse(value), ParameterDirection.Input));
        }

        private void VarcharDelete()
        {
            if (equal)
            {
                cmd.CommandText = $"Delete from {table_name} where {column_name} = :valuee";
                cmd.Parameters.Add(new OracleParameter("valuee", OracleDbType.Varchar2, value, ParameterDirection.Input));
            }
            else
                cmd = null;
        }
    }
}
