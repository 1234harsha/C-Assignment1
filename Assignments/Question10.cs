using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question10
    {
        //10. Write a program in C# to find the multiplication table of the given number till 20.
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                int result = number * i;
                Console.WriteLine($"Multiplication of table:{number}");
                Console.WriteLine($"{number} x{i} = {result}");
            }
        
    }
    }
}
