using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics
{
    internal class BankAccountV2(string name, decimal balance = 1000)
    {
        public string Name { get; set; } = name;
        public decimal Balance { get; private set; } = balance;
        public int Id { get; init; } = new Random().Next(1000, 9999);
        public required string Email { get; set; }
    }
}
