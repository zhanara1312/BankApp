using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********************");
            Console.WriteLine("Welcome to my Bank!");
            Console.WriteLine("********************");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print my Accounts");
                Console.Write("Select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the bank!");
                        return;
                    case "1":
                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();

                        var accountTypes = Enum.GetNames(typeof(AccountType));
                        for (int i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}. {accountTypes[i]}");
                        }
                        Console.Write("Account Type: ");
                        var accountType = Enum.Parse<AccountType>(Console.ReadLine());

                        Console.Write("Amount to deposit: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());

                        var a1 = Bank.CreateAccount(emailAddress, accountType, amount);
                        Console.WriteLine($"AN: {a1.AccountNumber}, CD: {a1.CreatedDate}, Balance: {a1.Balance:C}, EA: {a1.EmailAddress}, AT: {a1.AccountType}");
                        break;
                    case "2":
                        PrintAllAccounts();
                        Console.Write("AccountNumber: ");
                        var accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Amount to deposit: ");
                        var DepositAmount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Deposit(accountNumber, DepositAmount);
                        Console.WriteLine("Deposit successfully completed!");
                        break;
                    case "3":
                        Console.Write("AccountNumber: ");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Amount to withdraw: ");
                        var withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Withdraw(accountNumber, withdrawAmount);
                        Console.WriteLine("Withdrawal successfully completed!");
                        break;
                    case "4":
                        PrintAllAccounts();
                        break;
                    default:
                        break;
                }
            }
        }
        private static void PrintAllAccounts()
        {
            var accounts = Bank.GetAllAccountsForUser();
            foreach (var account in accounts)
            {
                Console.WriteLine($"AN: {account.AccountNumber}, CD: {account.CreatedDate}, Balance: {account.Balance:C}, EA: {account.EmailAddress}, AT: {account.AccountType}");
            }

        }
    }
}
