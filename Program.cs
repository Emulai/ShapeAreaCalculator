using Shape.Implementations;

class AreaCalculator
{
    static void Main(string[] args)
    {
        bool isLive = true;

        Console.WriteLine("Shape area calculator");

        while (isLive)
        {
            Console.WriteLine("Please select a shape from the following options:");

            Console.WriteLine("Circle (1)");
            Console.WriteLine("Triangle (2)");
            Console.WriteLine("Rectangle (3)");
            Console.WriteLine("Regular N-Gon (4)");

            Console.WriteLine("Or exit the program (-1)");

            string consoleIn = Console.ReadLine();

            if (int.TryParse(consoleIn, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Circle circle = new Circle();
                        circle.GetDimensions();

                        Console.WriteLine($"The area of your circle is: {circle.GetArea()} units squared");
                        break;

                    case 2:
                        Triangle triangle = new Triangle();
                        triangle.GetDimensions();

                        Console.WriteLine($"The area of your triangle is: {triangle.GetArea()} units squared");
                        break;

                    case 3:
                        Rectangle rectangle = new Rectangle();
                        rectangle.GetDimensions();

                        Console.WriteLine($"The area of your rectangle is: {rectangle.GetArea()} units squared");
                        break;

                    case 4:
                        NGon ngon = new NGon();
                        ngon.GetDimensions();

                        Console.WriteLine($"The area of your {ngon.Sides}-sided shape is: {ngon.GetArea()} units squared");
                        break;

                    case -1:
                        isLive = false;
                        Console.WriteLine("Good bye");
                        break;

                    default:
                        Console.WriteLine("Please select from the options above");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter the number next to the option");
            }

            Console.WriteLine();
        }
    }
}