namespace DeckTests
{
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void DeckTrumpCard_ShouldNotBeNull()
        {
            var deck = new Deck();

            Assert.IsNotNull(deck.TrumpCard);
        }

        [Test]
        [TestCase(5)]
        [TestCase(8)]
        [TestCase(20)]
        public void DeckGetNextCard_ShouldNotReturnNull(int numberOfTests)
        {
            var deck = new Deck();
            for (int i = 0; i < numberOfTests; i++)
            {
                Assert.IsNotNull(deck.GetNextCard());
            }
        }

        [Test]
        public void Deck_shouldHave24Cards()
        {
            var deck = new Deck();

            Assert.AreEqual(24, deck.CardsLeft);
        }

        [Test]
        [TestCase(5)]
        [TestCase(8)]
        [TestCase(20)]
        public void DeckCardsLeft_shouldDecreaseCount_WhenGetNextCard(int timesCall)
        {
            var deck = new Deck();

            for (int i = 0; i < timesCall; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(24 - timesCall, deck.CardsLeft);
        }

        [Test]
        public void Deck_ShouldThrowAnException_WhenCardsOver()
        {
            var deck = new Deck();

            for (int i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }
    }
}
