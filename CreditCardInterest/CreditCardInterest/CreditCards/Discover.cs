
namespace CreditCardInterest
{
    public class Discover : ICreditCards
    {
        private double interestRate = 0.01;
        private double totalInterest;
        private double totalBalance;
        public Discover(double balance)
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
