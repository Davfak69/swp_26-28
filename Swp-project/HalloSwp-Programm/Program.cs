using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie eine natuerliche Zahl ein: ");

        if (!int.TryParse(Console.ReadLine(), out int zahl) || zahl < 1)
        {
            Console.WriteLine("Ungueltige Eingabe! Bitte eine natuerliche Zahl eingeben.");
            return;
        }

        Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein,");
        Console.WriteLine("um eine mathematische Operation auszuwaehlen:");
        Console.WriteLine("1) Quadrat");
        Console.WriteLine("2) Wurzel");
        Console.WriteLine("3) Fakultaet");

        Console.Write("Ihre Auswahl: ");

        if (!int.TryParse(Console.ReadLine(), out int operation)
            || operation < 1 || operation > 3)
        {
            Console.WriteLine("Ungueltige Auswahl!");
            return;
        }

        switch (operation)
        {
            case 1:
                Console.WriteLine($"Quadrat: {(double)zahl * zahl}");
                break;

            case 2:
                Console.WriteLine($"Wurzel: {Math.Sqrt(zahl)}");
                break;

            case 3:
                BigInteger fakultaet = 1;

                for (int i = 1; i <= zahl; i++)
                {
                    fakultaet *= i;
                }

                Console.WriteLine($"Fakultaet: {fakultaet}");
                break;
        }
    }
}
