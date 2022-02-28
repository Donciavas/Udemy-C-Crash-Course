using System;

namespace StringEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "This is a string";
            string second = "THIS IS A STRING";
            //Are the same:
            Console.WriteLine(first == second);
            Console.WriteLine(second == first);
            //Are the same value:
            Console.WriteLine(first.Equals(second, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(second.Equals(first, StringComparison.OrdinalIgnoreCase));
        }
    }
}
