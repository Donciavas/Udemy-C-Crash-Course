using System;

namespace StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            /*string courseName = "Progamming language";
            string message = "Welcome to"*/
            /*for (int i = 0; i < courseName.Length; i++)
            {
                char character = courseName[i];
                Console.WriteLine(character);
            }*/
            #endregion

            string courseName = "Learn C# for Beginners Crash Course";

            /* int position;
             position = courseName.IndexOf(" c", StringComparison.OrdinalIgnoreCase);
             //position = courseName.LastIndexOf(" c", StringComparison.OrdinalIgnoreCase);
             Console.WriteLine(position);*/

            int position = -1;

            do
            {
                position = courseName.IndexOf(" c", position + 1, StringComparison.OrdinalIgnoreCase);
                if (position != -1)
                {
                    courseName = ReplaceByIndex(courseName, position, " c".Length, " Java");
                    Console.WriteLine(courseName);
                }
            } 
            while (position != -1);

            string fixedString = courseName.Replace(" Java", " C");
            Console.WriteLine(fixedString);
        }

        private static string ReplaceByIndex(string original, int start, int length, 
            string replacement)
        {
            string newString = original.Remove(start, length);
            return newString.Insert(start, replacement);
        }
    }
}
