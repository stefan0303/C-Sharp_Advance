using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> playerAndHisCards = new Dictionary<string, List<string>>();

        // foreach line, read the player and his cards and add or update the playerAndHisCards
        while (true)
        {
            // whole line
            var input = Console.ReadLine();

            if (input == "JOKER") { break; }

            // split name and cards
            string[] inputAsArray = input.Split(':');

            string playerName = inputAsArray[0];

            // split the array of cards on comma
            string[] newHandCards = inputAsArray[1].Split(',');

            // for each card in the new hand, assign to self with remove the spaces
            for (int i = 0; i < newHandCards.Length; i++)
            {
                newHandCards[i] = newHandCards[i].Trim();
            }

            // if the player is not in the dictionary yet, add him
            if (!playerAndHisCards.ContainsKey(playerName))
            {
                playerAndHisCards.Add(playerName, new List<string>());
            }

            // foreach card in the new hand, check if the player has the card and if not- add
            foreach (string card in newHandCards)
            {
                if (!playerAndHisCards[playerName].Contains(card))
                {
                    playerAndHisCards[playerName].Add(card);
                }
            }

        }

        // foreach player display the sum of his cards
        foreach (var playerWithCards in playerAndHisCards)
        {
            int sumOfCardsForPlayer = 0;


            // foreach card of the player, add to the whole sum
            foreach (var card in playerWithCards.Value)
            {

                // get the cards value. Substring is from the beginning for the lenght of the string miuns 1, because the last character is the type
                var cardValue = card.Substring(0, card.Length - 1);

                // get the type. Substring starting at the length of the sting minus 1 (predpolsedneishun) until the end: so the last character
                var cardType = card.Substring(card.Length - 1, 1);

                // get the card type and assign it to number with which we can multiply
                int cardTypeAsNumber = 0;
                switch (cardType)
                {
                    case "S":
                        cardTypeAsNumber = 4;
                        break;
                    case "H":
                        cardTypeAsNumber = 3;
                        break;
                    case "D":
                        cardTypeAsNumber = 2;
                        break;
                    case "C":
                        cardTypeAsNumber = 1;
                        break;
                }

                // get the card as a number, mulitply it by it's type as number and add to the whole sum of cards for the player
                switch (cardValue)
                {
                    case "J":
                        sumOfCardsForPlayer += 11 * cardTypeAsNumber;
                        break;
                    case "Q":
                        sumOfCardsForPlayer += 12 * cardTypeAsNumber;
                        break;
                    case "K":
                        sumOfCardsForPlayer += 13 * cardTypeAsNumber;
                        break;
                    case "A":
                        sumOfCardsForPlayer += 14 * cardTypeAsNumber;
                        break;
                    default: // cards 2-10 are not in J, Q, K, A, so all of them will land in default: (mnogo ligava rabota ne izpolzvai taka)
                        sumOfCardsForPlayer += (Convert.ToInt32(cardValue) * cardTypeAsNumber);
                        break;
                }
            }
            Console.WriteLine("{0}: {1}", playerWithCards.Key, sumOfCardsForPlayer);
        }
        Console.ReadLine();
    }
}

