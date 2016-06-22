namespace _09_ProblemNine_UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class UserLogs
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> logsByUser = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] logInfo = input.Split();

                string[] ipInfo = logInfo[0].Split('=');
                string iP = ipInfo[1];

                string[] userInfo = logInfo[2].Split('=');
                string user = userInfo[1];

                // Make sure that the user is not in the logByUser DS
                if (!logsByUser.ContainsKey(user))
                {
                    logsByUser.Add(user, new Dictionary<string, int>());
                    logsByUser[user].Add(iP, 0); // Initialize IP with value 0, so i can increment the value later like this: logsByUser[user][iP]++
                }
                else if (!logsByUser[user].ContainsKey(iP)) // Possible IP missing, if user is in the logByUser DB
                {
                    logsByUser[user].Add(iP, 0); 
                }

                logsByUser[user][iP]++;

                input = Console.ReadLine();
            }

            foreach (var outerPair in logsByUser)
            {
                Console.WriteLine("{0}:", outerPair.Key);
                Console.WriteLine("{0}.", string.Join(", ",outerPair.Value.Select(x=>$"{x.Key} => {x.Value}")));
                
            }
        }
    }
}
