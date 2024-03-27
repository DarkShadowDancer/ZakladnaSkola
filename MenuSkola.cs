using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ZakladnaSkola.KontrolaVstupu;

namespace ZakladnaSkola
{
    internal class MenuSkola : Menu
    {
        private SkolaUI schoolUI;
        public MenuSkola(SkolaUI schoolUI)
        {
            this.schoolUI = schoolUI;
        }
        public override void Run()
        {
            while (true)
            {
                schoolUI.DisplayOptions(); // Call the overridden method directly
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    HandleInput(choice);
                }
                else
                {
                    Console.WriteLine("Zla moznost skuste znova.");
                }
            }
        }
        protected override void HandleInput(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Creating School...");
                    // Implement logic to create a new school
                    ManazerSkoly.VytvorSkolu();
                    break;
                case 2:
                    Console.WriteLine("Editing School...");
                    // Implement logic to edit an existing school
                    ManazerSkoly.UpravitSkolu();
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Deleting School...");
                    // Implement logic to delete an existing school
                    ManazerSkoly.VymazatSkolu();
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
                default:
                    base.HandleInput(choice);
                    break;
            }
        }
        public static int ZiskatMoznost()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                InputValidator.GetValidInput(1, 6);
            }
            return choice;
        }

        public static string ZiskajNoveMenoSkoly()
        {
            Console.Write("Zadaj nove meno skoly: ");
            return Console.ReadLine();
        }
    }
}
