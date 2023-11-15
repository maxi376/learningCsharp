using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Exercise4
    {
        public void ex4SpeedCamera()
        {
            /*Ex4:program for speed camera
             ask user enter speed limit
            then program asks for the speed of the car
            if value is less then display OK
            if the value is aboce the speed limit,the program should calculate
            the number of demerit points
            for every 5km/h above the speed limit there will be 1 demerit points
            and displayed in the console
            if demerit points>12 then display license suspended.*/

            ulong a, b;
            string s;

            Console.WriteLine("Please enter the speed limit:");
            try
            {
                s = Console.ReadLine();
                a = Convert.ToUInt64(s);

                Console.WriteLine("Please enter the speed of the car:");
                s = Console.ReadLine();
                b = Convert.ToUInt64(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            if (b <= a)
            {
                Console.WriteLine("OK");
            }else if(b > a) 
            {
                ulong dif = b - a;
                ulong demeritPoints = dif / 5;
                if (demeritPoints > 12) { Console.WriteLine("License Suspended"); }
                else { Console.WriteLine("Demerit Points earned: "+demeritPoints); }
            }

            /*switch(b)
            {
                case < a:
                    Console.WriteLine();
                    break;
                case > a:
                    {
                        int demeritPoints = 0;
                        Console.WriteLine();
                        break;
                    }
            }*/
        }
    }
}
