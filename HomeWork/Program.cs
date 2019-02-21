using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.ConsoleKey;

namespace HomeWork
{

    partial class Program
    {

        private static void Main(string[] args)
        {
            var validation = new Validation();

            Console.WriteLine("\n\n\n\t\t\t Hello, sir \n\n\n");
            Thread.Sleep(2000);

            MainMenu();

            Console.WriteLine("bye bye...\n\n");
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tWelcome to the Main Menu\n\n" +
                              "Pick an option or press ESC to exit\n\n" +
                              "Calculate Circumference and Area of a circle:  Press 1\n" +
                              "Calculate Volume of a Hemisphere:              Press 2\n" +
                              "Calculate Area of a triangle:                  Press 3\n" +
                              "To solve a quadratic equation:                 Press 4 \n\n");

            var input = Console.ReadKey(true);
            var math = new MathFormulas();
            var quadraticEq = new QuadraticEquation();


            switch (input.Key)
            {
                case Escape:
                    Console.WriteLine("bye bye...");
                    Console.Clear();
                    throw new Exception("I Forgot how to stop console application, so i'll just throw an exception...");
                case D1:
                    math.Circumference();
                    break;
                case D2:
                    math.Volume();
                    break;
                case D3:
                    math.AreaOfTriangle();
                    break;
                case D4:
                    Console.WriteLine(quadraticEq.QudraticEq());
                    Console.ReadLine();
                    MainMenu();
                    break;
                default:
                    MainMenu();
                    break;
            }
        }
}
}
