using System;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    public class MyClass
    {
        public string myString = "";

        public void Afisare()
        {
            Console.WriteLine("My name is");
            Console.WriteLine("My name is");
            Console.WriteLine("My name is");
        }
        
        public void strings()
        {
            int[] nrs = { 1, 2, 3, 4 };
            byte b = 1;
            float f = 1f;

            /*byte bb = Convert.ToByte(number);
            boolu = Convert.ToBoolean(number);
            myDouble = Convert.ToDouble(number);
            f = (float)Convert.ToDouble(number);
            b = (byte)Convert.ToDouble(number);
            Console.WriteLine(bb);*/
            //this one gets exceptions


            //HERE WE HAVE FORMAT STRING!!!!!
            //WILL BE REPLACED BY VALUES PASSED TO THE FUNCTION
            Console.WriteLine("{0}  {1}", b, f);
            Console.WriteLine("{0}  {1}", float.MinValue, float.MaxValue);


            //string MANIPULATION
            string name = "name";//string literal
            name = "name" + "gsdsgs";//string concatenation
            name = string.Format("{0} {1}", "guihsugee", "fewuhfuewihfugiew");
            //USING STRING FORMAT IS VERY CLASIC AND USEFUL

            name = string.Join(", ", nrs);//JOIN ARRAY ELEMENTS TOGHETER EASY

            //STRINGS ARE IMMUTABLE
            //THEY NEVER CHANGE
            //THEY NEVER CHANGE STATE
            //THEY CAN ONLY REFERANCE OTHER strings
            //ALL THE STRING OPERATIONS RETURN A NEW string


            //escape characters:
            // \n   \t  //  \\????     \'   \"
            //      \\ this means telling the compiler that we want to write \
            //not that it is the special character

            name = "J:\\empty\\empty";
            name = @"J:\empty\empty";//THE VERBATIM STRING
            //THESE ARE THE SAME
            name = @"this is first
this is second
this is third D:\folder1\folder2\fodler3";
            Console.WriteLine(name);


            //THE MOST USED/USEFUL STRING OPERATIONS +the ones from before:

        }


    }
}