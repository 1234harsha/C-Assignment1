using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //6. Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.
    internal class Question6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperature in Celsius: {celsius}°C");

            Console.ReadLine();

        }
        }
}
