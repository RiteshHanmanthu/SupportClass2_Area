using System;

namespace SupportClass2_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declarations
            double length, width, radius, height, base1, area;
            const double PI = 3.1415962;
            Console.WriteLine("This program will calculate the area of a rectangle, circle and triangle");

            //User inputs for the rectangle
            Console.Write("\n\nArea of a Rectangle/Square...\n");
            Console.Write("Please enter the length of the rectangle ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the width of the rectangle ");
            width = Convert.ToDouble(Console.ReadLine());

            area = length * width;
            Console.Write("\nThe area of the rectangle is " + area);
            
            //User inputs for the circle
            Console.Write("\n\nArea of a Circle...\n");
            Console.Write("Please enter the radius ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = PI * radius * radius;
            Console.Write("\nThe area of the circle is " + area);

            //User inputs for the triangle
            Console.Write("\n\nArea of a Triangle...\n");
            Console.Write("Please enter the base ");
            base1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the height ");
            height = Convert.ToDouble(Console.ReadLine());
            area = 0.5 * base1 * height;

            Console.Write("\nThe area of the triangle is " + area);

            //Pausing the screen
            Console.Write("\n\n\nPress any key to exit... ");
            Console.ReadKey();
        }
    }
}
