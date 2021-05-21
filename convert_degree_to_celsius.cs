using System;
using System.Globalization;

namespace aufgabe00_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius, fahrenheit;
            celsius = 5;
            fahrenheit = ((9 * celsius) / 5) + 32;
            Console.WriteLine("{0} Celsius entspricht {1} Fahrenheit", celsius, fahrenheit);
            Console.WriteLine("Celsius: ");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = ((9 * celsius) / 5) + 32;
            Console.WriteLine("Fahrenheit:{0} ", fahrenheit);
        }
    }
}