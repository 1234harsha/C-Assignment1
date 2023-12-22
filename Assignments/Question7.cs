using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question7
    {
        //7. Write a program to print the series: 0,1,4,9,16,.....625
        static void Main()
        {
            for (int i = 0; i <= 625; i++)
            {
                int square = i * i;
                Console.Write(square + " ");

                if (square == 625)
                    break;
            }

            Console.ReadLine();
        }
    }
}
