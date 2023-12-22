using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
//4. Accept a number from the user and display whether the given number is an odd number or even number.
namespace Assignments
{
    internal class Question4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to check whether it's a odd number or even:");
            int number = int.Parse(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine(number +" is even number");
            }
            else
            {
                Console.WriteLine(number +" is odd number");
            }
        }
        }
}
