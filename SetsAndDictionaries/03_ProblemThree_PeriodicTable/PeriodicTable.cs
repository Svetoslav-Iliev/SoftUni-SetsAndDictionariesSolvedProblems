namespace _03_ProblemThree_PeriodicTable
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.ConstrainedExecution;

    class PeriodicTable
    {
        static void Main()
        {
            // You are given an n number of chemical compounds. 
            // You need to keep track of all chemical elements used in the compounds 
            // and at the end print all unique ones in ascending order.
            // Input:
            // 4
            // Ce O
            // Mo O Ce
            // Ee
            // Mo
            // Output: Ce Ee Mo O

            int numberOfElements = int.Parse(Console.ReadLine());
            HashSet<string> mySet = new HashSet<string>();
            for (int i = 0; i < numberOfElements; i++)
            {
                string[] elements = Console.ReadLine()
                    .Trim()
                    .Split()
                    .ToArray();
                for (int j = 0; j < elements.Length; j++)
                {
                    mySet.Add(elements[j]);
                }
            }

            mySet.OrderBy(s => s);

            foreach (var element in mySet)
            {
                Console.Write("{0} ",element);
            }
        }
    }
}
