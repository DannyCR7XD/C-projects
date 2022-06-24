using System;

public class cardHolder 
{
    int pin;
    double balance;
    String FirstName;
    String LastName;
    String CardNum;

    public cardHolder(string CardNum, int pin, string FirstName, string LastName, double balance)
    {
        this.CardNum = CardNum;
        this.pin = pin;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.balance = balance;

    }

    public String getNum()
    {
        return CardNum;
    }

    public int getPin()
    { 
        return pin;
    }

    public String getFirstName()
    {
        return FirstName;
    }

    public String getLastName()
    { 
        return LastName;
    }

    public double getBalance()
    { 
        return balance;
    }

    public void setNum(String newCardNum) 
    {
        CardNum = newCardNum;
    }

    public void setpin(int newpin)
    { 
        pin = newpin;
    }

    public void setFirstName(String newFirstName) 
    { 
        FirstName = newFirstName;
    }

    public void setLastName(String newLastName)
    { 
        LastName = newLastName;
    }

    public void setBalance(double newBalance)
    { 
        balance = newBalance;
    }

    public static void Main(String[] args)
    { 
        void printOptions()
        {
            Console.WriteLine("Please choose one of the following options below to proceed: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");

        }

        void deposit(cardHolder currentUser)
        { 
            Console.WriteLine("How much money would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for using Bank of the U.S. Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        { 
            Console.WriteLine("How much money would you like to withdraw today? ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //Before proceeding with withdrawls, check to verify user has sufficient funds
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient Balance.");
            }
            else
            { 
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you for using Bank of the U.S.");
            }
        }

        void balance(cardHolder currentUser)
        { 
            Console.WriteLine("Curent Balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("12345678", 1234, "Sarah", "Olsen", 25.97));
        cardHolders.Add(new cardHolder("23456789", 1235, "John", "Howard", 233.88));
        cardHolders.Add(new cardHolder("34567891", 1236, "Dani", "Casta", 900.05));
        cardHolders.Add(new cardHolder("45678912", 1237, "Mike", "Garcia", 45.87));
        cardHolders.Add(new cardHolder("56789123", 1238, "Dawn", "Smith", 565.29));

        //Prompt User 
        Console.WriteLine("Welcome to Bank of the U.S.!");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Card not recognized. Please Try Again!");
                }
            }


            catch
            {
                Console.WriteLine("Card not recognized. Please Try Again!");
            }
        }

        Console.WriteLine("Please enter your Pin:");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Pin. Please Try Again!");
                }
            }
            catch 
            {
                Console.WriteLine("Incorrect Pin. Please Try Again!");
            }
        }
    
        Console.WriteLine("Welcome " + currentUser.getFirstName());
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch 
            {
                if (option == 1) {deposit(currentUser);}
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
        }
        while (option != 4);
        { 
            Console.WriteLine("Thank You! Have a Nice Day!!");
        }
    
    }





}
