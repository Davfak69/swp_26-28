
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bitte geben Sie einen Wert ein: ");
        string eingabe = Console.ReadLine();

        Console.WriteLine(ErmittleDatentyp(eingabe));
    }
    static string ErmittleDatentyp(string eingabe)
    {
        if (int.TryParse(eingabe, out int _))
            return "Die Eingabe ist ein Integer.";

        if (bool.TryParse(eingabe, out bool _))
            return "Die Eingabe ist ein Bool.";

        if (double.TryParse(eingabe, out double _))
            return "Die Eingabe ist eine rationale Zahl.";

        return "Die Eingabe ist ein String.";
    }
}
