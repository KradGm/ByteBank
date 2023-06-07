using System;
using System.Runtime.Remoting;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CurrentAccount Novaconta = new CurrentAccount();
            //CurrentAccount contaDoAndre = new CurrentAccount
            //{
            //    holderName = "André Silva",
            //    account = "1010-x",
            //    agencyNumber = 15,
            //    balance = 100
            //};

            //[COMPARAÇÃO DE DADOS]
            //CurrentAccount contaDoAndre2 = new CurrentAccount
            //{
            //    holderName = "André Silva",
            //    account = "1010-x",
            //    agencyNumber = 15,
            //    balance = 100
            //};
            //[NÃO APONTAM PARA O MESMO ENDEREÇO(false)]
            //Console.WriteLine(contaDoAndre == contaDoAndre2);
            //contaDoAndre = contaDoAndre2; 
            //[APONTAM PARA O MESMO ENDEREÇO(true)]
            //Console.WriteLine(contaDoAndre == contaDoAndre2);

            ///*
            //[INPUT DE DADOS]
            //Console.WriteLine("Digite o seu nome:");
            //string holdername = Console.ReadLine();
            //Novaconta.holder = holdername;
            //Console.WriteLine(holdername);
            //*/

            //Console.WriteLine("O saldo da conta do(a) > "+contaDoAndre.holderName + " é >" + contaDoAndre.balance);

            //CurrentAccount contaDaMaria = new CurrentAccount { holderName = "Maria Souza", account = "1010-5", balance = 350, agencyNumber = 17 };

            //Console.WriteLine("O saldo da conta do(a) > " + contaDaMaria.holderName + " é >" + contaDaMaria.balance);

            //contaDoAndre.Transfer(50, contaDaMaria);
            //Console.WriteLine("O saldo da conta do(a) > " + contaDoAndre.holderName + " é >" + contaDoAndre.balance);
            //Console.WriteLine("O saldo da conta do(a) > " + contaDaMaria.holderName + " é >" + contaDaMaria.balance);


            ///*
            //[TESTE]
            //contaDoAndre.Deposit(100);

            //Console.WriteLine("O saldo da conta do > " + contaDoAndre.holder + " é >" + contaDoAndre.balance);

            //if (contaDoAndre.Withdraw(300) == true)
            //{
            //    Console.WriteLine("O saldo da conta do > " + contaDoAndre.holder + " é >" + contaDoAndre.balance);
            //}
            //else
            //{
            //    Console.WriteLine("Saldo insuficiente para o saque");
            //}
            //*/
            //CurrentAccount pedroAccount = new CurrentAccount();
            //Console.WriteLine(pedroAccount.holderName);
            //Console.WriteLine(pedroAccount.agencyNumber);
            //Console.WriteLine(pedroAccount.account);
            //Console.WriteLine(pedroAccount.balance);


            ////double valor = 300;
            ////double valor2 = valor;
            ////Console.WriteLine(valor == valor2);
            //contaDaMaria.Informations(contaDaMaria.holderName, contaDaMaria.agencyNumber, contaDaMaria.account, contaDaMaria.balance);


            Client client = new Client();
            client.name = "Enzo Oliveira";
            client.cpf = "145.014.396-29";
            client.profession = "Dev/Programmer";

            CurrentAccount account = new CurrentAccount
            {
                holder = client,
                account = "1010-X",
                agencyNumber = 17,
                balance = 102
            };
            Console.WriteLine("Nome do cliente: " + account.holder.name);
            Console.WriteLine("CPF do cliente: " + account.holder.cpf);
            Console.WriteLine("Profissão do cliente: " + account.holder.profession);
            Console.WriteLine("Conta do cliente: " + account.account);
            Console.WriteLine("Agencia do cliente: " + account.agencyNumber);
            Console.WriteLine("Saldo do cliente: " + account.balance);


            CurrentAccount account2 = new CurrentAccount
            {
                client.holder = client,
                account = "1015-X",
                agencyNumber = 16,
                balance =200
            }


            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
            
        }
    }
}
