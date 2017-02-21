
namespace CreditCardInterest
{
    public class Visa : ICreditCards
    {
        private double interestRate = 0.10;
        private double totalInterest;
        private double totalBalance;
        public Visa(double balance)
        {
            CalcBalance(balance);
            CalcInterest();
        }

        public void CalcBalance(double bal)
        {
            totalBalance = bal;
        }

        public void CalcInterest()
        {
            totalInterest = totalBalance * interestRate;
        }
        public double GetInterest()
        {
            return totalInterest;
        }
        public double GetInterestRate()
        {
            return interestRate;
        }
    }
}
