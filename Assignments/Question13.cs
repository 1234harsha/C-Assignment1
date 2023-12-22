using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question13
    {
        static void Main(string[] args)
        {
            //13. Write a program in C# to find the smallest of five numbers accepted from the user.
            int[] arr = new int[5];
           
            Console.WriteLine("Enter Values");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            int arr2 = arr.Min(); //min built in function
            Console.WriteLine(arr2);

            
        }
    }
}
