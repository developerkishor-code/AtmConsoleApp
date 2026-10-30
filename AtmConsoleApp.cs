using System;
public class AtmConsoleApp
{
    int userAmount = Constants.InitialUserAmount;
    int userPin = Constants.InitialUserPin;

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("***** Welcome to the Kishore'ATM! *****");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Deposit Money");
            Console.WriteLine("4. Change PIN");
            Console.WriteLine("5. Return to Main Menu");
            Console.WriteLine("6. Exit");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    (int balanceAccountNumber, int balancePin) = ReadCredentials();
                    CheckBalance(balanceAccountNumber, balancePin);
                    break;
                case 2:
                    (int withdrawalAccountNumber, int withdrawalPin) = ReadCredentials();
                    WithdrawMoney(withdrawalAccountNumber, withdrawalPin);
                    break;
                case 3:
                    (int depositAccountNumber, int depositPin) = ReadCredentials();
                    DepositMoney(depositAccountNumber, depositPin);
                    break;
                case 4:
                    (int changePinAccountNumber, int oldPin) = ReadCredentials();
                    Console.WriteLine("Enter your new PIN:");
                    int newPin = Convert.ToInt32(Console.ReadLine());
                    ChangePin(changePinAccountNumber, oldPin, newPin);
                    break;
                case 5:
                    Console.WriteLine("Returning to main menu.");
                    break;
                case 6:
                    Console.WriteLine("Exiting the ATM. Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static (int AccountNumber, int Pin) ReadCredentials()
    {
        Console.Write("Enter your account number:");
        try
        {
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your PIN:");
            int pin = Convert.ToInt32(Console.ReadLine());
            return (accountNumber, pin);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
            return ReadCredentials();
        }
    }

    private void CheckBalance(int accountNumber, int pin)
    {
        if (accountNumber == Constants.UserAccountNumber && pin == userPin)
        {
            Console.WriteLine("Your current balance is: ₹" + userAmount);
            Console.WriteLine("Press 5 to return to the main menu.");
            while (Console.ReadLine() != "5")
            {
                Console.WriteLine("Please press 5 to return to the main menu.");
            }
        }
        else
        {
            Console.WriteLine("Invalid account number or PIN.");
        }
    }

    private void WithdrawMoney(int accountNumber, int pin)
    {
        if (accountNumber == Constants.UserAccountNumber && pin == userPin)
        {
            Console.Write("Enter the amount you want to withdraw (₹):");
            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount > userAmount)
                {
                    Console.WriteLine("Insufficient balance.");
                    Console.WriteLine("Press 5 to return to the main menu.");
                    while (Console.ReadLine() != "5")
                    {
                        Console.WriteLine("Please press 5 to return to the main menu.");
                    }
                }
                else
                {
                    userAmount -= amount;
                    Console.WriteLine("Please take your cash: ₹" + amount);
                    Console.WriteLine("Press 5 to return to the main menu.");
                    while (Console.ReadLine() != "5")
                    {
                        Console.WriteLine("Please press 5 to return to the main menu.");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid account number or PIN.");
        }
    }

    private void DepositMoney(int accountNumber, int pin)
    {
        if (accountNumber == Constants.UserAccountNumber && pin == userPin)
        {
            Console.Write("Enter the amount you want to deposit (₹):");
            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                userAmount += amount;
                Console.WriteLine("₹" + amount + " deposited successfully.");
                Console.WriteLine("Press 5 to return to the main menu.");
                while (Console.ReadLine() != "5")
                {
                    Console.WriteLine("Please press 5 to return to the main menu.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid account number or PIN.");
        }
    }

    public void ChangePin(int accountNumber, int oldPin, int newPin)
    {
        if (accountNumber == Constants.UserAccountNumber && oldPin == userPin)
        {
            userPin = newPin;
            Console.Write("PIN changed successfully.");
        }
        else
        {
            Console.Write("Invalid account number or PIN.");
        }
    }
}