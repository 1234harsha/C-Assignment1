using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question12
    {
        static void Main(string[] args)
        {
       //12. Write a program in C# to find the largest of the given three numbers. Accept the numbers from the  users.
                        Console.WriteLine("Enter the first number :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($" Largest number is :{n1}");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"largest number is :{n2}");
            }
            else
            {
                Console.WriteLine($"largest number is ::{n3}");
            }
        }
    
}
}
