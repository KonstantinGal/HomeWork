using System;
using System.Threading;

namespace HomeWork
{
    public class Validation
    {
        public double CheckInput(string input)
        {
            if (!double.TryParse(input, out var number))
            {
                Console.WriteLine("Try a number this time... please");
                Console.ReadLine();


                Program.MainMenu();
            }

            else if (Convert.ToInt32(number) == 0)
            {
                Console.WriteLine("it's very tiny object you have there... lets start again...\n\n\n");
                Console.ReadLine();

                Program.MainMenu();
            }
            else if (Convert.ToInt32(number) < 0)
            {
                Console.WriteLine("Imagine a Cube with a side length of negative value... ");
                Thread.Sleep(3000);

                Console.WriteLine("Yeah, doesn't make sense... let's try again\n\n\n");
                Console.ReadLine();

                Program.MainMenu();
            }

            return number;

        }
    }
}
