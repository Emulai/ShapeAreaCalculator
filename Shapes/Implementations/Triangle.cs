using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Implementations
{
    public class Triangle : AbstractShape
    {
        public override void GetDimensions()
        {
            bool valid = false;
            double baseLength;
            double height;
            string consoleIn;

            while (!valid)
            {
                Console.Write("Please provide triangle base length: ");
                consoleIn = Console.ReadLine();

                if (double.TryParse(consoleIn, out baseLength))
                {
                    Console.Write("Please provide triangle height: ");
                    consoleIn = Console.ReadLine();

                    if (double.TryParse(consoleIn, out height))
                    {
                        valid = true;
                        CalculateArea(baseLength, height);
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid height");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid base length");
                }
            }
        }

        private void CalculateArea(double length, double height)
        {
            _area = (height * length) / 2;
        }
    }
}
