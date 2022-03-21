using System;

namespace Program4
{
    class DhakaBank
    {
        public int Balance { get; set; }
        private void PrintCurrentBalance()
        {
            Console.WriteLine("Your current balance is " + Balance);
        }
        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("You have " + amount + " tk diposit");
            PrintCurrentBalance();
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
            Console.WriteLine("You have withdrawn " + amount + " tk");
            PrintCurrentBalance();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DhakaBank dhk = new DhakaBank();
            dhk.Deposit(200000);
            dhk.Withdraw(100);
        }
    }
}
