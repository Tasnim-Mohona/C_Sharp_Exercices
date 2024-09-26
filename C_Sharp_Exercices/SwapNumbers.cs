using System;

public class SwapNumbers
{
	public void Swap()
	{
	
		// Declaration of variables to store numbers and temporary value for swapping 
		int number1, number2, temp;
		Console.Write("\nInput First Number : ");
		// Reading the first number entered by the user  
		number1 = int.Parse(Console.ReadLine());

		// Prompting the user to input the second number
		Console.Write("\nInput the second number : ");
		// Reading the second number entered by the user 
		number2 = int.Parse(Console.ReadLine());

		// Swapping the values of number1 and number2 using a temporary variable
		temp = number1;
		number1 = number2;
		number2 = temp;
		
		Console.Write("\nAfter swapping : ");
		Console.Write("\nFirst Number :" + number1);
		Console.Write("\nSecond Number : " + number2);
		Console.Read();

	}
}
