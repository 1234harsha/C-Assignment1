using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question8
    {
        static void Main(string[] args)
        {
            //8. Write a program in C# to find the factorial of the given number.
            int i, f = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                f = f * i;
            }
            Console.Write("Factorial of " + number + " is: " + f);


        }
    }
}
