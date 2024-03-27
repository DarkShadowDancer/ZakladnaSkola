using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ZakladnaSkola.KontrolaVstupu;

namespace ZakladnaSkola
{
    internal class ManazerSkoly
    {
        public static void VytvorSkolu()
        {
            Console.Clear();
            Console.WriteLine("Creating School...");
            string menoSkoly = null;
            while (menoSkoly == null)
            {
                Console.Write("Nazov novej skoly: ");
                menoSkoly = Console.ReadLine();
            }
            Skola skola1 = new(menoSkoly);
            ListSkol.pridatSkolu(skola1);
            Console.Clear();
        }
        public static void UpravitSkolu()
        {
            Console.Clear();
            if (ListSkol.Skoly.Count > 0)
            {
                Console.WriteLine("Editing School...");
                int i = 1;
                foreach (Skola skola in ListSkol.Skoly)
                {
                    Console.WriteLine("{0}.{1}", i, skola.Nazov);
                    i++;
                }
                Console.WriteLine("\nKtoru skolu chcete upravit? ");
                int upravaSkoly = InputValidator.GetValidInput(1, ListSkol.Skoly.Count);
                //Check if the parsed value is within the range of valid options
                //Checking right in inputvalidator
                upravaSkoly -= 1;
                UpravitSkolu(ListSkol.Skoly[upravaSkoly]);
            }
            else
            {
                Console.WriteLine("Pocet skol je 0 aku skolu chces upravovat? :)");
            }
        }
        public static void UpravitSkolu(Skola school)
        {
            SkolaUI.ZobrazMoznostiUprav();
            // Get user input
            int choice = InputValidator.GetValidInput(1, 6);
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"\nStare meno: {school.Nazov}");
                    string newName = MenuSkola.ZiskajNoveMenoSkoly();
                    school.Nazov = newName;
                    Console.WriteLine("Meno skoly uspesne zmenene.");
                    break;
                case 2:
                    // Add functionality to add a teacher to the school
                    // You can call methods like AddTeacher from here
                    break;
                case 3:
                    // Add functionality to add a classroom to the school
                    // You can call methods like AddClass from here
                    break;
                case 4:
                    // Add functionality to add a subject to the school
                    // You can call methods like AddSubject from here
                    break;
                case 5:
                    // Add functionality to add a class to the school
                    // You can call methods like AddClassroom from here
                    break;
                case 6:
                    Console.WriteLine("\nExiting school editor.");
                    break;
                default:
                    Console.WriteLine("Neplatna volba. Prosim zadajte platnu volbu.");
                    break;
            }
        }
        public static void VymazatSkolu()
        {
            Console.Clear();
            if (ListSkol.Skoly.Count > 0)
            {
                Console.WriteLine("Deleting School...");
                int i = 1;
                foreach (Skola skola in ListSkol.Skoly)
                {
                    Console.WriteLine("{0}.{1}", i, skola.Nazov);
                    i++;
                }
                Console.WriteLine("\nKtoru skolu chcete vymazat? ");
                int vymazatSkolu = InputValidator.GetValidInput(1, ListSkol.Skoly.Count);
                // Check if the parsed value is within the range of valid options
                //implemented it to InputValidator
                vymazatSkolu -= 1;
                Skola skolaToRemove = ListSkol.Skoly[vymazatSkolu];
                ListSkol.odstranitSkolu(skolaToRemove);
                Console.WriteLine("\nSkola odstranena uspesne.");
            }
            else
            {
                Console.WriteLine("Pocet skol je 0 aku skolu chces mazat? :)");
            }
        }
    }
}


