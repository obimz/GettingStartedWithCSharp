using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result = 0;

            Console.WriteLine("What shape would you like to find the area of? Please enter 'r' for rectangle or 'c' for circle or 't' for traingle");

            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the rectangle");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else if (answer == "c")
            {
                Console.WriteLine("Please enter the radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * radius * radius;
            }
            else if (answer == "t")
            {
                Console.WriteLine("Please enter the base of the triangle");
                float baseLength = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the triangle");
                float height = float.Parse(Console.ReadLine());

                result = 0.5f * baseLength * height;
            }
            else
            {
                Console.WriteLine("Please enter a valid shape");
            }

            Console.WriteLine("The area of the shape is: " + result);
            Console.ReadKey();
        }
    }
}

