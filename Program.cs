using System.Drawing;

namespace Assignment1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Welcome to caculating an area of a shape. Choose between triangle, square, or a rectangle.\n");
            Console.WriteLine("Please enter a \"1\" for triangle, \"2\" for square, or a \"3\" for a rectangle.\n, and \"4\" to exit.");
            int promptInput = Convert.ToInt32(Console.ReadLine());
            Prompt(promptInput);
               
        }

        static void Prompt(int input)
        {
            bool flag = true;
            do
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter the base for the triangle.");
                        double baseTriangle = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the height.");
                        double heightTriangle = Convert.ToDouble(Console.ReadLine());
                        double triangleArea = CalculateTriangleArea(baseTriangle, heightTriangle);
                        Console.WriteLine($"\nThe area of this triangle is: {triangleArea}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the side for the square.");
                        int sideSquare = Convert.ToInt32(Console.ReadLine());
                        int squareArea = CalculateSquareArea(sideSquare);
                        Console.WriteLine($"The area of this square is: {squareArea}\n");

                        break;
                    case 3:
                        Console.WriteLine("Enter the width of the rectangle");
                        int width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the length of the rectangle");
                        int length = Convert.ToInt32(Console.ReadLine());
                        int rectangleArea = CalculateRectangleArea(width, length);
                        Console.WriteLine($"The area of this rectangle is: {rectangleArea}\n");
                        break;
                    case 4:
                        Console.WriteLine("You are exiting the program. Goodbye\n");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input, try again.!");
                        Console.WriteLine("Please enter a \"1\" for triangle, \"2\" for square, a \"3\" for a rectangle.\n, or \"4\" to exit.");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                }

                if (flag)
                {
                    Console.WriteLine("\nPlease enter a \"1\" for triangle, \"2\" for square, a \"3\" for a rectangle, or \"4\" to exit.");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                else if (input == 4)
                {
                    flag = false;
                }
            } while (flag) ;
        }

        static double CalculateTriangleArea(double baseTriangle, double heightTriangle)
        {
            double area = 0.5 * (baseTriangle * heightTriangle);
            return area;
        }

        static int CalculateSquareArea(int side)
        {
            int area = side * side;
            return area;
        }

        static int CalculateRectangleArea(int width, int length)
        {
            int area = width * length;
            return area;
        }
    }
}
