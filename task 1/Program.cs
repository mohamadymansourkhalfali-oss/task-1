

Console.Write("Number of small carpets: ");
int small = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of large carpets: ");
int large = Convert.ToInt32(Console.ReadLine());

double cost = (small * 25) + (large * 35);
double tax = cost * 0.06;
double total = cost + tax;

Console.WriteLine("Estimate for carpet cleaning service");
Console.WriteLine("Number of small carpets: " + small);
Console.WriteLine("Number of large carpets: " + large);
Console.WriteLine("Price per small carpet: $25");
Console.WriteLine("Price per large carpet: $35");
Console.WriteLine("Cost: $" + cost);
Console.WriteLine("Tax: $" + tax);
Console.WriteLine("========================");
Console.WriteLine("Total estimate: $" + total);
Console.WriteLine("This estimate is valid for 30 days");
