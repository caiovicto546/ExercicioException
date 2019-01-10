using System;
using System.Globalization;
using ExercicioFixException.Entities;
using ExercicioFixException.Exception;

namespace ExercicioFixException
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account;
            int num;
            string holder;
            double balance;
            double withdraw;
            double amount;

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw Limit: ");
            withdraw = double.Parse(Console.ReadLine());

            account = new Account(num, holder, balance, withdraw);

            Console.WriteLine();

            try
            {
                Console.Write("Enter amount for withdraw: ");
                amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);

                Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

                Console.ReadLine();
            }
            catch (GlobalException e)
            {

                Console.WriteLine("Withdraw error: " + e.Message);
            }

            
        }
    }
}
