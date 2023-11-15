using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Conditionals
    {
        public void doConditionals()
        {
            int i = 1;

            if (i == 1 && true || false)
            {
                if (false)
                {

                }
                else
                {

                }
            }
            else
            {

            }

            //SWITCH CASE

            //LA C# CONTROL NU POATE PICA DE LA CASE I LA CASE J SAU DEFAULT
            //CERE NEAPARAT BREAK LOL

            //BINE DAR DACA SUNT 2 CAZURI EXACT LA FEL SE POATE TRECE LA URMATORUL CASE
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine(1);
                        break;
                    }
                case 2:
                case 3: //da, case urile astea 3 se refera la exact acelasi caz=case 4
                case 4: //cam la fel ca in java,dar uneori esti obligat sa pui break
                    {
                        Console.WriteLine(2);
                        break;
                    }
                default:
                {
                    Console.WriteLine(3);
                    break;
                }
            }
        }
    }
}
