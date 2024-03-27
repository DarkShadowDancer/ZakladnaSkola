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
                        Console.Write($"Vyber z moznosti {minValue} a {maxValue}: ");
                    if (int.TryParse(Console.ReadLine(), out input))
                    {
                        if (input >= minValue && input <= maxValue)
                        {
                            return input;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number within the specified range.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }
        }
    }
}
