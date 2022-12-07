using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class CurrentAccount
    {
        public static int TotalAccounts { get; private set; }
        private int agencyNumber;
        public int AgencyNumber
        {
            get { return this.agencyNumber; }
            private set
            {
                if (agencyNumber > 0)
                {
                    this.agencyNumber = value;
                }
                else
                {
                    Console.WriteLine("Número da agência não pode ser negativo");
                }
            }
        }

        public string Account { get; set; }
        private double balance;
        public Customer Owner { get; set; }

        public void Deposit(double value)
        {
            if (value > 0) 
            {
                this.balance += value;
            }
            else
            {
                Console.WriteLine("Depósitos devem ser maiores que R$0,00");
            }
        }
        
        public bool Withdraw(double value)
        {
            if (this.balance >= value)
            {
                this.balance -= value;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transfer(double value, CurrentAccount receiver)
        {
            if (this.balance < value)
            {
                return false;
            }
            if (value <= 0)
            {
                return false;
            }
            else
            {
                this.Withdraw(value);
                receiver.Deposit(value);
                return true;
            }
        }
        public void GetAccountInfo()
        {
            Console.WriteLine("Titular : " + Owner.Name);
            Console.WriteLine("CPF : " + Owner.Cpf);
            Console.WriteLine("Conta : " + Account);
            Console.WriteLine("Número Agência : " + AgencyNumber);
            Console.WriteLine("Saldo: " + balance);
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public CurrentAccount(Customer owner, int agencyNumber, string Account)
        {
            this.Owner = owner;
            this.agencyNumber = agencyNumber;
            this.Account = Account;
            TotalAccounts++;
        }
    }
}
