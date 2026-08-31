using System;

namespace _04LabExercise01_Mandac
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            const double APPLE_PRICE = 32.50;

            while (isRunning)
            {
                try
                {
                    Console.WriteLine("--------------------[ FRUIT STORE ]--------------------");
                    Console.Write("Enter the number of apples you want to purchase: ");
                    int qty = Convert.ToInt32(Console.ReadLine());

                    if (qty < 0)
                    {
                        Console.WriteLine("[!] ERROR: Input must be greater than 0");
                        return;
                    }
                    double total = qty * APPLE_PRICE;
                    double convertedPrice = (int)total;

                    Console.WriteLine("\n--------------------[ TOTAL COST ]---------------------");
                    Console.WriteLine("The total price of " + qty + " apples is: " + total.ToString("0.00"));
                    Console.WriteLine("The value of converted price is: " + convertedPrice);
                    Console.WriteLine("=======================================================");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n=====================================================");
                    Console.WriteLine("[!] ERROR: " + ex.Message);
                    Console.WriteLine("=======================================================");
                }
                finally
                {
                    Console.WriteLine("\nPress esc to exit or press any key(except esc) to continue...\n");
                    bool exit = Console.ReadKey().Key == ConsoleKey.Escape;

                    if (exit)
                    {
                        isRunning = false;
                    }
                }
            }
        }
    }
}