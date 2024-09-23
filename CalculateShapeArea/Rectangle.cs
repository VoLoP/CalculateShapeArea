using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapeArea
{
    class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            double height = GetValidInput("Enter the height of the rectangle:");
            double length = GetValidInput("Enter the length of the rectangle:");

            double area = height * length;
            Console.WriteLine($"The area of the rectangle is: {area}");
        }

        private double GetValidInput(string message)
        {
            double input;
            bool isValid;

            do
            {
                Console.WriteLine(message);
                string inputString = Console.ReadLine();
                isValid = double.TryParse(inputString, out input);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValid);

            return input;
        }
    }
}
