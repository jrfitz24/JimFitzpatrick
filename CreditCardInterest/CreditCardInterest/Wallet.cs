using System;
using System.Collections.Generic;

namespace CreditCardInterest
{
    public class Wallet
    {
        private double interest = 0;
        private List<object> cards;

        public Wallet(List<object> cards)
        {
            GetCreditCards(cards);
            CalcInterest();
        }

        public void GetCreditCards(List<object> CC)
        {
            this.cards = CC;
        }

        public void CalcInterest()
        {
            foreach (object c in cards)
            {
                interest += Convert.ToDouble(c.ToString());
            }
        }

        public double GetInterest()
        {
            return interest;
        }

    }
}
