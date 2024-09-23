using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapeArea
{
    class Circle : Shape
    {
        public override void CalculateArea()
        {
            double radius = GetValidInput("Enter the radius of the circle:");

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is: {area}");
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
