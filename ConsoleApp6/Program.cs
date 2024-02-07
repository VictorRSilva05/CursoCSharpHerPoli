using ConsoleApp6.Entities;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1001, "Alex", 500);
            Account account2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            account1.Withdraw(10);
            account2.Withdraw(10);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
        }
    }
}
