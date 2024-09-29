using System;

class PizzaProgram
{
    static Random random = new Random();

    static void PlainPizza(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(new string('*', rows - i));
        }
    }

    static void CheesePizza(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            Console.Write("*");
            Console.Write(new string('#', rows - i - 1));
            Console.WriteLine("*");
        }
    }

    static void PepperoniPizza(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            Console.Write("*");
            for (int j = 0; j < rows - i - 1; j++)
            {
                if (random.Next(4) == 0)
                {
                    Console.Write("[]");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine("*");
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Plain Pizza");
        Console.WriteLine("2. Cheese Pizza");
        Console.WriteLine("3. Pepperoni Pizza");
        Console.WriteLine("4. Exit");
    }

    static void Main(string[] args)
    {
        const int pizzaSize = 9;

        while (true)
        {
            DisplayMenu();
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nPlain Pizza Slice:");
                PlainPizza(pizzaSize);
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nCheese Pizza Slice:");
                CheesePizza(pizzaSize);
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nPepperoni Pizza Slice:");
                PepperoniPizza(pizzaSize);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please choose 1, 2, 3, or 4.");
            }
        }
    }
}


