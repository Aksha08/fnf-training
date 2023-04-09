using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Oddeven
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            oddeven(arr);
        }
        private static void oddeven(int[] arr)
        {
            Console.WriteLine(" even numbers are");
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("odd numbers are");
            foreach (int j in arr)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }

            }
            while (true)
            {
                Console.WriteLine("enter the first num");
                double dValue1 = double.Parse(Console.ReadLine());

                Console.WriteLine("enter the second number");
                double dValue2 = double.Parse(Console.ReadLine());

                Console.WriteLine("enter the operator(+,-,*/)");
                char op = char.Parse(Console.ReadLine());
                double result = 0;
                switch (op)
                {
                    case '+':
                        result = dValue1 + dValue2;
                        break;
                    case '-':
                        result = dValue1 - dValue2;
                        break;
                    case '*':
                        result = dValue1 * dValue2;
                        break;
                    case '/':
                        result = dValue1 / dValue2;
                        break;
                    defalut:
                        Console.WriteLine("invalid operator");
                        break;
                }
                Console.WriteLine(result);
                Console.WriteLine("If you want to continue press (Y/N)");
                string userResponse = Console.ReadLine();
                if (userResponse != "Y")
                {
                    Console.WriteLine("exit");
                    break;
                }


            }

        }

    }
}
