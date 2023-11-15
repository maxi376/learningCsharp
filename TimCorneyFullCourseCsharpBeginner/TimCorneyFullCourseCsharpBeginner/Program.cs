using TimCorneyFullCourseCsharpBeginner.myNamespace;

namespace TimCorneyFullCourseCsharpBeginner
{
    internal class Program
    {
        //PROJECT WITH ALL THE BASICS OF C SHARP

        //MORE DETAILS AND THE FIRST PART IN L:\savedNotepad\IT\CAREERIT\C#trainings.txt
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //VERY VERY BASIC C SHARP JAVA ALL PROGRAMMING LANGUAGES THINGS


            //TYPE CONVERSIONS
            TypeConversionsAndDataTypes conv= new TypeConversionsAndDataTypes();
            //conv.fct();
            //extremly improtant to amke examples with all the things that could go wrong with basic
            //primitives and operations


            //using classes and namespaces
            MyClass myClass=new MyClass();
            myClass.Afisare();

            //using struct              structures!=classes     but 99% similar
            //use struct for very small lightweight entites SUCH AS RgbColor
            RgbColor colors;
            Point myPoint;


            //arrays are extremly usefull and will be properly disected,exemplified
            //arrays kinda exactly like java
            int[] nrs = { 1, 2, 3 };
            int[] nrs2 = new int[]{ 1, 2, 3 };
            int[] nrs3 = new int[4];
            //int[] nrs3 = new int[4]{ 1, 2, 3 };       NOT WORKING AT ALL


            //Highlighting TODOs And Fixes
            //TODO


            //string MANIPULATION
            myClass.strings();


            //enums are used when dealing with multiple constants for an entity


            //CLASSES VS STRUCTURES
            //STRUCTURES=VALUE TYPES            STACK MEMORY
            //IMMEDIATLY REMOVED IF OUT OF SCOPE

            //CLASSES=REFERENCE TYPES           HEAP MEMORY
            //GARBAGE COLLECTED BY CLR




            //creating programs for problems and checking results:
            //https://www.javatpoint.com/csharp-programs

            //ce vreau sa testez pot sa decomentez cu CTRL+/
            //sau default:CTRL+K,CTRL+C

            Fibonacci fibonacci= new Fibonacci();
            //fibonacci.showNFibonacciNumbers();
            //fibonacci.showNFibonacciNumbersRecursive();

            PrimeNumber primeNumber= new PrimeNumber();
            /*Console.WriteLine(primeNumber.checkPrimeNumber(-1));
            Console.WriteLine(primeNumber.checkPrimeNumber(1));
            Console.WriteLine(primeNumber.checkPrimeNumber(2));
            Console.WriteLine(primeNumber.checkPrimeNumber(13));
            Console.WriteLine(primeNumber.checkPrimeNumber(113));
            Console.WriteLine(primeNumber.checkPrimeNumber(120));*/

            Palindrome palindrome=new Palindrome();
            /*Console.WriteLine("1234 "+palindrome.checkPalindrome(1234));
            Console.WriteLine("1 "+palindrome.checkPalindrome(1));
            Console.WriteLine("1221 "+palindrome.checkPalindrome(1221));
            Console.WriteLine("12 "+palindrome.checkPalindrome(12));
            Console.WriteLine("121 "+palindrome.checkPalindrome(121));*/

            //Factorial.factorialExample();

            //ArmstrongNumbers.showArmstrongNumbers();

            //SumDigits.sumDigits();

            //ReverseNumber.reverseNumber();

            //Swap2Numbers.swap2numbers1();
            //Swap2Numbers.swap2numbers2();

            //ConvertNumberInCharacters.convertNumberInCharacters();

            Exercise1 ex1 = new Exercise1();
            //ex1.ex1validate();

            Exercise2 ex2 = new Exercise2();
            //ex2.ex2max();

            Exercise3 ex3 = new Exercise3();
            //ex3.ex3imageKind();

            Exercise4 ex4 = new Exercise4();
            //ex4.ex4SpeedCamera();
        }
    }
}

public struct RgbColor
{
    public int red;
    public int green;
    public int blue;
}public struct Point
{
    public int x;
    public int y;
}