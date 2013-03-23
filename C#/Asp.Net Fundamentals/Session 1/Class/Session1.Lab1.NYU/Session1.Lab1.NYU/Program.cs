using System;

namespace Session1.Lab1.NYU
{
    class Program
    {
        static int _numwords = 0;
        static int _numspaces = 0;
        static int _numpuncs = 0;
        //TODO:  declare fields for the cont of numbers
        //TODO:  declare fields for the cont of letters

/***************************************************************
 * Main function.  The C# compiler looks for a method with this
 * signature as a starting point for running the application.
 ****************************************************************/
        static void Main()
        {
            ProcessTextFile();

            WriteAnalysisReport();

            Pause();
        }

        /// <summary>
        /// This is a helper method.  All it does is pause the application to keep the consonle window open
        /// </summary>
        static void Pause()
        {
            Console.Write("\npress any key to continue..");
            Console.ReadKey();

            fl
        }


        static void ProcessTextFile()
        {
            //TODO:  declare a string variable named filecontents

            //TODO:  read the contents of lipsum.txt into the variable filecontents
                    // Use System.IO.File.ReadAllText() method to do this

            foreach (char c in filecontents)
            {
                if (char.IsPunctuation(c))
                {
                    _numpuncs++; //same as _numpuncs = _numpuncs + 1
                }

                if (char.IsWhiteSpace(c))
                {
                    _numWords++;  //whitespace delimites words, so add 1 to the word count
                    _numspaces++;
                }

                //TODO:  If character is a number, increment the correct counter
                //TODO:  If character is a letter, increment the correct counter
            }
        }

        static void WriteAnalysisReport()
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("**\t\t\tText Analysis");
            Console.WriteLine("****************************************************************");

            Console.WriteLine("\nThe document contains:\n");
            Console.WriteLine("{0,11}: {1,4}", "Words", _numwords);
            Console.WriteLine("{0,11}: {1,4}", "Punctuation", _numpuncs);

            //TODO:  write out the cont of numbers
            //TODO:  write out the cont of letters
        }
    }
}
