using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoAndre = new ContaCorrente
            {
                titular = "André Silva",
                conta = "1010-x",
                numero_Agencia = 15,
                saldo = 100
            };
            Console.WriteLine("O saldo da conta do > "+contaDoAndre.titular + " é >" + contaDoAndre.saldo);
            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
