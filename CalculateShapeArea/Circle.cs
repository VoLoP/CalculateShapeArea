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
