using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCorneyFullCourseCsharpBeginner.myNamespace
{
    internal class TypeConversionsAndDataTypes
    {
        public void fct()
        {
            //TYPE CONVERSIONS

            try
            {
                //NOT AT ALL GOOD PRACTICE TO USE VAR NAMES:b, i, f, nr
                //only in for() or while


                //implicit
                //CAND RANGE UL DE BITS IN STORAGE E MAI MARE CA ARGUMENTUL
                byte b = 1;
                int i = b;
                float f = i;

                //explicit
                //CAND RANGE UL DE BITS IN STORAGE E MAI MIC CA ARGUMENTUL
                f = 1f;
                i = (int)f;
                b = (byte)i;


                //eamples convert and when it throws exceptions
                var nr = 0;
                var number = "1234";
                Boolean boolu;
                //here more special primitives,or just types
                Double myDouble = 1.2;
                float floatul = 1.2f;
                Decimal decimalul = 1.2m;

                Int32 thisI = 1;
                int thatI = 1;
                //exactly the same
                //int is a struct in System
                String thisString;
                string thatString;
                //ALMOST EXACTLY THE SAME
                //String IS A CLASS AND
                //string IS A STRUCT


                byte bb = Convert.ToByte(number);
                boolu = Convert.ToBoolean(number);
                myDouble = Convert.ToDouble(number);
                f = (float)Convert.ToDouble(number);
                b = (byte)Convert.ToDouble(number);
                Console.WriteLine(bb);


                //HERE WE HAVE FORMAT STRING!!!!!
                //WILL BE REPLACED BY VALUES PASSED TO THE FUNCTION
                Console.WriteLine("{0}  {1}", b, f);
                Console.WriteLine("{0}  {1}", float.MinValue, float.MaxValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {

            }
            //extremly improtant to amke examples with all the things that could go wrong with basic
            //primitives and operations
        }
    }
}
