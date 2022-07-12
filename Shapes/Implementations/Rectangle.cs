using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Implementations
{
    public class Rectangle : AbstractShape
    {
        public override void GetDimensions()
        {
            bool valid = false;
            double length;
            double width;
            string consoleIn;

            while (!valid)
            {
                Console.Write("Please provide rectangle length: ");
                consoleIn = Console.ReadLine();

                if (double.TryParse(consoleIn, out length))
                {
                    Console.Write("Please provide rectangle height: ");
                    consoleIn = Console.ReadLine();

                    if (double.TryParse(consoleIn, out width))
                    {
                        valid = true;
                        CalculateArea(length, width);
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid height");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid length");
                }
            }
        }

        private void CalculateArea(double length, double width)
        {
            _area = length * width;
        }
    }
}
