using System;

namespace _04LabExercise01_Mandac
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            const float APPLE_PRICE = 32.50f;

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

                    Console.WriteLine("\n--------------------[ TOTAL COST ]---------------------");
                    float total = qty * APPLE_PRICE;
                    Console.WriteLine($"The total price of {qty} apples is: {total:0.00}");
                    Console.WriteLine("The value of converted price is: " + (int)total);
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