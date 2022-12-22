using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    internal static class QueryGenerator
    {
        public static string dateSelect(int controlSum, bool min, bool max, bool mniejsze, bool wieksze, string column_name, string table_name, string date)
        {
            string sqlQuery;
            if (controlSum == 1 && mniejsze) // data, mniejsza
                sqlQuery = "select * from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') < to_date('" + date + "','YY/MM/DD')";
            else if (controlSum == 1 && wieksze) // data, wieksza
                sqlQuery = "select * from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') > to_date('" + date + "','YY/MM/DD')";
            else if (controlSum == 1 && min) // data, min
                sqlQuery = "select * from " + table_name + " where " + column_name + " = (select min(" + column_name + ") from " + table_name + ")";
            else if (controlSum == 1 && max) // data, max
                sqlQuery = "select * from " + table_name + " where " + column_name + "= (select max(" + column_name + ") from " + table_name + ")";
            else if (controlSum == 0) // data, rowna
                sqlQuery = "select * from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') = to_date('" + date + "','YY/MM/DD')";
            else return null;
            return sqlQuery;
        }

        public static string numberSelect(int controlSum, bool min, bool max, bool mniejsze, bool wieksze, string column_name, string table_name, string value)
        {
            string sqlQuery;
            if (float.TryParse(value, out _) &&
                mniejsze && controlSum == 1)// liczba, mniejsza
                sqlQuery = "select * from " + table_name + " where " + column_name + " < " + value.Replace(',', '.');
            else if (value != "" && wieksze && controlSum == 1
                && float.TryParse(value, out _))// liczba, wieksza
                sqlQuery = "select * from " + table_name + " where " + column_name + " > " + value.Replace(',', '.');
            else if (min && controlSum == 1)// liczba, min
                sqlQuery = "select * from " + table_name + " where " + column_name + " = (select min(" + column_name + ") from " + table_name + ")";
            else if (max && controlSum == 1)// liczba, max
                sqlQuery = "select * from " + table_name + " where " + column_name + " = (select max(" + column_name + ") from " + table_name + ")";
            else if (controlSum == 0 && float.TryParse(value, out _))// liczba, rowna
                sqlQuery = "select * from " + table_name + " where " + column_name + " = " + value.Replace(',', '.');
            else
                return null;
            return sqlQuery;
        }
        
        public static string dateDelete(bool mniejsze, bool wieksze, bool rowne, string table_name, string column_name, string date)
        {
            string sqlNonQuery;
            if (mniejsze)
                sqlNonQuery = "delete from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') < to_date('" + date + "','YY/MM/DD')";
            else if (wieksze)
                sqlNonQuery = "delete from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') > to_date('" + date + "','YY/MM/DD')";
            else if (rowne)
                sqlNonQuery = "delete from " + table_name + " where to_date(" + column_name + ", 'YY/MM/DD') = to_date('" + date + "','YY/MM/DD')";
            else
                return null;
            return sqlNonQuery;
        }

        public static string numberDelete(bool mniejsze, bool wieksze, bool rowne, string table_name, string column_name, string value) 
        {
            string sqlNonQuery;
            if (mniejsze)
                sqlNonQuery = "delete from " + table_name + " where " + column_name + " < " + value.Replace(',', '.');
            else if (wieksze)
                sqlNonQuery = "delete from " + table_name + " where " + column_name + " > " + value.Replace(',', '.');
            else if (rowne)
                sqlNonQuery = "delete from " + table_name + " where " + column_name + " = " + value.Replace(',', '.');
            else
                sqlNonQuery= null;
            return sqlNonQuery;
        }
        
        public static string cmdInsert(string[] data, string table_name)
        {
            string sqlCmd = null;
            switch (table_name)
            {
                case "KLIENT":
                    {
                        Klient k = new Klient();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "OPINIA":
                    {
                        Opinia k = new Opinia();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "KATEGORIE":
                    {
                        Kategorie k = new Kategorie();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "DOSTAWCA":
                    {
                        Dostawca k = new Dostawca();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "PRACOWNIK":
                    {
                        Pracownik k = new Pracownik();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "PRODUCENT":
                    {
                        Producent k = new Producent();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "PRODUKT":
                    {
                        Produkt k = new Produkt();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "SKLEP":
                    {
                        Sklep k = new Sklep();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "TRANSAKCJA":
                    {
                        Transakcja k = new Transakcja();
                        if (!k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
                case "PRODUKT_W_KOSZYKU":
                    {
                        Produkt_w_koszyku k = new Produkt_w_koszyku();
                        if (k.CheckIfDataIsValid(data))
                            sqlCmd = k.GenerateSqlDDL();
                        break;
                    }
            }
            return sqlCmd;
        }

    }
}
