using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your age: ");
            int myAge = Convert.ToInt32(Console.ReadLine());
            int votingAge = 34;

            String result = (votingAge > myAge) ? "You are not eligible to vote" : "You're are eligible to vote";
            Console.WriteLine(result);

        }
    }
}