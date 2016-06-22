namespace _05_ProblemFive_PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PhoneBook
    {
        static void Main()
        {
            // Write a program that receives some info from the console about people and their phone numbers.
            // You are free to choose the manner in which the data is entered; 
            // each entry should have just one name and one number (both of them strings).
            // If you receive a name that already exists in the phonebook, simply update its number.
            // After filling this simple phonebook, upon receiving the command "search", 
            // and the command “stop”, your program should be able to perform a search of a contact by name 
            // and print her details in format "{name} -> {number}".In case the contact isn't found, 
            // print "Contact {name} does not exist." 

            string input = Console.ReadLine();

            string[] phonebookData;
            string name;
            string number;


            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input != "search")
            {
                phonebookData = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                name = phonebookData[0];
                number = phonebookData[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, number);
                }
                else
                {
                    phonebook[name] = number;
                }
                input = Console.ReadLine();
            }

            string contactNameToSearch = Console.ReadLine();

            while (!String.IsNullOrEmpty(contactNameToSearch)&&contactNameToSearch!="stop")
            {
                if (phonebook.ContainsKey(contactNameToSearch))
                {
                    Console.WriteLine("{0} -> {1}", contactNameToSearch, String.Join(", ", phonebook[contactNameToSearch]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", contactNameToSearch);
                }

                contactNameToSearch = Console.ReadLine();
            }
        }
    }
}
