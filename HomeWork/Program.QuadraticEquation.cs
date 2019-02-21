using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace HomeWork
{

    partial class Program
    {
        public class QuadraticEquation
        {
            public string QudraticEq()
            {
                //Step 1 - receive the parameters
                Console.Write("Enter parameter 'a': ");
                var input = Console.ReadLine();
                var paramA = EnterAndValidate(input);

                if (paramA == null) new QuadraticEquation().QudraticEq();
                //Check the return parameter, return to the main menu if null
                else if (int.Parse(paramA) == 0)
                {
                    Console.WriteLine("It's not a quadratic equation if parameter 'a' is 0 ");
                    MainMenu();
                }

                int a = Convert.ToInt32(paramA);

                Console.Write("Enter parameter 'b': ");
                var secondInput = Console.ReadLine();
                var paramB = EnterAndValidate(secondInput);
                if (paramB == null) new QuadraticEquation().QudraticEq();

                int b = Convert.ToInt32(paramB); 


                Console.Write("Enter parameter 'c': ");
                var ThirdInput = Console.ReadLine();
                var paramC = EnterAndValidate(ThirdInput);
                if (paramC == null) new QuadraticEquation().QudraticEq();

                int c = Convert.ToInt32(paramC);

                /*Step 2 - Evaluate the possible solutions
                        We need to calculate (b^2 - 4ac) portion 
                        of the quadratic formula. If the result > 0
                        the problem has 2 real answers, if == 0,
                        then 1 real answer, if < 0, then 2 Complex answers */

                var rootResult = b * b - 4 * a * c;

                if (rootResult > 0)
                {
                    var twoNormalSolutions = TwoNormalSolutions(rootResult, a, b, c);
                    return twoNormalSolutions;
                } 

                else if (rootResult < 0)
                {
                    var complexResults = ComplexSolutions(rootResult, a, b, c);
                    return complexResults;
                }

                return $"The result of this equation is x = {(-b) / (2 * a)}";
            }

            private string EnterAndValidate(string input) //Requires an input, ensures it's within parameters
            {
                try
                {
                    var target = Convert.ToInt32(input);
                    return input;
                }
                catch 
                {
                    Console.WriteLine("Invalid input, try again... ");
                    Console.ReadLine();
                    return null;
                    //I could have thrown an exception, but to keep the console running, returning null
                }
                
            }

            private string TwoNormalSolutions(double rootResult, int a, int b, int c)
            {
                var firstX = ((-b) + Math.Sqrt(rootResult)) / (2.0 * a);
                var secondX = ((-b) - Math.Sqrt(Math.Abs(rootResult))) / (2.0 * a);
                return $"The results of this equation are: x = {firstX} and x = {secondX}";
            }

            private string ComplexSolutions(double rootResult, int a, int b, int c)
            {
                var firstX = $"{- (b / (2.0 * a)):F} + {(char)0x221A} {(-rootResult)}i /{2.0 * a}";
                var secondX = $"{- (b / (2.0 * a)):F} - {(char)0x221A} {(-rootResult)}i /{2.0 * a}";
                return $"The answers For this equations are {firstX} and {secondX}";

            }
        }
    }
}
