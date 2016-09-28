namespace PokerTests
{
    using NUnit.Framework;
    using Poker;

    [TestFixture]
    public class CardTests
    {
        [Test]
        [TestCase(14, 3, ExpectedResult = "A♥")]
        [TestCase(7, 2, ExpectedResult = "7♦")]
        [TestCase(11, 1, ExpectedResult = "J♣")]
        [TestCase(13, 4, ExpectedResult = "K♠")]
        public string CardToString_ShouldReturnCorrectCardString(int cardFace, int cardSuit)
        {
            // Arrange
            var testCard = new Card((CardFace)cardFace, (CardSuit)cardSuit);

            // Act
            var testCardToString = testCard.ToString();

            // Assert
            return testCardToString;
        }
    }
}
