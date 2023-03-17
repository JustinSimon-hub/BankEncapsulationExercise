using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
			public BankAccount()
				{
				}
				private double Balance = 0;
				public void Deposit (double amount)
					{
						Balance += amount;
					}

				public void GetBalance()
					{
			Console.WriteLine(Balance);
			
					}
	}
}

