using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempCon
{
    public static class TempCon
    {
        public static double CelToFah(string tempCel)
        {
            double cel = double.Parse(tempCel);
            double fah = (cel * 9 / 5) + 32;
            return fah;
        }

        public static double FahToCel(string tempFah)
        {
            double fah = double.Parse(tempFah);
            double cel = (fah - 32) * 5/9;
            return cel;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please select your option (Enter 1 or 2)");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");
            Console.WriteLine();

            string choice = Console.ReadLine();
            double F, C;

            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("Please enter the Celsius temperature: ");
                    F = CelToFah(Console.ReadLine());
                    Console.WriteLine("Temperature is Fahrenheit is {0:f}", F);
                    break;

                case "2":
                    Console.WriteLine();
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    C = FahToCel(Console.ReadLine());
                    Console.WriteLine("Temperature is Celsius is {0:f}", C);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();
        }
    }
}
