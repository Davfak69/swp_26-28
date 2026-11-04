
using System;
using System.Numerics;

Console.Write("Bitte geben Sie eine Zahl oder Zeichenkette ein: ");
string eingabe = Console.ReadLine() ?? "";

if (int.TryParse(eingabe, out int zahl))
{
    Console.WriteLine("Welche mathematische Operation möchten Sie ausführen?");
    Console.WriteLine("1) Addition");
    Console.WriteLine("2) Multiplikation");
    Console.WriteLine("3) Division");
    Console.WriteLine("4) Fakultät");
    Console.WriteLine("5) Wurzelziehen");
    Console.Write("Ihre Auswahl: ");

    if (!int.TryParse(Console.ReadLine(), out int operation)
        || operation < 1 || operation > 5)
    {
        Console.WriteLine("Ungültige Auswahl!");
        return;
    }

    switch (operation)
    {
        case 1:
            Console.Write("Geben Sie die zweite Zahl ein: ");

            if (double.TryParse(Console.ReadLine(), out double addZahl))
                Console.WriteLine($"Ergebnis: {zahl + addZahl}");
            else
                Console.WriteLine("Ungültige Zahl!");

            break;

        case 2:
            Console.Write("Geben Sie die zweite Zahl ein: ");

            if (double.TryParse(Console.ReadLine(), out double malZahl))
                Console.WriteLine($"Ergebnis: {zahl * malZahl}");
            else
                Console.WriteLine("Ungültige Zahl!");

            break;

        case 3:
            Console.Write("Geben Sie die zweite Zahl ein: ");

            if (!double.TryParse(Console.ReadLine(), out double divZahl))
            {
                Console.WriteLine("Ungültige Zahl!");
            }
            else if (divZahl == 0)
            {
                Console.WriteLine("Division durch 0 ist nicht erlaubt!");
            }
            else
            {
                Console.WriteLine($"Ergebnis: {zahl / divZahl}");
            }

            break;

        case 4:
            if (zahl < 0)
            {
                Console.WriteLine("Die Fakultät ist nur für nichtnegative ganze Zahlen definiert.");
            }
            else
            {
                BigInteger fakultaet = 1;

                for (int i = 1; i <= zahl; i++)
                {
                    fakultaet *= i;
                }

                Console.WriteLine($"Ergebnis: {fakultaet}");
            }

            break;

        case 5:
            if (zahl < 0)
            {
                Console.WriteLine("Die Wurzel einer negativen Zahl ist keine reelle Zahl.");
            }
            else
            {
                Console.WriteLine($"Ergebnis: {Math.Sqrt(zahl)}");
            }

            break;
    }
}
else
{
    Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
    Console.WriteLine("1) Alle Selbstlaute (a,e,i,o,u) entfernen");
    Console.WriteLine("2) Die Zeichenkette umdrehen");
    Console.WriteLine("3) Die Anzahl an Zeichen ausgeben");
    Console.Write("Ihre Auswahl: ");

    if (!int.TryParse(Console.ReadLine(), out int textOperation)
        || textOperation < 1 || textOperation > 3)
    {
        Console.WriteLine("Ungültige Auswahl!");
        return;
    }

    switch (textOperation)
    {
        case 1:
            string ohneSelbstlaute = "";

            foreach (char zeichen in eingabe)
            {
                if ("aeiouAEIOU".IndexOf(zeichen) == -1)
                {
                    ohneSelbstlaute += zeichen;
                }
            }

            Console.WriteLine($"Ergebnis: {ohneSelbstlaute}");
            break;

        case 2:
            char[] zeichenArray = eingabe.ToCharArray();
            Array.Reverse(zeichenArray);

            string umgedreht = new string(zeichenArray);

            Console.WriteLine($"Ergebnis: {umgedreht}");
            break;

        case 3:
            Console.WriteLine($"Anzahl der Zeichen: {eingabe.Length}");
            break;
    }
}
