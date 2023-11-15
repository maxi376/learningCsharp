using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Exercise3
    {

        public void ex3imageKind()
        {
            /*Exercise 3:
             ask user to enter width and length of image.
            then tell if it is portrait or landscape*/

            ulong a, b;
            string s;
            try
            {
                Console.WriteLine("Please provide image width:");
                s = Console.ReadLine();
                a=Convert.ToUInt64 (s);
                Console.WriteLine("Please provide image height:");
                s = Console.ReadLine();
                b = Convert.ToUInt64 (s);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            if (a > b) Console.WriteLine("The painting is a landscape one");
            else if (b > a) Console.WriteLine("The painting is a portrait one");
        }
    }
}
