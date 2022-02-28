using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            /*int x = 3;
            //int y = x++;
            int y = x;
            x++;
            Console.WriteLine($"Using x++, x is {x} and y is {y}");
            // Using x++, x is 4 and y is 3

            x = 3;
            //y = ++x;
            x++;
            y = x;
            Console.WriteLine($"Using ++x, x is {x} and y is {y}");
            // Using ++x, x is 4 and y is 4

            Console.WriteLine("Don't do this!");
            x = 3;
            //y = ++x - x++;
            x++;
            int z = x;
            y = z - x;
            x++;
            Console.WriteLine($"Using ++x - x++, x is {x} and y is {y}");
            // ++x - x++ gives: x is 5 and y is 0

            x = 3;
            //y = x++ - ++x;
            z = x;
            x += 2;
            y = z - x;
            Console.WriteLine($"Using x++ - ++x, x is {x} and y is {y}");
            // x++ - ++x gives: x is 5 and y is -2 */
            #endregion

            #region
            /*double a = 12 * 3 / 4;
            double b = (12 * 3) / 4;
            double c = 12 * (3 / 4);
            Console.WriteLine($"{a} + {b} + {c}");
            Console.WriteLine();

            double d = 12.0 / 3.0 / 4.0;
            double e = (12.0 / 3.0) / 4.0;
            double f = 12.0 / (3.0 / 4.0);
            Console.WriteLine($"{d}, {e}, {f}");
            Console.WriteLine();

            int x = 12 + 3 * 4;
            int y = (12 + 3) * 4;
            int z = 12 + (3 * 4);
            Console.WriteLine($"{x}, {y}, {z}");*/
            #endregion

            #region
            /*int x = 12;
            int y = 3;

            if (x % y == 0)
            {
                Console.WriteLine($"{y} divides exactly into {x}");
            }
            else
            {
                Console.WriteLine($"{y} does not divide exactly into {x}");
            }*/

            /*for (int month = 1; month <= 12; month++)
            {
                Console.WriteLine($"The next month after {month} is {month % 12 + 1}");
            }*/
            #endregion

            #region
            /*int second = 31;
            int minute = 1;

            if ((minute < 59) && ((second + 1) > 59))
            {
                minute++;
            }*/
            #endregion

            #region
           /* int a = 12;
            int b = 0;

            *//*     if (b != 0)
                 {
                     int c = DivideTwoNumbers(a, b);
                     if (c == 2)
                     {
                         Console.WriteLine("We've found a 2");
                     }
                 }*//*

            if (b != 0 && DivideTwoNumbers(a, b) == 2)
            {
                Console.WriteLine("We've found a 2");
            }

            if (b == 0 || DivideTwoNumbers(a, b) == 2)
            {
                Console.WriteLine("We've found a 2");
            }
            static int DivideTwoNumbers(int x, int y)
            {
                return x / y;
            }*/
            #endregion

            int x = 12;
            x *= 34;
            Console.WriteLine(x);

            int y = 12;
            y = y * 34;
            Console.WriteLine(y);

            int z = y -= 8;
            Console.WriteLine($"y is {y}, z is {z}");
        }

        
        
            
    }
}
