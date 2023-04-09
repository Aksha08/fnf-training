using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{




    internal class MathCalculator

    {

        public static int AddNumbers(int ival1, int ival2) => ival1 + ival2;

        public static int SubtractNumbers(int ival1, int ival2) => ival1 - ival2;

        public static int MultiplyNumbers(int ival1, int ival2) => ival1 * ival2;

        public static int DivideNumbers(int ival1, int ival2) => ival1 + ival2;



    }

    internal class Mathcalc

    {

        const string menu = "```````````````CALC PROGRAM`````````````\r\nADDING 2 VALUES---------> PRESS 1\r\nSUBTRACTING 2 VALUES----> PRESS 2\r\nMULTIPLYING 2 VALUES----> PRESS 3\r\nDIVIDING 2 VALUES-------> PRESS 4\r\n";





        public static int Main(string[] args)   

        {

            do

            {
                Console.WriteLine(menu);
                Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());

                

                switch (choice)

                {

                    case 1:

                        addingNumbers();

                        break;

                    case 2:

                        subtractingNumbers();

                        break;

                    case 3:

                        multiplyingNumbers();

                        break;

                    case 4:

                        dividingNumbers();

                        break;

                    default:

                        break;

                }



            } while (true);

        }
        private static void addingNumbers()

        {

            Console.WriteLine("enter the 1st value");
            int ival1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the 2st value");
            int ival2 = int.Parse(Console.ReadLine());



            var result = MathCalculator.AddNumbers(ival1, ival2);

            Console.WriteLine("the added value is " + result);

        }
        private static void subtractingNumbers()

        {
            Console.WriteLine("enter the 1st value");
            int ival1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the 2st value");
            int ival2 = int.Parse(Console.ReadLine());


            var result = MathCalculator.SubtractNumbers(ival1, ival2);

            Console.WriteLine("the subtracted value is " + result);



        }
        private static void multiplyingNumbers()

        {


            Console.WriteLine("enter the 1st value");
            int ival1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the 2st value");
            int ival2 = int.Parse(Console.ReadLine());


            var result = MathCalculator.MultiplyNumbers(ival1, ival2);

            Console.WriteLine("the multiplied value is " + result);

        }





        private static void dividingNumbers()

        {

            Console.WriteLine("enter the 1st value");
            int ival1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the 2st value");
            int ival2 = int.Parse(Console.ReadLine());

            var result = MathCalculator.DivideNumbers(ival1, ival2);

            Console.WriteLine("the divided value is " + result);



        }   

    }
}







