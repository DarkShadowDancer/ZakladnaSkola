using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class Trieda
    {
        public string Nazov {  get; set; }
        public int Rocnik { get; set; }
        public List<Ziak> Zaci {  get; set; }
        public Ucitel TriednyUcitel { get; set; }
        public Trieda(string nazov, int rocnik, List<Ziak> zaci, Ucitel triednyUcitel)
        {
            Nazov = nazov;
            Rocnik = rocnik;
            Zaci = zaci;
            TriednyUcitel = triednyUcitel;
        }
    }
}
