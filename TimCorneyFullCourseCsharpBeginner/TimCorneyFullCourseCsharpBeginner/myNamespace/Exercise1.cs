using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Exercise1
    {
        //EX:validation data

        //Ex1:ask user enter number.
        /*should be between 1-10.
         if it is display valid,if not display invalid.
        */
        public void ex1validate()
        {
            ulong i;
            string s;
            Console.WriteLine("Please enter a number between 1 and 10");
            try
            {
                s=Console.ReadLine();
                i = Convert.ToUInt64(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            if(i>0 && i<10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

        }
    }
}
