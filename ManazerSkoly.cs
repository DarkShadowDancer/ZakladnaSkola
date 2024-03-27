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
                int i = 1;
                foreach (Skola skola in ListSkol.Skoly)
                {
                    Console.WriteLine("{0}.{1}", i, skola.Nazov);
                    i++;
                }
                Console.WriteLine("\nKtoru skolu chcete upravit? ");
                int upravaSkoly = InputValidator.GetValidInput(1, ListSkol.Skoly.Count);
                // -Check if the parsed value is within the range of valid options-.....Checking right in initialization ^^^^^^^
                    upravaSkoly -= 1;
                    UpravitSkolu(ListSkol.Skoly[upravaSkoly]);
            }
        }
        public static void UpravitSkolu(Skola school)
        {
            SkolaUI.ZobrazMoznostiUprav();
            // Get user input
            int choice = MenuSkola.ZiskatMoznost();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Stare meno: {0}", school.Nazov);
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
                    Console.WriteLine("Exiting school editor.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
        public static void VymazatSkolu()
        {
            Console.Clear();
            if (ListSkol.Skoly.Count > 0)
            {
                int i = 1;
                foreach (Skola skola in ListSkol.Skoly)
                {
                    Console.WriteLine("{0}.{1}", i, skola.Nazov);
                    i++;
                }
                Console.WriteLine("\nKtoru skolu chcete vymazat? ");
                int vymazatSkolu = InputValidator.GetValidInput(1, ListSkol.Skoly.Count);

                // Check if the parsed value is within the range of valid options
                if (vymazatSkolu >= 1 && vymazatSkolu <= ListSkol.Skoly.Count)
                {
                    vymazatSkolu -= 1;
                    Skola skolaToRemove = ListSkol.Skoly[vymazatSkolu];
                    ListSkol.odstranitSkolu(skolaToRemove);
                    Console.WriteLine("Skola odstranena uspesne.");
                }
            }
        }
    }
}


