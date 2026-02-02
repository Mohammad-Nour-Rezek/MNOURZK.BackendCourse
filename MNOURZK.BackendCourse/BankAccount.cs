using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics
{
    public class BankAccount
    {
        int Id; //private is the default
        public string name;
        private string password;
        private decimal balance;

        public int SSN { get; init; }
        //private int ssn;
        //public int SSN { get { return ssn; } init { ssn = value; } }

        public required string Email { get; set; }
        public required string Mobile { get; set; }

        [SetsRequiredMembers]
        public BankAccount(string name = "test", string password = "168", decimal initialBalance = 2400, string email = "abc")
        {
            this.SSN = 123456789;
            Console.WriteLine("Constructor with name and password");
        }

        //public BankAccount()
        //{
        //    Console.WriteLine("Default Constructor");
        //}

        [SetsRequiredMembers]
        public BankAccount() : this(1000) // constructor chaining will call the constructor with initial balance,
                                          // then that one will call third one with all parameters,
                                          // then will return and execute the secon one body, then the first one body
        {
            Console.WriteLine("Defualt Consrtuctor");
        }

        [SetsRequiredMembers]
        public BankAccount(decimal initialBalance) : this("Nour", "P@ss0wrd", initialBalance)
        {
            Console.WriteLine("Constructor with initial balance");
        }

        [SetsRequiredMembers]
        public BankAccount(string name, string password, decimal initialBalance)
        {
            SetId();
            this.name = name;
            this.password = password;
            this.SSN = 123456789;
            //Setbalance(initialBalance);
            this.Email = "test@domain.com";
            Balance = initialBalance; // using property to set the balance
        }

        public decimal Balance
        {
            get 
            {
                return balance;
            }

            set
            {
                if (value >= 1000)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine($"{value} must be greater than or equal 1000.");
                }
            }
        }

        public void SetId()
        {            
            Random rand = new Random(1);
            this.Id = rand.Next(1, 10000);           
        }

        //public void Setbalance(decimal amount)
        //{
        //    if (amount >= 1000)
        //    {
        //        balance = amount;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Balance cannot be negative.");
        //    }
        //}

        //public decimal GetBalance(string password)
        //{
        //    return balance;
        //}

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
}
