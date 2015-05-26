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
            Console.WriteLine("Welcome to the Pig Latin Translator!\n");

            Console.Write("Please enter the English word you would like translated: ");
            string userInputString = Console.ReadLine();
            Console.WriteLine("\n");

            char[] vowelArray = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            int stringCut = 0;
            int loopCount = 0;
            bool specialCase = false;
            bool vowelFound = false;
            string preString = "";
            string postString = "";

            foreach (char c in userInputString) {
                for (int i = 0; i <= 4; i++) 
                {
                    char tmp = vowelArray[i];
                    if (c == tmp && loopCount == 0) 
                    {
                        specialCase = true;
                    }
                    else if (c == tmp && loopCount != 0)
                    {
                        stringCut = loopCount;
                        vowelFound = true;
                    }
                }
                if (vowelFound == true) break;
                loopCount++;
            }

            if (specialCase == true)
            {
                preString = userInputString;
                postString = "way";
                Console.WriteLine("Your translated word is: {0}{1}", preString, postString);
            }
            else
            {
                int strLength = userInputString.Length - stringCut;
                preString = userInputString.Substring(stringCut, strLength);
                postString = userInputString.Substring(0, stringCut);
                Console.WriteLine("Your translated word is: {0}{1}ay\n\n", preString, postString);
            }

            Console.Write("Thank you for using Josh's Pig Latin traslator! Please press Enter to exit.");
            Console.ReadLine();
        }
    }
}
