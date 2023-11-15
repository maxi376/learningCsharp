using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Swap2Numbers
    {
        public static void swap2numbers1()
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.Write("After swap a= " + a + " b= " + b + '\n');
        }

        public static void swap2numbers2()
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b; //a=15 (5+10)      
            b = a - b; //b=5 (15-10)      
            a = a - b; //a=10 (15-5)   
            Console.Write("After swap a= " + a + " b= " + b + '\n');
        }
    }
}
