using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Write a program in C# to accept two numbers from command line and display all the numbers between the given two numbers.
namespace Assignments
{
    internal class Question3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Start Number:");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End Number:");
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = startNumber; i < endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
