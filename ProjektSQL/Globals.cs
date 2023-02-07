using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSQL
{
    public enum Tables
    {
        [Description("KLIENT")]
        Klient,
        [Description("DOSTAWCA")]
        Dostawca,
        [Description("KATEGORIE")]
        Kategorie,
        [Description("OPINIA")]
        Opinia,
        [Description("PRACOWNIK")]
        Pracownik,
        [Description("PRODUCENT")]
        Producent,
        [Description("PRODUKT")]
        Produkt,
        [Description("PRODUKT_W_KOSZYKU")]
        Produkt_w_koszyku,
        [Description("SKLEP")]
        Sklep,
        [Description("TRANSAKCJA")]
        Transakcja
    }
    internal static class Globals
    {
        public static DBManager dbManager;
        public static MainWindow mainWindow;
        public static InsertWindow insertWindow;
        //insertWindow wymaga funkcji zycztującej czas by potem wywalić to z globalsów bo jest to po prostu zle rozwiazanie
        public static System.Windows.Forms.Label[] labels = new System.Windows.Forms.Label[7];
        public static System.Windows.Forms.TextBox[] textBoxes = new System.Windows.Forms.TextBox[7];
    }
}
