using System;
using System.Collections.Generic;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oddElements = new List<int> { 1, 2, 3, 4, 5 };
            List<int> odderElements = new List<int> { };

            foreach (int odds in oddElements)
            {
                OddFilter(odds);
            }
            PrintList(odderElements);
            Console.ReadLine();
            }

        private static int OddFilter(int oddElements)
        {
            for (int i = 0; i < oddElements; i++)
            {
                if (i % 2 != 0)
                {
                    odderElements += (i);
                }
                    
            }

            return odderElements;
        }

        private static void PrintList(List<int> list)
        {
            foreach (int element in list)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}