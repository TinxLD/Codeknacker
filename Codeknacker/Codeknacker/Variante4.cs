using System;

namespace Codeknacker
{
    public static class Variante4
    {
        //Die "Zufalls" nummer
        static int secretNumber = 4;

        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=================================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">> Variante 4 <<\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In dieser Variante habe ich eine Zahl abgespeichert, die der Benutzer (Du) erraten muss.");
            Console.WriteLine("Schreibe mir diese hier rein!\n");
            Console.WriteLine("Aber pass auf! Ich speicher ab wie oft du geraten hast!");

            Console.WriteLine("Ich sage ob diese ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Richtig");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" oder ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Falsch");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ist! \nAber gebe dir auch noch Tipps!\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">> ");

            //Check ob die erratene nummer richtig ist
            bool isRight = false;

            //Nummer für die versuche
            int tries = 0;

            while (!isRight)
            {
                //Wandelt den eingegeben Text in eine Zahl um
                int.TryParse(Console.ReadLine(), out int userNumber);

                tries++; //fügt tries 1-nen hinzu+

                //Überprüft ob die angegeben nummer die richtige ist
                if (userNumber == secretNumber)
                {
                    //Falls das so ist wird der Loop unterbrochen
                    isRight = true;
                    break;
                }

                //Check ob es richtig erraten wurde (Sollte immer der fall sein (siehe oben))
                if (!isRight)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Deine Nummer ist: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsch");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Hier dein Tipp: ");

                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    //2 Checks um zu überprüfen ob die Zahl zu groß oder klein ist
                    if (userNumber > secretNumber)
                        Console.WriteLine("Zu GROß");

                    if(userNumber < secretNumber)
                        Console.WriteLine("Zu KLEIN");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bitte gebe eine neue Nummer ein");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(">>");
                }
            }

            //Check ob es richtig erraten wurde (Sollte es eigentlich immer)
            if (isRight)
            {
                //Schreibe das Ergebniss
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nDeine Nummer ist: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Richtig");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Du hast {tries} Versuche gebraucht");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Danke für deine Teilnahme!");
            }
        }
    }
}
