using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unhandled();
            //Handled();
            //TryParse();
            //ThrowExample();
        }

        private static void Unhandled()
        {
            Console.Write("Enter an integer: ");
            var input = Console.ReadLine();
            var output = int.Parse(input);
            Console.WriteLine(output);
        }

        private static void Handled()
        {
            try
            {
                Unhandled();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                //Don't do anything fancy in your catch block
                //because things can go wrong.
                //var x = 0;
                //var y = 0;
                //var z = x / y;
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            //This handles all the exceptions.
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            finally
            {
                Console.WriteLine("Thank you!");
            }
        }

        private static void TryParse()
        {
            Console.Write("Enter an integer: ");
            var input = Console.ReadLine();
            bool success = int.TryParse(input, out var output);

            if (success)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("You did something wrong, boo!");
            }
        }

        private static void ThrowExample()
        {
            Console.Write("Enter an integer: ");
            var input = Console.ReadLine();
            var output = int.Parse(input);

        }
    }
}
