using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class SumDigits
    {
        public static void sumDigits()
        {
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            try
            {
                n = int.Parse(Console.ReadLine());

            }
            catch (Exception e) { Console.WriteLine(e.StackTrace); throw; }

            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
        }
    }
}
