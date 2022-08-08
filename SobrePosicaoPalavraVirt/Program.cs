using System;
using SobrePosicaoPalavraVirt.Entities;
namespace SobrePosicaoPalavraVirt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001,"Alex", 500.0);
            //Fazendo um Upcasting aqui em baixo
            Account acc2 = new SavingsAccount(1002,"Anna", 500.0, 0.01);

            //fazendo um saque
            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            //exibindo o saldo de cada um
            Console.WriteLine("Saldo da conta 1: " + acc1.Balance);
            Console.WriteLine("Saldo da conta 2: " + acc2.Balance);
        }
    }
}
