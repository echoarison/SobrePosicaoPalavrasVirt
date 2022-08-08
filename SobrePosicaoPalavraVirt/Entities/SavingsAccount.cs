
namespace SobrePosicaoPalavraVirt.Entities
{
    internal class SavingsAccount : Account
    {
        //atributos
        public double InterestRate { get; set; }

        //construtor
        public SavingsAccount()
        {
        }

        //usando o base() para reaproveitar o construtor da class mãe
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {

            InterestRate = interestRate;

        }

        //method
        public void UpdateBalance()
        {

            Balance += Balance * InterestRate;

        }

    }
}
