
namespace CreditCardInterest
{
    public class MasterCard : ICreditCards
    {
        private double interestRate = 0.05;
        private double totalInterest;
        private double totalBalance;
        public MasterCard(double balance)
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
