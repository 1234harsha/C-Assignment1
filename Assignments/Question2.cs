using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Question2
    {
        //2. Write a program in C# to accept the name of the user from command line and greet the user as:“Hi! username
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Name:");
            string username = Console.ReadLine();
            Console.WriteLine("Hi!" +username + "Welcome to the world of C#");
            Console.ReadKey();
        }
    }
}
