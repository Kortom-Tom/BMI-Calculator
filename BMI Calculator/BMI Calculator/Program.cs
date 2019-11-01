using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight in kg:");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height in M:");
            double m = Convert.ToDouble(Console.ReadLine());

            double BMI = kg / (m * m);
            Console.WriteLine("Your BMI is " + Math.Round(BMI, 2));
            Console.ReadKey();
        }
    }
}
