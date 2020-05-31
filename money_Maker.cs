using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.Write("Enter the amount to convert: ");
      double amount = Math.Floor(Convert.ToDouble(Console.ReadLine())); //converts the user input to double and rounds it down
      Console.WriteLine($"{amount} cents is equal to...");

      int goldCoin = 10; //cents
      int silverCoin = 5; //cents

      //Calculates the number of gold possible
      double goldValue = Math.Floor(amount/goldCoin);
      double remainingAmount = amount % goldCoin; 

      //calculates the number of silver possible
      double silverValue = Math.Floor(remainingAmount/silverCoin);
      remainingAmount = remainingAmount % silverCoin;

      //prints the overall calculations
      Console.WriteLine($"Gold coins: {goldValue} \nSilver coins: {silverValue} \nBronze coins: {remainingAmount}");



      
    }
  }
}
