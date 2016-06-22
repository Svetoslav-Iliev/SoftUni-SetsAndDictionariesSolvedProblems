namespace _08_ProblemEight_HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HandsOfCards
    {
        static void Main()
        {
            // You are given a sequence of people and for every person what cards he draws from the deck.The input will be separate lines in the format:
            // { personName}: { PT, PT, PT,… PT}
            // Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type.The input ends when a "JOKER" is drawn.The name can contain any ASCII symbol except ':'.The input will always be valid and in the format described, there is no need to check it.
            // A single person cannot have more than one card with the same power and type, if he draws such a card he discards it.The people are playing with multiple decks.Each card has a value that is calculated by the power multiplied by the type.Powers 2 to 10 have the same value and J to A are 11 to 14.Types are mapped to multipliers the following way(S-> 4, H-> 3, D-> 2, C-> 1).
            // Finally print out the total value each player has in his hand in the format:
            // { personName}: { value}
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<int, HashSet<int>>> houseOfCards = new Dictionary<string, Dictionary<int, HashSet<int>>>(); 
            while (input!="JOKER")
            {
                string[] inputArgs = input.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                if (!houseOfCards.ContainsKey(name))
                {
                    houseOfCards.Add(name, new Dictionary<int, HashSet<int>>());
                    for (int i = 0; i < 4; i++)
                    {
                        houseOfCards[name].Add(i, new HashSet<int>());
                    }
                }

                for (int i = 1; i < inputArgs.Length; i++)
                {
                    string currentCard = inputArgs[i].Trim();

                    int face = 0;
                    int suite = 0;

                    if (currentCard.Length > 2)
                    {
                        face = GetFace(currentCard.Substring(0, 2));
                        suite = GetSuite(currentCard.Substring(2));
                    }
                    else
                    {
                        face = GetFace(currentCard[0].ToString());
                        suite = GetSuite(currentCard[1].ToString());
                    }

                    if (!houseOfCards[name][suite].Contains(face))
                    {
                        houseOfCards[name][suite].Add(face);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var outerPair in houseOfCards)
            {
                int sum = 0;
                foreach (var innerPair in outerPair.Value)
                {
                    sum += innerPair.Key * innerPair.Value.Sum();
                }
                Console.WriteLine("{0}: {1}", outerPair.Key, sum);
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 0;
            }
        }

        private static int GetFace(string face)
        {
            switch (face)
            {
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(face);
            }
        }
    }
}
