using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static Dictionary<string, string> Dictionary;

        static void Main(string[] args)
        {
            Dictionary = new Dictionary<string, string>
            {
                { "alma", "apple" },
                { "fa", "tree" }
            };

            //add more words to your dictionary

        }

        // Implement this method. It should add the given key-value pair to the the dictionary
        public static void AddWord(string hungarianWord, string englishWord)
        {
            Dictionary.Add("korte", "pear");
        }

        // Implement this method. It should remove the key-value pair by the given key from the dictionary
        public static void RemoveWord(string hungarianWord)
        {
            Dictionary.Remove("fa");
        }

        // Implement a method which works as a translator from Hungarian to English
        // Example: you give it a parameter "alma" and it's output is "tree"
        public static string TranslateToEnglish(string hungarian)
        {
            Console.Write("Write in like alma, korte, fa: ");
            string input = Console.ReadLine();
            Console.WriteLine(Dictionary[input]);
        }

        // Implement a method which works as a translator from English to Hungarian
        // Example: you give it a parameter "apple" and it's output is "alma"
        public static string TranslateToHungarian(string english)
        {
            Console.Write("Write in like apple, pear, tree: ");
            string input = Console.ReadLine();
            Console.WriteLine(Dictionary[input]);
        }
    }
}