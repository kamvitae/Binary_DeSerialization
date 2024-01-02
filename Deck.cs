using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HF_9_4_Binary_De_Serialization
{
    [Serializable]
    internal class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }
        public int Count { get { return cards.Count; } }
        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        internal void Shuffle()
        {
            List<Card> result =
                cards.Select(x => new { value = x, order = random.Next() })
                        .OrderBy(x => x.order).Select(x => x.value).ToList();
            cards = result;
            /*
             bez LINQ:

            List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int cardToMove = random.Next(cards.Count);
                NewCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = NewCards;
             */
        }

        internal IEnumerable<string> GetCardNames()
        {
            //ta metoda zwraca tablicę łańsuchów znaków zawierającą nazwę każdej karty
            List<string> cardNamesList = new List<string>();
            foreach (Card card in cards)
            {
                cardNamesList.Add(card.Name);
            };
            IEnumerable<string> listOfCardNames = cardNamesList;
            return listOfCardNames;
        }
        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit_thenByValue());
        }

        public Deck(string FileName) // konstruktor odczytywania talii Deck obiektów Card z pliku bez serializacji
        {
            cards = new List<Card>();
            StreamReader reader = new StreamReader(FileName);
            while (!reader.EndOfStream)
            {
                bool invalidCard = false;
                string nextCard = reader.ReadLine();
                string[] cardParts = nextCard.Split(new char[] { ' ' });

                Values value = Values.Ace;
                switch (cardParts[0])
                {
                    case "Ace": value = Values.Ace; break;
                    case "Two": value = Values.Two; break;
                    case "Three": value = Values.Three; break;
                    case "Four": value = Values.Four; break;
                    case "Five": value = Values.Five; break;
                    case "Six": value = Values.Six; break;
                    case "Seven": value = Values.Seven; break;
                    case "Eight": value = Values.Eight; break;
                    case "Nine": value = Values.Nine; break;
                    case "Ten": value = Values.Ten; break;
                    case "King": value = Values.King; break;
                    case "Queen": value = Values.Queen; break;
                    case "Jack": value = Values.Jack; break;
                    default:
                        invalidCard = true;
                        break;
                }
                Suits suit = Suits.Clubs;
                switch (cardParts[2])
                {
                    case "Spades": suit = Suits.Spades; break;
                    case "Clubs": suit = Suits.Clubs; break;
                    case "Hearts": suit = Suits.Hearts; break;
                    case "Diamonds": suit = Suits.Diamonds; break;
                    default:
                        invalidCard = true;
                        break;
                }
                if (!invalidCard)
                    cards.Add(new Card(suit, value));
            }
        }
    }
}