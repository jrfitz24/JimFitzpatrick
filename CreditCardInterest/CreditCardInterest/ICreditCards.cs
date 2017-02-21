
namespace CreditCardInterest
{
    public interface ICreditCards
    {
        double GetInterestRate();

        void CalcInterest();

        void CalcBalance(double Balance);

        double GetInterest();

    }
}
