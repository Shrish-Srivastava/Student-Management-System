using System;
using System.Collections.Generic;

class StackImplementation
{
    static void Main()
    {
        // Create a stack instance
        Stack<int> stack = new Stack<int>();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the value to push:");
                    int valueToPush = Convert.ToInt32(Console.ReadLine());
                    stack.Push(valueToPush);
                    break;

                case 2:
                    int poppedValue = stack.Pop();
                    if (poppedValue != -1)
                        Console.WriteLine($"Popped element: {poppedValue}");
                    break;

                case 3:
                    Console.WriteLine("Elements in stack are: ");
                    foreach (int element in stack)
                    {
                        Console.WriteLine(element);
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}
