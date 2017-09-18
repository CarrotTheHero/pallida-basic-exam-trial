using System;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter           

            Console.WriteLine("Write in your email address (firstname.lastname@asd.com): ");
            string input = Console.ReadLine();            
            string[] words = input.Split('.' , '@');

            Console.Write(ToUpper(words[1]) + " " + ToUpper(words[0]));
            Console.ReadLine();
            
        }

        public static string ToUpper(string words)
        {
            return char.ToUpper(words[0]) + words.Substring(1);
        }

    }
}