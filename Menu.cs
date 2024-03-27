using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class Menu
    {
        public virtual void DisplayOptions()
        {
            Console.WriteLine("Menu....");
        }

        protected virtual void HandleInput(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Vytvorit......");
                    break;
                case 2:
                    Console.WriteLine("Editovat.....");
                    break;
                case 3:
                    Console.WriteLine("Vymazat.....");
                    break;
                case 4:
                    Console.WriteLine("\nExiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nZla moznost skuste znova.");
                    break;
            }
        }

        public virtual void Run()
        {
            while (true)
            {
                DisplayOptions();

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
    }
}
