/*
You are given a sequence of people and for every person the cards he draws from the deck. 
The input will be separate lines in the format:
{personName}: {PT, PT, PT,… PT}
Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type. 
The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol except ':'. 
The input will always be valid and in the format described, there is no need to check it.
A single person cannot have more than one card with the same power and type, if he draws such a card he discards it. 
The people are playing with multiple decks. Each card has a value that is calculated by the power multiplied by the type. 
Powers 2 to 10 have the same value and J to A are 11 to 14. Types are mapped to multipliers in the following way 
(S -> 4, H-> 3, D -> 2, C -> 1).
Finally print out the total value each player has in his hand in the format: “{personName}: {value}”
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();
            bool canContinue = true;
            while (canContinue)
            {
                string input = Console.ReadLine();
                if (input == "JOKER")
                {
                    canContinue = false;
                    break;
                }
                string[] inputSplit = input.Split(new char[] { ':' });
                string name = inputSplit[0];
                List<string> cardsList = inputSplit[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                List<string> existingList = new List<string>();
                if (cards.TryGetValue(name, out existingList))
                {
                    for (int i = 0; i < cardsList.Count; i++)
                    {
                        if (!existingList.Contains(cardsList[i]))
                        {
                            existingList.Add(cardsList[i]);
                        }
                    }
                }
                else
                {
                    cards.Add(name, cardsList);
                }
            }
            foreach (var item in cards)
            {
                int points = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    string currentCard = item.Value[i];
                    int multiplier = 1;
                    if (currentCard.EndsWith("S"))
                    {
                        multiplier = 4;
                    }
                    else if (currentCard.EndsWith("H"))
                    {
                        multiplier = 3;
                    }
                    else if (currentCard.EndsWith("D"))
                    {
                        multiplier = 2;
                    }
                    else
                    {
                        multiplier = 1;
                    }
                    string currentCardValue = currentCard.TrimEnd(currentCard[currentCard.Length - 1]).Trim();

                    int cardValue = 0;
                    try
                    {
                        cardValue = int.Parse(currentCardValue);
                    }
                    catch (Exception)
                    {
                        switch (currentCardValue)
                        {
                            case "J":
                                cardValue = 11;
                                break;
                            case "Q":
                                cardValue = 12;
                                break;
                            case "K":
                                cardValue = 13;
                                break;
                            case "A":
                                cardValue = 14;
                                break;
                            default:
                                break;
                        }
                    }
                    points += cardValue * multiplier;
                }
                Console.WriteLine($"{item.Key}: {points}");
            }
        }
    }
}
