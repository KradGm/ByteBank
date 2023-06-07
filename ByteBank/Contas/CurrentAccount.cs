using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class CurrentAccount
{
        public int agencyNumber;
        public string account;
        public double balance = 100;

        public Client holder;
        /*
        [Criar classe pois tem muitas responsabilidades]
        public string holderName;
        public string holderCPF;
        public string holderProfession;
        */


        //method
        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        /// <summary> Esse codigo serve para sacar um certo valor </summary>
        /// <param name="amount"> Valor a ser medido </param>
        /// <returns> Nada </returns>
        public bool Withdraw(double amount)
        {
            if(amount <= balance)
            {
                this.balance -= amount;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Transfer(double amount, CurrentAccount targetAccount)
        {
            if(balance <= amount)
            {
                return false;
            }
            else
            {
                this.Withdraw(amount);
                targetAccount.Deposit(amount);
                return true;
            }
        }
        public void Informations(string holder, int agencyNumber, string account, double balance)
        {
            Console.WriteLine("O nome do titular é: " + this.holder + " O numero da agencia dele é: " + this.agencyNumber + " O numero da sua conta é: " + this.account + " O seu saldo é : " + this.balance);
        }
    }
}
