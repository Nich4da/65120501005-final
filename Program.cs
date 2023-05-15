using System;

class Program
{
    static void Main()
    {
        double B1, B2, B3; 
        double vdrink, tday, tdrink, tfill; 
        
     
        Console.WriteLine("Enter balance values:");
        Console.Write("B1: ");
        B1 = ReadPositiveDouble();
        Console.Write("B2: ");
        B2 = ReadPositiveDouble();
        Console.Write("B3: ");
        B3 = ReadPositiveDouble();

      
        Console.WriteLine("Enter water values:");
        Console.Write("vdrink: ");
        vdrink = ReadPositiveDouble();
        Console.Write("tday: ");
        tday = ReadPositiveDouble();
        Console.Write("tdrink: ");
        tdrink = ReadPositiveDouble();
        Console.Write("tfill: ");
        tfill = ReadPositiveDouble();

       
        if (vdrink <= vmax && tday >= tdrink && tday >= tfill)
        {
            double remainingWater = B1 + B2 + B3 - vdrink;

            if (remainingWater >= 0)
            {
                Console.WriteLine("Enough Water, {0} left", remainingWater);
            }
            else
            {
                Console.WriteLine("Not Enough Water");
            }
        }
        else
        {
            Console.WriteLine("Overflow Water");
        }


        Console.WriteLine("Balance 1: {0}", B1);
        Console.WriteLine("Balance 2: {0}", B2);
        Console.WriteLine("Balance 3: {0}", B3);


        double totalLeft = Math.Max(-B1, 0) + Math.Max(-B2, 0) + Math.Max(-B3, 0);
        if (totalLeft > 0)
        {
            Console.WriteLine("Left: {0}", totalLeft);
        }
    }


    static double ReadPositiveDouble()
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), out value) || value < 0)
        {
            Console.WriteLine("Please enter a positive number:");
        }
        return value;
    }
}
