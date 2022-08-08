
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
        /**
         * 
         * Aqui vou usar a palavra "virtual" para
         * avisar o CSharp que vou querer alterar
         * o method WithDraw() nas subClasses. Então
         * vou utilizar a palavra "virtual"
         * 
         **/
        public virtual void WithDraw(double amount)
        {
            //add uma taxa pelo saque na conta commum
            Balance -= amount + 5.0;

        }
        public void Deposit(double amount)
        {

            Balance += amount;

        }
    }
}
