using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Factorial
    {
        public static void factorialExample()
        {
            uint i, number;
            ulong factorial = 1;
            Console.Write("Enter any Number: ");
            try
            {
                number = uint.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }


            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.Write("Factorial of " + number + " is: " + factorial);
        }
    }
}
