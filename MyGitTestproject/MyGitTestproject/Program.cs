using System;
using System.Text.RegularExpressions;

namespace MyGitTestproject
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckForValidEmail();
            //CheckForValidZipcode();


        }

        private static void CheckForValidEmail()
        {
            Console.Write("Enter your e-mail adress: ");
            string email = Console.ReadLine();

            string pattern = @"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+";

            Match match = Regex.Match(email, pattern);

            if (match.Success)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nValid email adress\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUnvalid email adress\n");
                //Skriv Invalid istället för Unvalid
            }

            Console.ResetColor();
        }

        private static void CheckForValidZipcode()
        {
            string zipCode = "444 44";
            string pattern = @"\d\d\d\s\d\d";

            Match match = Regex.Match(zipCode, pattern);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            else
                Console.WriteLine("Invalid zipcode");
        }
    }
}
