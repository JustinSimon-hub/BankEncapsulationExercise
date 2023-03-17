namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount Money = new BankAccount();
            //Asks user for deposit amount
            Console.WriteLine("How many dollars would you like to deposit?");
            // Stores amount inside Deposit function inside the BankAccount class
            double a = Convert.ToDouble(Console.ReadLine());
           Money.Deposit(a);
            Console.WriteLine("Heres how many dollars you have in your account.");
            Money.GetBalance();


        }
    }
}



/*
Create a new public class named BankAccount

In your BankAccount class, create the following:
+A private field of type double named balance with a value of 0
+ Define a method named Deposit that will accept a double and store that value in the balance field
+ Define a method named GetBalance that will return the amount stored in the balance field

In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.

Once finished save, commit, and push back to Github
*/
