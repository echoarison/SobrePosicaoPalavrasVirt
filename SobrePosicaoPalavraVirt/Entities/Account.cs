
namespace SobrePosicaoPalavraVirt.Entities
{
    internal class Account
    {
        /**
         * 
         * O atributo protected ela só da permissao para Classe Mãe
         * e a subClasse que pertence a ela poder alterar o valores
         * do atributo
         * 
         **/
        //atributo autoProprietes
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        //Construtor
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Methods
        public void WithDraw(double amount)
        {

            Balance -= amount;

        }
        public void Deposit(double amount)
        {

            Balance += amount;

        }
    }
}
