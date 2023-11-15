using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class Fibonacci
    {
        private int first;
        private int second;
        string rez;

        public void showNFibonacciNumbers()
        {
            string input;
        
            int n;
            Console.WriteLine("Selected: Print Fibonacci series\nPlease input the series length: ");
            try
            {
                input=Console.ReadLine();

                n=Convert.ToInt32(input);
                switch(n)
                {
                    case < 0:
                        {
                            Console.WriteLine("Do you want to change the input from a negative number" +
                                "to a positive one? Y/N");
                            string confirmation = Console.ReadLine();
                            if(confirmation == "Y" ) { 
                                input= Console.ReadLine();
                                n=Convert.ToInt32(input);
                                if(n < 0) 
                                {
                                    Console.WriteLine("the input is still negative, aborting operation");
                                    break;
                                }
                                else 
                                {
                                    fibonaci(n);
                                    break;
                                }

                            }
                            break;
                        }
                    case >=0:
                        {
                            fibonaci(n);
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error intercepted.");
                Console.WriteLine(e.StackTrace);
                throw;
            }
            
        }
        
        public void showNFibonacciNumbersRecursive()
        {
            string input;
            int n;
            rez = "";

            Console.WriteLine("Selected: Print Fibonacci series with recursivity" +
                "\nPlease input the series length: ");
            try
            {
                input = Console.ReadLine();

                n = Convert.ToInt32(input);
                switch (n)
                {
                    case < 0:
                        {
                            Console.WriteLine("Do you want to change the input from a negative number" +
                                "to a positive one? Y/N");
                            string confirmation = Console.ReadLine();
                            if (confirmation == "Y")
                            {
                                input = Console.ReadLine();
                                n = Convert.ToInt32(input);
                                if (n < 0)
                                {
                                    Console.WriteLine("the input is still negative, aborting operation");
                                    break;
                                }
                                else
                                {
                                    for(int i = 0; i <= n;i++)
                                        rez+= fibonacciRecursive(i)+ " ";
                                    Console.WriteLine(rez);
                                    break;
                                }

                            }
                            break;
                        }
                    case >= 0:
                        {
                            for (int i = 0; i <= n; i++)
                                rez += fibonacciRecursive(i) + " ";
                            Console.WriteLine(rez);
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error intercepted.");
                //e.StackTrace();
                throw;
            }
        }

        private void fibonaci(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("0\n");
                return;
            }
            if (n == 1) {
                Console.WriteLine("0 1\n");
                return;
            }
            first = 0; 
            second = 1;
            string rez = "";
            if (n>1)
            {
                rez += first;
                rez += " " + second;
                for(int i=2; i<=n; i++)
                {
                    int sum = first + second;
                    first = second;
                    second=sum;
                    rez+= " " + second;
                }

                Console.WriteLine(rez);
                Console.WriteLine();
            }
        }

        /*private void fibonaci(int first, int second, int n)
        {
            if (n == 0)
            {

            }
            if(n == 1)
            {
                rez = second + " " + rez;
                rez = first + " " + rez;
            }
            if (n > 1)
            {
                int sum=first + second;
                fibonaci(first, sum, n - 1);
                rez = sum + " " + rez;
            }
        }*/

        private int fibonacciRecursive(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                return fibonacciRecursive(num - 1) + fibonacciRecursive(num - 2);
            }
        }

    }
}
