namespace _07_ProblemSeven_FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // You are given a sequence of strings, each on a new line, 
            // unitll you receive “stop” command.First string is a name of a person. 
            // On the second line you receive his email. Your task is to collect their names and emails, 
            // and remove emails whose domain ends with "us" or "uk"(case insensitive).Print:
            // { name} – > { email}

            string name = Console.ReadLine();
            string email;
            Dictionary<string,string> emailList = new Dictionary<string, string>();
            while (name != "stop")
            {
                email = Console.ReadLine().Trim();
                
                if (!emailList.ContainsKey(name))
                {
                    if (!email.Contains(".us") && !email.Contains(".uk"))
                    {
                        emailList.Add(name, email);
                    }
                }

                else
                {
                    if (!email.Contains(".us") && !email.Contains(".uk"))
                    {
                        emailList[name] = email;
                    }
                }
                name = Console.ReadLine();
            }
            foreach (var kvp in emailList)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
