using System;

namespace Calculator
{
     class Program
    {
        static void Main(string[] args)
        
        {
            double n1 = 0;
            double n2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Type a number, and then press Enter");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type another number,and the press Enter");
            n2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine()) 
            {
                case "a":
                    Console.WriteLine($"Your result: {n1} + {n2} = " + (n1 + n2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {n1} - {n2} = " + (n1 - n2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {n1} * {n2} = " + (n1 * n2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {n1} / {n2} = " + (n1 / n2));
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
