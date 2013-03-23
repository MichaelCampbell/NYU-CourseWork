using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NYU.Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build I
            //int a = 0, b = 0, c = 0, d = 0, e = 0, even = 0, odd = 0;
            //Console.Write("Please input a number: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please input a number: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please input a number: ");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please input a number: ");
            //d = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please input a number: ");
            //e = Convert.ToInt32(Console.ReadLine());
            //int[] nums = { a, b, c, d, e };


            //foreach (int i in nums)
            //{
            //    if (i % 2 == 0)
            //    {
            //        even++;
            //    }
            //    else
            //        odd++;
            //}

            //Console.WriteLine("\nYou typed in {0} even numbers", even);
            //Console.WriteLine("and {0} odd numbers", odd);

            ////Build II
            //int even = 0, odd = 0;
            //ArrayList list = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Please input a number: ");
            //    list.Add(Convert.ToInt32(Console.ReadLine()));
            //}

            //foreach (int i in list)
            //{
            //    if (i % 2 == 0)
            //    {
            //        even++;
            //    }
            //    else
            //        odd++;
            //}

            //Console.WriteLine("\nYou typed in {0} even numbers", even);
            //Console.WriteLine("and {0} odd numbers", odd);

            //Build II
            int even = 0, odd = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please input a number: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else
                    odd++;
            }

            Console.WriteLine("\nYou typed in {0} even numbers", even);
            Console.WriteLine("and {0} odd numbers", odd);
        }
    }
}
