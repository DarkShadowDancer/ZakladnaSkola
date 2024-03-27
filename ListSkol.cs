using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class ListSkol
    {
        private static readonly List<Skola> skoly = new();

        public static IReadOnlyList<Skola> Skoly => skoly;
        
        public static void pridatSkolu(Skola skola)
        {
            skoly.Add(skola);
        }

        public static void odstranitSkolu(Skola skola)
        {
            skoly.Remove(skola);
        }

    }
}
