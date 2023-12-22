using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question17
    {
        static void Main(string[] args)
        {
            //17. Write a program in C# to accept two words from user and find out if they are same.
            Console.WriteLine("Enter the first word");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string Secondword = Console.ReadLine();
            if (firstWord == Secondword)
            {
                Console.WriteLine("words are same");
            }
            else
            {
                Console.WriteLine("Words are not same");
            }
        }
    }


}