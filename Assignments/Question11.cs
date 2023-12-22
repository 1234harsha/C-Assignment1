using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question11
    {
        static void Main(string[] args)
        {
            //11. Write a program to print the numbers divisible by 7 between 200 and 300.
            Console.WriteLine("enter the number");

            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
