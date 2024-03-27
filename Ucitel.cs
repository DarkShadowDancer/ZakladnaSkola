using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class Ucitel:Osoba
    {
        public string TitulPredMenom {  get; set; }
        public string TitulZaMenom {  get; set; }
        public Trieda HlavnaTrieda { get; set; }
        public List<Predmet> VyucovanePredmety { get; set; }

        public Ucitel(string meno,string priezvisko,DateTime datumNarodenia,string titulPredMenom, string titulZaMenom, Trieda hlavnaTrieda, List<Predmet> vyucovanePredmety)
        {
            Meno = meno;
            Priezvisko = priezvisko;
            DatumNarodenia = datumNarodenia;
            TitulPredMenom = titulPredMenom;
            TitulZaMenom = titulZaMenom;
            HlavnaTrieda = hlavnaTrieda;
            VyucovanePredmety = vyucovanePredmety;
        }
    }
}
