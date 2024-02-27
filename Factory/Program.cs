using Factory;

class Program
{
    public static void Main(string[] args)
    {
        string accountHolderName;
        string accountNumber = "1234567";
        string accountType;

        Console.WriteLine("Welcome to XYZ bank !" +
            "\nPlease enter your name.");
        accountHolderName = Console.ReadLine();

        Console.WriteLine("Enter Account Type to open.");
        accountType = Console.ReadLine();
        IAccount account = AccountFactory.CreateAccount(accountType);
        account.PrintDetails(accountHolderName, accountNumber);
    }
}