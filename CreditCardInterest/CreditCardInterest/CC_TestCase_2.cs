using System.Collections.Generic;
using NUnit.Framework;

namespace CreditCardInterest
{
    public class CC_TestCase_2
    {  

        private List<object> totalCardsInWallets = new List<object>();
        private List<object> cardsWallet1 = new List<object>();
        private List<object> cardsWallet2 = new List<object>();
        private Person person;
        private Wallet wallet;

        [Test]
        public void TC2_TotalInterest()
        {
            
            totalCardsInWallets.Add(new Visa(100).GetInterest());
            totalCardsInWallets.Add(new MasterCard(100).GetInterest());
            totalCardsInWallets.Add(new Discover(100).GetInterest());
            person = new Person(totalCardsInWallets);

            Assert.AreEqual(16.00, person.GetInterest());
        }

        [Test]
        public void TC2_InterestWallet1()
        {
                        
            cardsWallet1.Add(new Visa(100).GetInterest());
            cardsWallet1.Add(new Discover(100).GetInterest());
            wallet = new Wallet(cardsWallet1);
            Assert.AreEqual(11.00, wallet.GetInterest());
        }

        [Test]
        public void TC2_InterestWallet2()
        {

            cardsWallet2.Add(new MasterCard(100).GetInterest());
            wallet = new Wallet(cardsWallet2);
            Assert.AreEqual(5.00, wallet.GetInterest());
        }


    }
}
