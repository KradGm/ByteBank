using System;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace ByteBank
{
    class Program
    {
        private static string nomeClient;
        private static string cpf;
        private static int agencyNumber;
        private static string accountNum;
        private static double balance;
        private static Client holder;
        private static char key;
        private static double amount;
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            nomeClient = Console.ReadLine();
            Console.WriteLine("Qual é o seu cpf?");
            cpf = Console.ReadLine();
            Client client1 = new Client(nomeClient, cpf);
            if (nomeClient == null || cpf == null)
            {
                return;
            }
            Console.WriteLine("O seu nome e o seu cpf : " + client1.name + " " + client1.cpf);
            Console.WriteLine("Qual é o numero da sua agencia?");
            int.TryParse(Console.ReadLine(), out agencyNumber);
            Console.WriteLine("Qual é o numero da sua conta?");
            accountNum = Console.ReadLine();
            CurrentAccount account = new CurrentAccount(agencyNumber, accountNum, balance, holder);

            Console.WriteLine("Você tem esse saldo: " + balance);
            account.balance = 1000;


            Client client2 = new Client("Teste", "Teste3");

            CurrentAccount account2 = new CurrentAccount(agencyNumber, accountNum, balance, holder)
            {
                holder = client2,
                account = "1015-X",
                agencyNumber = 16,
                balance = 200
            };
            Console.WriteLine("D:Deposit S:Saque T:Transference");
            char.TryParse(Console.ReadLine(), out key);
            switch (key)
            {
                case 'S':
                    Console.WriteLine("Qual é o valor do saque: ");
                    double.TryParse(Console.ReadLine(), out amount);
                    account.Withdraw(amount);
                    Console.WriteLine("Seu valor na balança é : " + account.balance);
                    break;
                case 'D':
                    Console.WriteLine("Qual é o valor a ser depositado: ");
                    double.TryParse(Console.ReadLine(), out amount);
                    account.Deposit(amount);
                    Console.WriteLine("Seu valor na balança é : " + account.balance);
                    break;
                case 'T':
                    Console.WriteLine("Qual é o valor a ser transferido: ");
                    double.TryParse(Console.ReadLine(), out amount);
                    account.Transfer(amount,account2);
                    Console.WriteLine($"O valor a ser transferido é :{amount}"  + $"e o nome do beneficiario é : {account2.holder.name}");
                    break;

            }

            string json = JsonConvert.SerializeObject(account);
            File.WriteAllText("account.json", json);

            string jsonSalvo = File.ReadAllText("account.json");
            CurrentAccount accountSalva = JsonConvert.DeserializeObject<CurrentAccount>(jsonSalvo);
            Console.WriteLine(accountSalva);

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
