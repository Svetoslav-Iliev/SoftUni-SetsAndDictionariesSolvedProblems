namespace _11_ProblemEleven_LoggAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LoggAggregator
    {
        static void Main()
        {
            // You are given a sequence of access logs in format <IP> <user> <duration>. For example:
            // 192.168.0.11 peter 33
            // 10.10.17.33 alex 12
            // 10.10.17.35 peter 30
            // 10.10.17.34 peter 120
            // 10.10.17.34 peter 120
            // 212.50.118.81 alex 46
            // 212.50.118.81 alex 4
            //Write a program to aggregate the logs data and print for each user the total duration of his sessions and a list of unique IP addresses in format "<user>: <duration> [<IP1>, <IP2>, …]". Order the users alphabetically. Order the IPs alphabetically. In our example, the output should be the following:
            // alex: 62[10.10.17.33, 212.50.118.81]
            // peter: 303[10.10.17.34, 10.10.17.35, 192.168.0.11]

            int logLinesCount = int.Parse(Console.ReadLine());
            string[] loginfo;

            string userName, ipAdress;
            int logTime;
            SortedDictionary<string, SortedSet<string>> ipDataBase = new SortedDictionary<string, SortedSet<string>>();
            SortedDictionary<string, int> logTimeDataBase = new SortedDictionary<string, int>();
            
            for (int i = 0; i < logLinesCount; i++)
            {
                loginfo = Console.ReadLine().Split().ToArray();
                userName = loginfo[1];
                ipAdress = loginfo[0];
                logTime = int.Parse(loginfo[2]);

                if (ipDataBase.ContainsKey(userName) && logTimeDataBase.ContainsKey(userName))
                {
                    ipDataBase[userName].Add(ipAdress);
                    logTimeDataBase[userName] += logTime;
                }
                else
                {
                    ipDataBase.Add(userName, new SortedSet<string>());
                    ipDataBase[userName].Add(ipAdress);

                    logTimeDataBase.Add(userName,logTime);
                }
            }

           
            foreach (var kvp in logTimeDataBase)
            {
                Console.Write($"{kvp.Key}: {kvp.Value} ");
                foreach (var value in ipDataBase.Values)
                {
                    foreach (var ipAddress in value)
                    {
                        Console.Write(ipAddress);
                    }
                }
            }
            
            

        }
    }
}
