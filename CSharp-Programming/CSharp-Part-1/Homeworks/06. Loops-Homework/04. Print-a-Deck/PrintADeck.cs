namespace _04.Print_a_Deck
{
    using System;
    using System.Collections.Generic;

    class PrintADeck
    {
        static void Main(string[] args)
        {

            string card = Console.ReadLine();

            List<string> cardArray = new List<string>();

            switch (card)
            {
                case "A":
                    string A = "A of spades, A of clubs, A of hearts, A of diamonds";
                    cardArray.Add(A);
                    goto case "K";
                case "K":
                    string K = "K of spades, K of clubs, K of hearts, K of diamonds";
                    cardArray.Add(K);
                    goto case "Q";
                case "Q":
                    string Q = "Q of spades, Q of clubs, Q of hearts, Q of diamonds";
                    cardArray.Add(Q);
                    goto case "J";
                case "J":
                    string J = "J of spades, J of clubs, J of hearts, J of diamonds";
                    cardArray.Add(J);
                    goto case "10";
                case "10":
                    string card10 = "10 of spades, 10 of clubs, 10 of hearts, 10 of diamonds";
                    cardArray.Add(card10);
                    goto case "9";
                case "9":
                    string card9 = "9 of spades, 9 of clubs, 9 of hearts, 9 of diamonds";
                    cardArray.Add(card9);
                    goto case "8";
                case "8":
                    string card8 = "8 of spades, 8 of clubs, 8 of hearts, 8 of diamonds";
                    cardArray.Add(card8);
                    goto case "7";
                case "7":
                    string card7 = "7 of spades, 7 of clubs, 7 of hearts, 7 of diamonds";
                    cardArray.Add(card7);
                    goto case "6";
                case "6":
                    string card6 = "6 of spades, 6 of clubs, 6 of hearts, 6 of diamonds";
                    cardArray.Add(card6);
                    goto case "5";
                case "5":
                    string card5 = "5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds";
                    cardArray.Add(card5);
                    goto case "4";
                case "4":
                    string card4 = "4 of spades, 4 of clubs, 4 of hearts, 4 of diamonds";
                    cardArray.Add(card4);
                    goto case "3";
                case "3":
                    string card3 = "3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds";
                    cardArray.Add(card3);
                    goto case "2";
                case "2":
                    string card2 = "2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds";
                    cardArray.Add(card2);
                    break;
            }

            cardArray.Reverse();

            foreach (string i in cardArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
