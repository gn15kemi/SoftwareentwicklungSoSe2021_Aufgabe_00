using System;

namespace aufgabe00_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //a) Arithmetische Operatoren
            //Definieren und initialisieren Sie folgende Variablen:

            int a = 1, b = 2, c = 3, r = 4;
            double y = 4.0, d , A, F, f;
           const double pi = 3.14159;

        //Definieren Sie des Weiteren noch fehlende Variablen, berechnen Sie die Ausdrücke und geben Sie die Ergebnisse aus.
        d = (double)a / b; f = (double)((a * b) / (c - y)) - (a / b); A = (double)(pi * (r * r));
            F = (double)(-b*(Math.Sqrt((b * b) - (4 * a * c)) ))/( 2 * a) ;

            Console.WriteLine("value of d is:{0} ", d);
            Console.WriteLine("value of A is:{0} " , A);
            Console.WriteLine("value of F is:{0} " , F);
            Console.WriteLine("value of f is:{0} " ,f);



        }
    }
}

