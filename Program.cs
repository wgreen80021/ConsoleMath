using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMath
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            int Num1 = 50;
            Console.WriteLine("Please enter a number to be multiplied by 50 : ") ;
            string Num2 = Console.ReadLine();
            long NumTotl1 = Convert.ToInt64(Num2) * Num1;
            Console.WriteLine("Your Total for " + Num2 + " multiplied by " + Num1 + " is : " + Convert.ToString(NumTotl1));
            //Console.ReadLine();
            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            int Num3 = 25;
            Console.WriteLine("Please enter a number to be added to 25 : ");
            string Num4 = Console.ReadLine();
            int NumTotl2 = Convert.ToInt32(Num4) + Num3;
            Console.WriteLine("Your Total for " + Num4 + " plus " + Num3 + " is : " + Convert.ToString(NumTotl2));
            //Console.ReadLine();

            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            float Num5 = 12.5f;
            Console.WriteLine("Please enter a number to be divided by 12.5 : ");
            string Num6 = Console.ReadLine();
            float NumTotl3 = Convert.ToInt64 (Num6) / Num5;
            Console.WriteLine("Your Total for " + Num6 + " divided by " + Num5 + " is : " + Convert.ToString(NumTotl3));
            //Console.ReadLine();

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            int Num7 = 50;
            Console.WriteLine("Please enter a number to see if it is greater than 50 : ");
            string Num8 = Console.ReadLine();
            bool TrueFalse4 = Convert.ToInt64(Num8) > Num7;
            switch (TrueFalse4)
            {
                case false:
                    Console.WriteLine(Num8 + " is not greater than " + Num7);
                    break;

                case true:
                    Console.WriteLine(Num8 + " is greater than " + Num7);
                    break;
                    
            }

            //Console.ReadLine();

            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).

            int Num9 = 7;
            Console.WriteLine("Please enter a number to see if it divides evenly by 7 : ");
            string Num10 = Console.ReadLine();
            int Remainder = Convert.ToInt32(Num10) % Num9;
            int Div = Convert.ToInt32(Num10) / Num9;
            bool IsEven = Remainder > 0;
            switch (IsEven)
            {
                case false:
                    Console.WriteLine(Num9 + " divides evenly into  " + Num10 + " " + Div + " times");
                    break;

                case  true:
                    Console.WriteLine(Num10 + " divided by 7 leaves a remainder of " + Remainder);
                    break;

            }

            Console.ReadLine();
        }
    }
}
