
namespace SobrePosicaoPalavraVirt.Entities
{
    /**
        * 
        * Para Fazer herança em C# vc utiliza os ":"
        * e depois a class que vc quer que ela receba
        * os atributos. Significa que a BusinessAccount
        * vai possuir tudo ou herdar tudo da Class
        * Account
        * 
        **/
    internal class BusinessAccount : Account
    {
        //atributo autoProprietes
        public double LoanLimit { get; set; }

        //Construtor
        public BusinessAccount()
        {
        }

        /**
         * 
         * Aqui estou usando um construtor do Account() para implementar o
         * Construtor do BusinessAccount(), assim não fica poluido o codigo com
         * repetições. Usando o base() ele vai acessar o construtor da Classe "Mãe"
         * e vai reutilizar o Construtor dela para o Construtor do BusinessAccount()
         * 
         **/
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        //methods
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
