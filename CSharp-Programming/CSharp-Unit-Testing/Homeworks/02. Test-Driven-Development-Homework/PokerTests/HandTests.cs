namespace PokerTests
{
    using NUnit.Framework;
    using Poker;
    using System.Collections.Generic;

    [TestFixture]
    public class HandTests
    {
        [Test]
        public void HandToString_ShouldReturnCorrectString()
        {
            // Arrange
            var listOfCards = new List<ICard>()
            {
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Two,CardSuit.Spades),
                new Card(CardFace.Queen,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Diamonds)
            };

            // Act
            var testHand = new Hand(listOfCards);

            // Assert
            Assert.AreEqual(string.Join(" ", listOfCards), testHand.ToString());
        }
    }
}
