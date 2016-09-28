namespace PokerTests.PokerHandsCheckerTests
{
    using NUnit.Framework;
    using Poker;
    using System.Collections.Generic;

    [TestFixture]
    public class IsFourOfAKindTests
    {
        [Test]
        public void IsFourOfAKind_HandHasThreeCardsOfTheSameFaceValue_ShouldReturnFalse()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Hearts),
                new Card(CardFace.Three,CardSuit.Spades)
            };
            var testHand = new Hand(testListOfCards);
            var testPokerHandChecker = new PokerHandsChecker();

            // Act
            var result = testPokerHandChecker.IsFourOfAKind(testHand);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsFourOfAKind_HandHasFourCardsOfTheSameFaceValue_ShouldReturnTrue()
        {
            // Arrange
            var testListOfCards = new List<ICard>()
            {
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Spades)
            };
            var testHand = new Hand(testListOfCards);
            var testPokerHandChecker = new PokerHandsChecker();

            // Act
            var result = testPokerHandChecker.IsFourOfAKind(testHand);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
