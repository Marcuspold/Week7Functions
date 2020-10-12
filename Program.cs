using System;
using System.Security.Cryptography.X509Certificates;

namespace Week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            UserAge();
           
        }
        public static void UserAge()
        {
            Console.WriteLine("Enter your year of birth: ");
            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2020 - YearOfBirth;
            Console.WriteLine($"You are {Age} years old. ");
        }
    }
}
