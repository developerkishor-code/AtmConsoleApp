using System;
public class AtmConsoleApp
{
  static int userAmount = 100;
  static int userAccountNumber = 123456;
  static int userPin = 1234;
    public AtmConsoleApp()
    {
      while (true)
      {
          Console.WriteLine("***** Welcome to the Kishore'ATM! *****");
          Console.WriteLine("Please select an option:");
          Console.WriteLine("1. Check Balance");
          Console.WriteLine("2. Withdraw Money");
          Console.WriteLine("3. Deposit Money");
          Console.WriteLine("4. Change PIN");
          Console.WriteLine("5. Cancel");

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

    private static void CheckBalance(int accountNumber, int pin)
    {
        if(accountNumber == userAccountNumber && pin == userPin)
        {
            Console.WriteLine("Your current balance is: ₹" + userAmount);
        }
        else
        {
            Console.WriteLine("Invalid account number or PIN.");
        }
    }

    private static void WithdrawMoney(int accountNumber, int pin)
    {
        if(accountNumber == userAccountNumber && pin == userPin)
        {
            Console.Write("Enter the amount you want to withdraw (₹):");
            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount > userAmount)
                {
                    Console.WriteLine("Insufficient balance.");
                }
            else
            {
                userAmount -= amount;
                Console.Write("Please take your cash: ₹" + amount);
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

    private static void DepositMoney(int accountNumber, int pin)
    {
        if(accountNumber == userAccountNumber && pin == userPin)
        {
            Console.Write("Enter the amount you want to deposit (₹):");
            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                userAmount += amount;
                Console.Write("₹" + amount + " deposited successfully.");
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

    public static void ChangePin(int accountNumber, int oldPin, int newPin)
    {
        if(accountNumber == userAccountNumber && oldPin == userPin)
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