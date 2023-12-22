using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. Write a program in C# to find the total number of odd and even numbers accepted from the user.
namespace Assignments
{
    internal class Question5cs
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int ocount = 0, ecount = 0;

            Console.WriteLine("Enter Array Values");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    ecount++;
                }
                else
                {
                    ocount++;
                }
            }
            Console.WriteLine("Total Even Numbers:" + ecount);
            Console.WriteLine("Total Odd Numbers:" + ocount);
        



    }
    }
}
