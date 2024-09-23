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

        private double GetValidInput(string prompt)
        {
            double value;
            while (true)
            {
                Console.WriteLine(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please enter a positive numeric value.");
            }
        }
    }
}
