using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics
{
    internal class Employee
    {
        string phone;
        decimal salary;

        public Guid Id { get; } = Guid.NewGuid();
        public string Email { get; set; }
        public string Name { get; set; }
        //public string Address { get; set; }
        //will use Address for composition example
        public Address Address { get; private set; }
        public BankAccount BankAccount { get; set; }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.Length == 10 && (value.StartsWith("079") || value.StartsWith("078") || value.StartsWith("077")))
                {
                    phone = value;
                }
                else
                {
                    Console.WriteLine("Invalid phone number. It must be 10 digits.");
                }
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 6000)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary must be at least 6000.");
                }
            }
        }

        public Employee() : this("test@domailn.com", "Nour123", "0796543219878", 7000, "Jordan", "Amman", "19100", "US", "10", 165.21f, 846.23f)
        {
            Console.WriteLine("Default Constructor");
        }        

        public Employee(string email, string name, string phone, decimal salary, string country, string city, string postalCode, string streetName, string streetNumber, float longitude, float latitude)
        {
            Email = email;
            Name = name;
            Address = new Address(country, city, postalCode, streetName, streetNumber, longitude, latitude);
            Phone = phone;
            Salary = salary;
            Console.WriteLine("Parameterized Constructor");
        }

        //public void setPhone(string phone)
        //{
        //    if (phone.Length == 10 && (phone.StartsWith("079") || phone.StartsWith("078") || phone.StartsWith("077")))
        //    {
        //        this.phone = phone;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid phone number. It must be 10 digits and start with 079, 078, or 077.");
        //    }
        //}

        //public string getPhone()
        //{
        //    return this.phone;
        //}

        //public void setSalary(decimal salary)
        //{
        //    if (salary >= 6000)
        //    {
        //        this.salary = salary;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Salary must be at least 6000.");
        //    }
        //}

        //public decimal getSalary()
        //{
        //    return this.salary;
        //}

        public void increaseSalary(decimal amount)
        {
            if (amount > 0)
            {
                Salary += amount;
            }
            else
            {
                Console.WriteLine("Increase amount must be positive.");
            }
        }

        public void displayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Phone: {Phone}, Email: {Email}, Address: {Address}, Salary: {Salary}");
        }

        //Association: Employee "support a" Student
        public void supportStudent(Student student, decimal amount)
        {
            student.Balance += amount;
        }

        //Aggregation: Employee a "whole-part" of BankAccount, so here the BankAccount is a part of the whole Employee
        // you will pass the bank account from outside, will not create it inside the employee
        public void GetRelatedBankAccount(BankAccount bankAccount)
        {
            // this line make it aggregation not association
            BankAccount = bankAccount;
        }

        /* Assignment:
        - all fields private, properties for all of them
        - use constructor chaining (), (id), (id, name, salary)
        - modify display
         */
    }
}
