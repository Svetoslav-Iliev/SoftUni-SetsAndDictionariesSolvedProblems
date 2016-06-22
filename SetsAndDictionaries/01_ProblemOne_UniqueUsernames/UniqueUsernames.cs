namespace _01_ProblemOne_UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    class UniqueUsernames
    {
        static void Main()
        {
            // Write a simple program that reads from the console a sequence of usernames
            // and keeps a collection with only the unique ones. Print the collection on the console.

            int numberOfCommands = int.Parse(Console.ReadLine());
            HashSet<string> mySet = new HashSet<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                mySet.Add(input);
            }

            foreach (var element in mySet)
            {
                Console.WriteLine(element);
            }
        }
    }
}
