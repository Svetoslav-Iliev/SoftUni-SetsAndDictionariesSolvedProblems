namespace _06_ProblemSix_MinersTask
{
    using System;
    using System.Collections.Generic;
    
    class MinersTask
    {
        static void Main()
        {
            // You are given a sequence of strings, each on a new line. 
            // Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) , 
            // and every even – quantity. Your task is to collect the resources and print them each on a new line, 
            // unitll you receive “stop” command.
            // Print the resources and their quantities in format:
            // { resource} –> { quantity}
            // The quantities inputs will be in the range[1 … 2 000 000 000]

            string resource = Console.ReadLine();
            
            long quantity;

            Dictionary<string, long> supplyDepot = new Dictionary<string, long>();

            while (resource != "stop")
            {
                quantity = long.Parse(Console.ReadLine());

                if (!supplyDepot.ContainsKey(resource))
                {
                    supplyDepot.Add(resource, quantity);
                }
                else
                {
                    supplyDepot[resource] += quantity;
                }
                resource = Console.ReadLine();

            }

            foreach (var kvp in supplyDepot)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
