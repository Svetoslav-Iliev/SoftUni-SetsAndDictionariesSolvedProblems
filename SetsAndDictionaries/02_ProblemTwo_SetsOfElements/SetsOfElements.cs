namespace _02_ProblemTwo_SetsOfElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class SetsOfElements
    {
        static void Main()
        {
            // On the first line you are given the length of two sets n and m. 
            // On the next n + m lines there are n numbers that are in the first set and m numbers 
            // that are in the second one. Find all non-repeating element that appears in both of them,
            // and print them at the console:
            // Set with length n = 4: { 1, 3, 5, 7}
            // Set with length m = 3: { 3, 4, 5}
            // Set that contains all repeating elements -> { 3, 5}

            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int firstSetLenght = int.Parse(input[0]);
            int secondSetLenght = int.Parse(input[1]);

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLenght + secondSetLenght; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (i < firstSetLenght)
                {
                    firstSet.Add(inputNumber);
                }
                else
                {
                    secondSet.Add(inputNumber);
                }
            }
            
            HashSet<int> resultSet = new HashSet<int>();

            foreach (var element in firstSet)
            {
                if (secondSet.Contains(element))
                {
                    resultSet.Add(element);
                }
            }

            foreach (var element in resultSet)
            {
                Console.WriteLine("{0} ",element);
            }
        }
    }
}

