using System;

namespace Session1.Lab1.NYU
{
    class Program_Solution
    {
        static int _numwords = 0;
        static int _numspaces = 0;
        static int _numpuncs = 0;
        static int _numnumbers = 0;
        static int _numletters = 0;

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
        }


        static void ProcessTextFile()
        {
            string filecontents = System.IO.File.ReadAllText("lipsum.txt");

            foreach (char c in filecontents)
            {
                if (char.IsPunctuation(c))
                {
                    _numpuncs++; //same as _numpuncs = _numpuncs + 1
                }

                if (char.IsWhiteSpace(c))
                {
                    _numwords++;  //whitespace delimites words, so add 1 to the word count
                    _numspaces++;
                }

                if (char.IsNumber(c))
                {
                    _numnumbers++;
                }
                if (char.IsLetter(c))
                {
                    _numletters++;
                }
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
