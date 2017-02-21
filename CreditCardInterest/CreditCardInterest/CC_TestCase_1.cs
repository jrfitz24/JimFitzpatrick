using System.Collections.Generic;
using NUnit.Framework;


namespace CreditCardInterest
{


    [TestFixture]
    public class CC_TestCase_1
    {
        private ICreditCards[] creditCards = { new Visa(100), new MasterCard(100), new Discover(100) };
        private List<object> wallets = new List<object>();
        private Person person;

        [Test]
        public void TC1_TotalInterest()
        {
            wallets.Add(new Visa(100).GetInterest());
            wallets.Add(new MasterCard(100).GetInterest());
            wallets.Add(new Discover(100).GetInterest());
            person = new Person(wallets);

            Assert.AreEqual(16.00, person.GetInterest());
        }

        [Test]
        public void TC1_TestVisaInterest()
        {
            Assert.AreEqual(10.00, creditCards[0].GetInterest());
        }

        [Test]
        public void TC1_TestMasterCardInterest()
        {
            Assert.AreEqual(5.00, creditCards[1].GetInterest());
        }

        [Test]
        public void TC1_TestDiscoverInterest()
        {
            Assert.AreEqual(1.00, creditCards[2].GetInterest());
        }
    }
}
