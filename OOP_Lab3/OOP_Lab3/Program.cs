using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var continueLoop = true;

            do
            {
                try
                {
                    Console.Write("Enter the miles: ");
                    double.TryParse(Console.ReadLine(), out var miles);
                    Console.WriteLine();
                    Console.Write("Enter the gallons: ");
                    double.TryParse(Console.ReadLine(), out var gallons);

                    var result = miles / gallons;

                    Console.WriteLine($"\nResult: {miles}/{gallons} = {result}");
                    continueLoop = false;
                }
                catch (DivideByZeroException divideByZeroEx)
                {
                    Console.WriteLine($"{divideByZeroEx.Message}");
                    Console.WriteLine("0 is an invalid number of gallons.");
                }
                catch (NegativeNumberException negativeNumberEx)
                {
                    Console.WriteLine($"{negativeNumberEx.Message}");
                    
                }
            } while (continueLoop);
        }
    }
}
