using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Exercise2
    {
        /*Exercise 2:
         take 2 numbers from console and display the maximum of the 2*/

        public void ex2max()
        {
            ulong a, b;
            string s;
            try
            {
                s = Console.ReadLine();
                a = Convert.ToUInt64(s);
                s = Console.ReadLine();
                b = Convert.ToUInt64(s);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            if (a > b) { Console.WriteLine(a); }
            else { Console.WriteLine(b); }
        }
    }
}
