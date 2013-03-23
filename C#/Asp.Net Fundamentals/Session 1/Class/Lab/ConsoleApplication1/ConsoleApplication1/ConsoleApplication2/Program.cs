using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<PLEASE LOG IN>\n");

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            Console.WriteLine("\n" + username + " logged in at " + DateTime.Now.ToString() + ".");
            Console.WriteLine("Login credentials: ");
            Console.WriteLine("\tusername: {0}", username);
            Console.WriteLine("\tpassword: {0}\n", password);
        }
    }
}
