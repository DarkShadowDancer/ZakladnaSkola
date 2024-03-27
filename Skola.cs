using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class Skola
    {
        public string Nazov;
        public List<Ucitel> Ucitelia { get; set; }
        public List<Ucebna> Ucebny { get; set; }
        public List<Trieda> Triedy { get; set; }
        public List<Predmet> Predmety { get; set; }
        public Skola(string nazov)
        {
            Nazov = nazov;
        }
    }

}
