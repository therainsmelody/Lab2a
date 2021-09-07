using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of the item");
  string name = Console.ReadLine();


    Console.WriteLine ("Enter the quantity");
    double quantity = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine ("Enter the price");
    double price = Convert.ToDouble(Console.ReadLine());


  double fp = (quantity*price);
  

  Console.WriteLine ("Total price of " + name + "= $" + fp); 
  }
}