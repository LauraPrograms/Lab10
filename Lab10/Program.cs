using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> circles = new List<int>();
            double radius = 0.0;
            bool run = true;
            while (run)
            {
                bool runRadius = true;
                while (runRadius)
                {

                    Console.WriteLine("Please enter a radius:");
                    
                    try
                    {
                        radius = double.Parse(Console.ReadLine());
                        if (radius > 0)
                        {
                            runRadius = false;
                        }
                        else if (radius <= 0)
                        {
                            Console.WriteLine("Please enter a number greater than 0");
                            runRadius = true;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("I did not understand. Enter a number instead.");
                        runRadius = true;
                    }
                }

                Circle c = new Circle(radius);

                Console.WriteLine("The circumference of your circle is " + c.CalcualteFormattedCircumference());
                Console.WriteLine("The area of your circle is " + c.CalculatedFormattedArea());

                run = Continue();

            }
            Console.WriteLine("Goodbye." +"\n"+"You created {0} circle objects.", Circle.circleCount);
        }
        public static bool Continue()
        {
            bool run;
            Console.WriteLine("Would you like to Continue (y/n): ");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "y")
            {
                run = true;
            }
            else if (userAnswer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry, I did not understand, please try again");
                return Continue();
            }
            return run;
        }
    }

}
