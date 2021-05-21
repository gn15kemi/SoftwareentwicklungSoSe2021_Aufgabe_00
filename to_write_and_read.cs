using System;

namespace exercise1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 

           // 1. Initialisierung der Variablen
            string bezeichnung = "leVieux";
            int registrierNummer = 12345;
            char kategorie = 'A';
            double leuchtkraft = 22.22D;

            //2. Lesen Sie die Werte von der Kommandozeile ein.
           /* Console.WriteLiffne(bezeichnung);
            Console.WriteLine(registrierNummer);
            Console.WriteLine(kategorie);
            Console.WriteLine(leuchtkraft);  */

            //3.Geben Sie die Werte von Tastatur ein ... ... und geben Sie diese anschließend aus.
            Console.WriteLine("Geben Sie die Bezeichnung ein");
            bezeichnung = Console.ReadLine();
            Console.WriteLine("bezeichnung = "+ bezeichnung );

            Console.WriteLine("Geben Sie die Registriernummer ein");
            registrierNummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bezeichnung = " + registrierNummer);

            Console.WriteLine("Geben Sie die Kategorie ein");
           // kategorie =Console.ReadLine()[0];
            kategorie = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("bezeichnung = " + kategorie);

            Console.WriteLine("Geben Sie die Leuchtkraft ein");
            leuchtkraft = Convert.ToDouble(Console.ReadLine());
            //double wert = Convert.ToDouble(string, culture_specification);
            Console.WriteLine("Leuchtkraft = " + leuchtkraft);
               

        }
    }
}