using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Implementations
{
    public class Circle : AbstractShape
    {
        public override void GetDimensions()
        {
            bool valid = false;
            double radius;
            string consoleIn;

            while (!valid)
            {
                Console.Write("Please provide a radius: ");
                consoleIn = Console.ReadLine();

                if (double.TryParse(consoleIn, out radius))
                {
                    valid = true;
                    CalculateArea(radius);
                }
                else
                {
                    Console.WriteLine("That was not a valid radius");
                }
            }
        }

        private void CalculateArea(double radius)
        {
            _area = Math.PI * Math.Pow(radius, 2);
        }
    }
}
