using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class Ucebna
    {
        public string Nazov {  get; set; }
        public string Popis {  get; set; }
        public int Kapacita { get; set; }
        public  Ucebna(string nazov, string popis, int kapacita)
        {
            Nazov = nazov;
            Popis = popis;
            Kapacita = kapacita;
        }
    }
}
