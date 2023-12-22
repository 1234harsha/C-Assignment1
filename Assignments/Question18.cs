using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question18
    {
        //18. Write a program in C# to accept a word and to find out whether the given word is a palindrome or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            if (word == reverse)
            {
                Console.WriteLine("Word is a Palindrome.");
            }
            else
            {
                Console.WriteLine(" Word is not Palindrome");
            }
        }
        }
}
