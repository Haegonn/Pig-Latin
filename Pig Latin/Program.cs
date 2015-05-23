using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the Pig Latin Translator!\n");

            // TODO Ask the user to input the word they would like translated.

            string testString = "pig";

            // Do the translation calculations.
            char[] vowelArray = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c in testString)
            {
                for (int i = 0; i <= 4; i++)
                {
                    char tmp = vowelArray[i];
                    if (c == tmp && i == 0)
                    {
                        // TODO Handle the "egg" situation (first character is vowel)
                        Console.Write("Code 1");
                    } 
                    else if (c == tmp && i != 0)
                    {
                        string tmpString = "";
                        for (int x = 0; x <= i; x++)
                        {
                            tmpString = tmpString + vowelArray[x];
                        }

                        Console.WriteLine(tmpString);
                    }
                }
            }

            Console.ReadLine();

            // Do the console printing.
            Console.WriteLine("String before translation: {0}", testString);
            //Console.WriteLine("String after translation:  {0}", resultString);
        }
    }
}
