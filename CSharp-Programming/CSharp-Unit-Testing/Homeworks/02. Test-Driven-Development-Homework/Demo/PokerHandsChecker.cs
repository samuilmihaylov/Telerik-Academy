using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private int ValidHandCount = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException();
            }

            if (hand.Cards.Count != ValidHandCount)
            {
                return false;
            }

            for (int i = 0; i < ValidHandCount - 1; i++)
            {
                for (int j = i + 1; j < ValidHandCount; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face &&
                        hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException();
            }

            if (this.CheckIfHandHasFiveCardsOfTheSameSuit(hand) &&
                this.CheckIfHandHasFiveSequantialFaceValues(hand))
            {
                return true;
            }

            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException();
            }

            var groupsOfCardsWithTheSameFaceValue =
                this.SplitTheHandIntoGroupsOfCardsWithTheSameFaceValue(hand);

            var result = groupsOfCardsWithTheSameFaceValue
                .Any(groupCount => groupCount == 4);

            return result;
        }

        public bool IsFlush(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException();
            }

            if (this.CheckIfHandHasFiveCardsOfTheSameSuit(hand) &&
                !this.CheckIfHandHasFiveSequantialFaceValues(hand))
            {
                return true;
            }

            return false;
        }

        public bool IsStraight(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException();
            }

            var isStraight = this.CheckIfHandHasFiveSequantialFaceValues(hand);
            return isStraight;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<int> SplitTheHandIntoGroupsOfCardsWithTheSameFaceValue(IHand hand)
        {
            var groupsOfCardsWithTheSameFaceValue =
                from card in hand.Cards
                group card by card.Face into groups
                orderby groups.Count() descending
                select groups.Count();

            return groupsOfCardsWithTheSameFaceValue;
        }

        private bool CheckIfHandHasFiveSequantialFaceValues(IHand hand)
        {
            var cardValues = hand.Cards
                .Select(card => card.Face)
                .OrderBy(value => value)
                .ToList();

            var firstCard = cardValues[0];

            for (int i = 1; i < cardValues.Count; i++)
            {
                if (firstCard + 1 != cardValues[i])
                {
                    return false;
                }
                firstCard = cardValues[i];
            }

            return true;
        }

        private bool CheckIfHandHasFiveCardsOfTheSameSuit(IHand hand)
        {
            var firstCard = hand.Cards[0];

            foreach (var card in hand.Cards)
            {
                if (card.Suit != firstCard.Suit)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
