using System.Collections.Generic;
using NUnit.Framework;

namespace CreditCardInterest
{
    class CC_TestCase_3
    {

        private List<object> cardsPerson1 = new List<object>();
        private List<object> cardsPerson2 = new List<object>();
        private List<object> cardsWallet1 = new List<object>();
        private List<object> cardsWallet2 = new List<object>();
        private Person person;
        private Wallet wallet;

        [Test]
        public void TC3_TotalInterestPerson1()
        {
            cardsPerson1.Add(new Visa(100).GetInterest());
            cardsPerson1.Add(new MasterCard(100).GetInterest());
            cardsPerson1.Add(new Discover(100).GetInterest());
            person = new Person(cardsPerson1);
            Assert.AreEqual(16.00, person.GetInterest());
        }

        [Test]
        public void TC3_TotalInterestPerson2()
        {
            cardsPerson2.Add(new Visa(100).GetInterest());
            cardsPerson2.Add(new MasterCard(100).GetInterest());
            person = new Person(cardsPerson2);

            Assert.AreEqual(15.00, person.GetInterest());
        }

        [Test]
        public void TC3_InterestWalletPerson1()
        {
            cardsWallet1.Add(new Visa(100).GetInterest());
            cardsWallet1.Add(new MasterCard(100).GetInterest());
            cardsWallet1.Add(new Discover(100).GetInterest());
            wallet = new Wallet(cardsWallet1);
            Assert.AreEqual(16.00, wallet.GetInterest());
        }

        [Test]
        public void TC3_InterestWalletPerson2()
        {
            cardsWallet2.Add(new Visa(100).GetInterest());
            cardsWallet2.Add(new MasterCard(100).GetInterest());
            wallet = new Wallet(cardsWallet2);
            Assert.AreEqual(15.00, wallet.GetInterest());
        }
    }
}
