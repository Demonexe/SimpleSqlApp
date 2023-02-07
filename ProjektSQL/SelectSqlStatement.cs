using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace ProjektSQL
{
    internal class SelectSqlStatement
    {
        private OracleCommand cmd;
        private bool smaller { get; set; }
        private bool greater { get; set; }
        private bool min { get; set; }
        private bool max { get; set; }
        private string column_name { get; set; }
        private string table_name { get; set; }
        private string value { get; set; }
        private DateTime date { get; set; }
        private string type { get; set; }
        private int controlSum { get; set; }
        public SelectSqlStatement(bool smaller, bool greater, bool min, bool max, string column_name, string table_name, string value, DateTime date, string type)
        {
            this.smaller = smaller;
            this.greater = greater;
            this.min = min;
            this.max = max;
            this.column_name = column_name;
            this.table_name = table_name;
            this.value = value;
            this.date = date;
            this.type = type;
            cmd = new OracleCommand
            {
                Connection = Globals.dbManager.connection
            };
        }

        public OracleCommand BuildCommand()
        {
            controlSum = (smaller ? 1 : 0) + (greater ? 1 : 0) + (min ? 1 : 0) + (max ? 1 : 0);
            if (controlSum > 1)
                return null;
            if (type == "NUMBER")
                NumberSelect();
            else if (type == "VARCHAR2")
                VarcharSelect();
            else if (type == "DATE")
                DateSelect();
            else
                return null;
            return cmd;
        }

        private void NumberSelect()
        {
            if(min)
                cmd.CommandText = $"Select * from {table_name} where {column_name} = (select min({column_name}) from {table_name})";
            else if(max)
                cmd.CommandText = $"Select * from {table_name} where {column_name} = (select max({column_name}) from {table_name})";
            if (float.TryParse(value, out _) && smaller && value != "")// number, smaller
            {
                cmd.CommandText = $"Select * from {table_name} where {column_name} < :valuee";
                cmd.Parameters.Add(new OracleParameter("valuee", OracleDbType.Decimal, Decimal.Parse(value), ParameterDirection.Input));
            }
            else if (value != "" && greater && float.TryParse(value, out _))// number, greater
            {
                cmd.CommandText = $"Select * from {table_name} where {column_name} > :valuee";
                cmd.Parameters.Add(new OracleParameter("valuee", OracleDbType.Decimal, Decimal.Parse(value), ParameterDirection.Input));
            }
            else if (controlSum == 0 && float.TryParse(value, out _) && value != "")// number, equal
            {
                cmd.CommandText = $"Select * from {table_name} where {column_name} = :valuee";
                cmd.Parameters.Add(new OracleParameter("valuee", OracleDbType.Decimal, Decimal.Parse(value), ParameterDirection.Input));
            }
            else
                cmd = null;
        }

        private void DateSelect()
        {
            if (smaller) // date, smaller
            {
                cmd.CommandText = $"SELECT * FROM {table_name} where to_date({column_name}, 'YY/MM/DD') < to_date(:datee, 'YY/MM/DD')";
                cmd.Parameters.Add(new OracleParameter("datee", OracleDbType.Date, date, ParameterDirection.Input));
            }
            else if (greater) // date, greater
            {
                cmd.CommandText = $"SELECT * FROM {table_name} where to_date({column_name}, 'YY/MM/DD') > to_date(:datee,'YY/MM/DD')";
                cmd.Parameters.Add(new OracleParameter("datee", OracleDbType.Date, date, ParameterDirection.Input));
            }
            else if (min) // date, min
                cmd.CommandText = $"SELECT * FROM {table_name} where {column_name} = (select min({column_name}) from {table_name})";
            else if (max) // date, max
                cmd.CommandText = $"SELECT * FROM {table_name} where {column_name} = (select max({column_name}) from {table_name})";
            else if (controlSum == 0) // date, equal
            {
                cmd.CommandText = $"SELECT * FROM {table_name} where to_date({column_name}, 'YY/MM/DD') = to_date(:datee,'YY/MM/DD')";
                cmd.Parameters.Add(new OracleParameter("datee", OracleDbType.Date, date, ParameterDirection.Input));
            }
            else
                cmd = null;
        }

        private void VarcharSelect()
        {
            if (controlSum == 0 && value != "")// string, equal
            {
                cmd.CommandText = $"Select * from {table_name} where {column_name} = :valuee";
                cmd.Parameters.Add(new OracleParameter("valuee", OracleDbType.Varchar2, value, ParameterDirection.Input));
            }
            else
                cmd = null;
        }
    }
}
