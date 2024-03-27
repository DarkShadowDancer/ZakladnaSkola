using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class SkolaUI : Menu
    {
        public override void DisplayOptions()
        {
            Console.WriteLine("School Management Menu:");
            Console.WriteLine("1. Vytvorit skolu");
            Console.WriteLine("2. Upravit skolu");
            Console.WriteLine("3. Vymazat skolu");
            Console.WriteLine("4. Exit");
        }
        public static void ZobrazMoznostiUprav()
        {
            // Zobraz moznosti na upravu skoly
            Console.WriteLine("\n1. Zmenit meno skoly");
            Console.WriteLine("2. Editor Ucitelov");
            Console.WriteLine("3. Editor Tried");
            Console.WriteLine("4. Editor Predmetov");
            Console.WriteLine("5. Editor Ucebni");
            Console.WriteLine("6. Back");
        }
        public static void ZobrazMoznostiEditorUcitelov()
        {
            // Zobraz moznosti na upravu ucitelov
            Console.WriteLine("\n1. Pridat Ucitela");
            Console.WriteLine("2. Upravit Ucitela");
            Console.WriteLine("3. Vymazat Ucitela");
            Console.WriteLine("4. Back");
        }
        public static void ZobrazMoznostiEditorTried()
        {
            // Zobraz moznosti na upravu tried
            Console.WriteLine("\n1. Pridat Triedu");
            Console.WriteLine("2. Upravit Triedu");
            Console.WriteLine("3. Vymazat Triedu");
            Console.WriteLine("4. Back");
        }
        public static void ZobrazMoznostiEditorPredmetov()
        {
            // Zobraz moznosti na upravu predmetov
            Console.WriteLine("\n1. Pridat Predmet");
            Console.WriteLine("2. Upravit Predmet");
            Console.WriteLine("3. Vymazat Predmet");
            Console.WriteLine("4. Back");
        }
        public static void ZobrazMoznostiEditorUcebni()
        {
            // Zobraz moznosti na upravu ucebni
            Console.WriteLine("\n1. Pridat Ucebnu");
            Console.WriteLine("2. Upravit Ucebnu");
            Console.WriteLine("3. Vymazat Ucebnu");
            Console.WriteLine("4. Back");
        }
    }
}
