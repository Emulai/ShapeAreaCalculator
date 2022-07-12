using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Implementations
{
    public class NGon : AbstractShape
    {
        private int _sides;
        public int Sides { get { return _sides; } }

        public override void GetDimensions()
        {
            bool valid = false;
            string consoleIn;

            while (!valid)
            {
                Console.Write("Please provide the number of sides: ");
                consoleIn = Console.ReadLine();

                if (int.TryParse(consoleIn, out _sides))
                {
                    Console.Write("Please provide the length of the sides: ");
                    consoleIn = Console.ReadLine();

                    if (double.TryParse(consoleIn, out double sideLength))
                    {
                        valid = true;
                        CalculateArea(sideLength);
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid side length");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid number of sides");
                }
            }
        }

        private void CalculateArea(double sideLength)
        {
            _area = _sides
                    * (Math.Pow(sideLength, 2))
                    * (1 / MathF.Tan((float)(Math.PI / _sides)))
                    / 4;
        }
    }
}
