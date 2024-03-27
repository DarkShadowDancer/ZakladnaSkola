using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class Ziak:Osoba
    {
        public Trieda Trieda { get; set; }
        public Dictionary<Predmet, List<int>> Znamky { get; set; }

        public Ziak(string meno, string priezvisko,DateTime datumNarodenia,Trieda trieda,Dictionary<Predmet, List<int>> znamky)
        {
            Meno = meno;
            Priezvisko = priezvisko;
            DatumNarodenia = datumNarodenia;
            Trieda = trieda;
            Znamky = znamky;
        }
    }
}
