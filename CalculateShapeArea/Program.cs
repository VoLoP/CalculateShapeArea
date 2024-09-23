using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Do you want to calculate the area of a rectangle or a circle?");
                Console.WriteLine("Type 'rectangle' or 'circle' to calculate, or 'exit' to quit:");
                string choice = Console.ReadLine().ToLower();

                if (choice == "exit")
                {
                    break;
                }

                Shape shape = null;

                switch (choice)
                {
                    case "rectangle":
                        shape = new Rectangle();
                        break;
                    case "circle":
                        shape = new Circle();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose either rectangle, circle, or exit");
                        continue;
                }

                try
                {
                    shape.CalculateArea();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
