using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //15. Write a program in C# to accept a word from the user and display the length of it.
    internal class Question15
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the word :");
            string word = Console.ReadLine();
            int Length = word.Length;
            Console.WriteLine($"length of the word {word} is :{Length}");

        }    }

}

