using System;
using System.Collections.Generic;

namespace CreditCardInterest
{
    public class Person
    {
        private double interest = 0;
        private List<object> wallets;


        public Person(List<object> wal)
        {
            SetWallet(wal);
            CalcInterest();
        }

        public void CalcInterest()
        {
            foreach (object c in wallets)
            {
                interest += Convert.ToDouble(c.ToString());             

            }
        }
        public void SetWallet(List<object> wal)
        {
            this.wallets = wal;
        }
        public double GetInterest()
        {
            return interest;
        }

    }
}
