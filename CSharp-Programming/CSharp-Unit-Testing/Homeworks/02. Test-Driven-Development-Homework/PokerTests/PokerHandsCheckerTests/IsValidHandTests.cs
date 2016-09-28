namespace PokerTests
{
    using NUnit.Framework;
    using Poker;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class IsValidHandTests
    {
        [Test]
        public void IsValidHand_IfAddedHandIsNull_ShouldReturnArgumentNullException()
        {
            // Arrange
            var testPokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => testPokerHandChecker.IsValidHand(null));      
        }

        [Test]
        public void IsValidHand_HandHasLessThanFiveCards_ShouldReturnFalse()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds)
            };
            var testHand = new Hand(testListOfCards);
            var testPokerHandChecker = new PokerHandsChecker();

            // Act
            var result = testPokerHandChecker.IsValidHand(testHand);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidHand_HandHasMoreThanFiveCards_ShouldReturnFalse()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Eight,CardSuit.Hearts)
            };
            var testHand = new Hand(testListOfCards);
            var testPokerHandChecker = new PokerHandsChecker();

            // Act
            var result = testPokerHandChecker.IsValidHand(testHand);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidHand_HandHasDuplicateCards_ShouldReturnFalse()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Eight,CardSuit.Hearts)
            };
            var hand = new Hand(testListOfCards);
            var pokerHandChecker = new PokerHandsChecker();

            // Act
            var result = pokerHandChecker.IsValidHand(hand);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidHand_HandHasFiveDifferentCars_ShouldReturnTrue()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Spades),
            };
            var testHand = new Hand(testListOfCards);
            var testPokerHandChecker = new PokerHandsChecker();

            // Act
            var result = testPokerHandChecker.IsValidHand(testHand);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
