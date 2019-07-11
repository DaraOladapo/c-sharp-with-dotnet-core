using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson_20_linq
{
    class Transaction
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Transactions = new List<Transaction>(){
             new Transaction{Name="Debit Stuff", Date=DateTime.Now },
             new Transaction{Name="Another Debit Stuff", Date=DateTime.Now.AddDays(7)},
             new Transaction{Name="Credit Stuff", Date=DateTime.Now},
             new Transaction{Name="Another crediting Stuff", Date=DateTime.Now.AddYears(10)},
             new Transaction{Name="Loan", Date=DateTime.Now.AddMinutes(2)},
             new Transaction{Name="Recharge", Date=DateTime.Now
             }
             };

            var allTransactionsToday = Transactions.FindAll(opt => opt.Date <= DateTime.Now);

            Console.WriteLine("All transactions today");
            foreach (var Transaction in allTransactionsToday)
            {
                Console.WriteLine($"Name: {Transaction.Name}\tTime: {Transaction.Date.ToLongTimeString()}");
            }

            var Names = new List<string>()
            {
                "Dara","James","Ebuka", "Smith"
            };
            Console.WriteLine("Who are you looking for?");
            var inputString = Console.ReadLine();
            var Name = Names.First<string>(opt => opt.Contains(inputString));
            
            Console.WriteLine($"Result of your {inputString} search = {Name}");
        }
    }
}
