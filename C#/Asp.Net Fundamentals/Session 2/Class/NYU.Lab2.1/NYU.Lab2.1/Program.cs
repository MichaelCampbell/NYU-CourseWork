using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NYU.Lab2._1
{
    class Program
    {
        #region Declare fields
        static int _numwords = 0;
        static int _numspaces = 0;
        static int _numpuncs = 0;
        //TODO: declare fields for the cont of numbers
        static int _numnumbers = 0;
        //TODO: declare fields for the cont of letters
        static int _numletters = 0;
        #endregion

        static void Main()
        {
            ProcessTextFile();
            WriteAnalysisReport();
            Pause();
        }
        static void Pause()
        {
            Console.Write("\npress any key to continue..");
            Console.ReadKey();
        }
        static void ProcessTextFile()
        {
            //TODO: declare a variable named filecontents of type string
            //      to hold the contents of lipsum.txt
            string filecontents = System.IO.File.ReadAllText("lipsum.txt");
            //NOTE: The System.IO namespace defines a class type named File
            //this type defines a static method named "ReadAllText" which
            //accepts the file name (as a string) and returns the contents of the
            //file as a string.

            //TODO: read the contents of lipsum.txt into the variable filecontents

            foreach (char c in filecontents)
            {
                if (char.IsPunctuation(c))
                {
                    _numpuncs++;
                }

                //TODO: If character is a number, increment the correct counter
                if (char.IsNumber(c))
                {
                    _numnumbers++;
                }
                //TODO: If character is a letter, increment the correct counter
                if (char.IsLetter(c))
                {
                    _numletters++;
                }

                if (char.IsWhiteSpace(c))
                {
                    _numwords++;    //whitespace delimites words
                    _numspaces++;
                }
            }
        }
        static void WriteAnalysisReport()
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("**\t\t\tText Analysis");
            Console.WriteLine("******************************************************");

            Console.WriteLine("\nThe document contains:\n");

            Console.WriteLine("{0,11}: {1,4}", "Words", _numwords);

            //TODO: write out the cont of numbers
            Console.WriteLine("{0,11}: {1,4}", "Numbers", _numnumbers);
            //TODO: write out the cont of letters
            Console.WriteLine("{0,11}: {1,4}", "Letters", _numletters);
            Console.WriteLine("{0,11}: {1,4}", "Punctuation", _numpuncs);
        }
    }
}
