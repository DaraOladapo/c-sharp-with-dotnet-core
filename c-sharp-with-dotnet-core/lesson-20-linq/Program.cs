using System;
using System.Collections.Generic;

namespace lesson_20_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transaction> Transactions = new List<Transaction>(){
             new Transaction{Name="Debit Stuff", Date=DateTime.Now },
             new Transaction{Name="Another Debit Stuff", Date=DateTime.Now.AddDays(7)},
             new Transaction{Name="Credit Stuff", Date=DateTime.Now},
             new Transaction{Name="Another crediting Stuff", Date=DateTime.Now.AddYears(10)},
             new Transaction{Name="Loan", Date=DateTime.Now.AddMinutes(2)},
             new Transaction{Name="Recharge", Date=DateTime.Now},
             new Transaction{Name="Recharge", Date=DateTime.Now.AddDays(-2)},
             new Transaction{Name="Recharge", Date=DateTime.Now.AddDays(-5)}
             };

            var allTransactionsInThePast = Transactions.FindAll(opt => opt.Date <= DateTime.Now);
            /*
            create a new list called called Whatever
            Iterate over Transactions
                as you iterate if the current iteration has date <=the current date, add it to whatever
            after the iteration is over, return Whatever
             */
            Console.WriteLine("All transactions in the past");
            foreach (var Transaction in allTransactionsInThePast)
            {
                Console.WriteLine($"Name: {Transaction.Name}\tTime: {Transaction.Date.ToLongTimeString()}");
            }

            var Names = new List<string>()
            {
                "Dara","James","Ebuka", "Smith"
            };
            Console.WriteLine("Who are you looking for?");
            var inputString = Console.ReadLine().ToLower();
            SearchHelper.FindAndReplace(Names, inputString);
        }

        
    }
}
