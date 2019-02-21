using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;

namespace HomeWork
{
    partial class Program
    {
        public class MathFormulas
        {
            Validation validation = new Validation();
            public const double pi = Math.PI;

            public MathFormulas()
            {
                //Console.Clear();
            }

            public void Circumference()
            {
                Console.Write("Please enter the radius of your circle: ");

                var input = Console.ReadLine();
                double radius = validation.CheckInput(input);

                double circumference = pi * radius * 2;
                double area = pi * radius * radius;

                Console.WriteLine($"Circumfence: {circumference:f}\n" +
                                  $"Area: {area:f}");
                Console.ReadLine();
                MainMenu();
            }

            public void Volume()
            {
                Console.Write("Please enter the radius of your hemisphere: ");
                var input = Console.ReadLine();

                double radius = validation.CheckInput(input);
                double volume = ((4 / 3) * pi * Math.Pow(radius, 3)) / 2;

                Console.WriteLine($"Volume: {volume:f}");
                Console.ReadLine();

                MainMenu();
            }

            public void AreaOfTriangle()
            {
                Console.Write("Please enter the Length of your triangle: ");
                var input = Console.ReadLine();
                var a = validation.CheckInput(input);

                Console.Write("Please enter the Width of your triangle: ");
                var secondInput = Console.ReadLine();
                var b = validation.CheckInput(secondInput);

                Console.Write("Please enter the Height of your triangle: ");
                var thirdInput = Console.ReadLine();
                var c = validation.CheckInput(thirdInput);

                double p = (a * b * c) / 2.0;
                var result = Math.Sqrt(d: (p * (p - a)*(p - b)*(p - c)));

                Console.WriteLine($"Area of a triangle with sides {a}, {b}, {c}: {result:f} \n\n" +
                                  "\t\t\tPress any Button to continue");

                Console.ReadLine();
                MainMenu();
            }

            public void QuadraticEquation()
            {
                //step one, get the 
                
                Console.Write("Please enter first parameter 'a' : ");
                var input = Console.ReadLine();
                var a = validation.CheckInput(input);

                Console.Write("Please enter second parameter 'b' : ");
                var secondInput = Console.ReadLine();
                var b = validation.CheckInput(secondInput);

                Console.Write("Please enter third parameter 'c' : ");
                var thirdInput = Console.ReadLine();
                var c = validation.CheckInput(thirdInput);


            }
        }
    }
}
