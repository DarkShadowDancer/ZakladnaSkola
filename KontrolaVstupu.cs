using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladnaSkola
{
    internal class KontrolaVstupu
    {
        internal static class InputValidator
        {
            public static int GetValidInput(int minValue, int maxValue)
            {
                int input;
                while (true)
                {
                    if (minValue == maxValue)
                        Console.Write($"Zadaj cislo {minValue}: ");
                    else
                        Console.Write($"Vyber z moznosti {minValue} az {maxValue}: ");
                    if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out input))
                    {
                        if (input >= minValue && input <= maxValue)
                        {
                            return input;
                        }
                        else
                        {
                            Console.WriteLine("\nZly vstup. Prosim zadajte cislo ake je v moznostiach.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nZly vstup. Prosim zadajte len cislo.");
                    }
                }
            }
        }
    }
}
