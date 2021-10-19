using System;

class Program {
  public static void Main (string[] args) {

    string no = "no";
    while(true)
    {
      Console.WriteLine ("Enter number of hours parked in parking garage:");
      int hours = Convert.ToInt32(Console.ReadLine());
      double charges = CalculateCharges(hours);
      Console.WriteLine("$" + charges);
      Console.WriteLine("Are there any more customers? Enter yes or no");
      string value = Console.ReadLine();
      if(value.Equals(no))
      {
        break;
      }
    }
    
  }

  public static double CalculateCharges(int hours)
  {
    double amount = 0.00;
    if(hours <= 3)
    {
      amount = 2.00;
    }
    else if(hours > 3 && hours < 24)
    {
      amount = 2.00 + ((hours-3) * .50);
    }
    else
    {
      amount = 10.00;
    }
    
    return amount;
  }
}