using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");

            if (age >= 21)
            {
                Console.WriteLine("You can legally drink alcohol in the US.");
            }
            else
            {
                Console.WriteLine("You cannot legally drink alcohol in the US.");
            }

            if (age >= 25)
            {
                Console.WriteLine("You can rent a car in the US.");
            }
            else
            {
                Console.WriteLine("You cannot rent a car in the US.");
            }

            if (age >= 30)
            {
                Console.WriteLine("You are eligible to apply for the scholarship.");
            }
            else
            {
                Console.WriteLine("You are not eligible to apply for the scholarship.");
            }
        }
        else
        {
            Console.WriteLine("You are not an adult.");
            Console.WriteLine("Please come back when you are older.");
        }
    }
}
