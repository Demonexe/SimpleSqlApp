using Oracle.ManagedDataAccess.Client;
using System;
using System.ComponentModel;
using System.Data;

namespace ProjektSQL
{
    internal static class QueryGenerator
    {
        public static OracleCommand CmdInsert(string[] data, string table_name)
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
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = sqlCmd;
            cmd.Connection = Globals.dbManager.connection;
            return cmd;
        }
    }
}
