namespace PokerTests.PokerHandsCheckerTests
{
    using NUnit.Framework;
    using Poker;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class IsFlushTests
    {

        [Test]
        public void IsFlush_IfAddedHandIsNull_ShouldReturnArgumentNullException()
        {
            // Arrange
            var testPokerHandChecker = new PokerHandsChecker();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => testPokerHandChecker.IsFlush(null));
        }

        [Test]
        public void IsFlush_HandHasFiveCardsOfTheSameSuit_ShouldReturnTrue()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts)
            };
            var testHand = new Hand(testListOfCards);
            var testPokerHandChecker = new PokerHandsChecker();

            // Act
            var result = testPokerHandChecker.IsFlush(testHand);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsFlush_HandHasAtLeastOneCardOfADifferentSuitComparedToTheRest_ShouldReturnFalse()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Queen,CardSuit.Hearts),
                new Card(CardFace.Jack,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Diamonds)
            };
            var testHand = new Hand(testListOfCards);
            var testPokerHandChecker = new PokerHandsChecker();

            // Act
            var result = testPokerHandChecker.IsFlush(testHand);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsFlush_HandHasFiveSequantialCardsOfTheSameSuit_ShouldReturnFalse()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Two,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Four,CardSuit.Hearts),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Hearts)
            };
            var testHand = new Hand(testListOfCards);
            var testPokerHandChecker = new PokerHandsChecker();

            // Act
            var result = testPokerHandChecker.IsFlush(testHand);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
