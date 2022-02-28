using System;
using System.Text;

namespace ImmutableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            #region
            /*int x = 5;
            int y = x;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"x is the same as y: {object.ReferenceEquals(x, y)}");

            string first = "This is a string";
            string second = first;

            Console.WriteLine($"first:  {first}");
            Console.WriteLine($"second: {second}");
            Console.WriteLine($"first is the same as second:  {object.ReferenceEquals(first, second)}");

            Console.WriteLine();
            first = first.Remove(4, 5); // nuo 4 char, penkis char delete
            first = first.Insert(4, " is a");
            Console.WriteLine($"first:  {first}");
            Console.WriteLine($"second: {second}");
            Console.WriteLine($"first is the same as second:  {object.ReferenceEquals(first, second)}");
            Console.WriteLine($"first == second: {first == second}");
            Console.WriteLine($"first .Equals second: {first.Equals(second)}");*/
            #endregion

           /* StringBuilder first = new StringBuilder ("This is a string");
            StringBuilder second = new StringBuilder("This is a string");*/

            #region
            /*Console.WriteLine($"first:  {first}");
            Console.WriteLine($"second: {second}");
            Console.WriteLine($"first is the same as second:  {object.ReferenceEquals(first, second)}");

            Console.WriteLine();
            first = first.Remove(4, 5); // nuo 4 char, penkis char delete
            //first = first.Insert(4, " is a");*/
            #endregion

            /*Console.WriteLine($"first:  {first}");

            Console.WriteLine("Clearing first...");*/
            /*first.Length = 0;
            Console.WriteLine($"first:  *{first}*");

            first.Append("Another string");*/

            ////first.Clear();
            ////first.Append("Another string");
            //first.Clear().Append("Another string").Append(" ").Append(second);

            //Console.WriteLine($"first:  *{first}*");
            #region
            /*Console.WriteLine($"second: {second}");
            Console.WriteLine($"first is the same as second:  {object.ReferenceEquals(first, second)}");
            Console.WriteLine($"first == second: {first == second}");
            Console.WriteLine($"first .Equals second: {first.Equals(second)}");*/
            #endregion

           /* Console.WriteLine("Challenge Solution");

            if (first.Clear () == first)
            {
                Console.WriteLine("The references are the same");
            }

            if (object.ReferenceEquals(first.Clear(), first))
            {
                Console.WriteLine("The references are the same");
            }

            StringBuilder checkReference = first.Clear ();
            if (checkReference == first)
            {
                Console.WriteLine("The references are the same");
            }

            first.Append("Another string");
            first.Clear().Append("Another string").Append(" ").Append(second);
            Console.WriteLine($"first:  *{first}*");
            Console.WriteLine($"checkReference: *{checkReference}*");*/

            #endregion

            StringBuilder first = new StringBuilder("The values are ");

            int a = 12;
            int b = 34;
            int c = 56;

            //first.AppendFormat("a = {0}, b = {1}, c = {2}", a, b, c);
            first.AppendLine(":");
            first.Append($"a = {a}, b = {b}, c = {c} ");
            Console.WriteLine(first);

            first.Append(12.ToString());
            first.Append(' '.ToString());
            first.Append(3.45.ToString());
            first.Append(' '.ToString());
            first.Append(a == 12).ToString();
            first.Append(' '.ToString());
            first.Append(b > c).ToString();

            first.AppendLine().Append('*', 40);

            Console.WriteLine(first);
        }
    }
}
