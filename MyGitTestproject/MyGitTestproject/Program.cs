using System;
using System.Text.RegularExpressions;

namespace MyGitTestproject
{
    class Program
    {
        static void Main(string[] args)
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
