using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class Predmet
    {
        public string Nazov {  get; set; }
        public string Kod { get; set; }
        public string Popis {  get; set; }
        public int Rocnik { get; set; }
        public Predmet(string nazov, string kod, string popis, int rocnik)
        {
            Nazov = nazov;
            Kod = kod;
            Popis = popis;
            Rocnik = rocnik;
        }
    }
}
