using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //16. Write a program in C# to accept a word from the user and display the reverse of it.
    internal class Question16
    {
        static void Main(string[] args)
    {

        Console.WriteLine("Enter the word");
        string word = Console.ReadLine();
        string reversedWord = ReverseWord(word);

        Console.WriteLine($"Reversed word: {reversedWord}");

        Console.ReadLine(); // Pause to see the result
    }

    static string ReverseWord(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the word :");
        //    string word = Console.ReadLine();
        //    int Length = word.Length;
        //    Console.WriteLine($"length of the word {word} is :{Length}");
        //}
    }
}
