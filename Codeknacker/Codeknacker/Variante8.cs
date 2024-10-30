using System;

namespace Codeknacker
{
    public static class Variante8
    {
        //Der Zufallsgenerator
        static Random random = new Random();

        //Die "Zufalls" nummer
        static int secretNumber;

        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=================================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">> Variante 8 <<\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In dieser Variante wird eine Zufallszahl generiert, die der Benutzer (Du) erraten muss. Zwischern 1000 und 10000");
            Console.WriteLine("Schreibe mir diese hier rein!\n");

            Console.WriteLine("Aber pass auf! Ich speicher ab wie oft du geraten hast!");

            //Schreibt eine Text in unterschiedlichen Farben
            Console.WriteLine("Ich sage ob diese ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Richtig");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" oder ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Falsch");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ist! \nAber gebe dir auch noch Tipps!\n");


            Console.WriteLine($"Anzahl guter Versuche {TryGoodNumber(1000, 10001)}, liegst du unter dieser Nummer oder genau drauf warst du GUT!");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">> ");

            secretNumber = random.Next(1000, 10001);

            //Check ob die erratene nummer richtig ist
            bool isRight = false;

            //Nummer für die versuche
            int tries = 0;

            while (!isRight)
            {
                //Wandelt den eingegeben Text in eine Zahl um
                int userNumber = int.Parse(Console.ReadLine());

                tries++; //fügt tries 1-nen hinzu

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
                    Console.Write(">> ");
                }
            }

            //Check ob es richtig erraten wurde
            if (isRight)
            {
                //Schreibe das Ergebniss
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nDeine Nummer ist: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Richtig");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Du hast {tries} Versuche gebraucht");

                bool good = TryGood(1000, 10001, tries);

                if (!good)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\nDu hast mehr Versuche gebraucht als du Solltest!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Gebe nicht auf du schaffst das!");
                }
                else if(tries == TryGoodNumber(1000, 10001))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\nDu liegst genau drauf also genau im durchschnitt!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Nice!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\nDu hast wenige Versuche gebraucht! Super!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Mach doch noch mal!");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Danke für deine Teilnahme!");
            }
        }

        public static bool TryGood(int minNum, int maxNum, int tries)
        {
            int maxforgood = TryGoodNumber(minNum, maxNum);

            if( maxforgood <= tries )
                return false;
            else
                return true;
                
        }
        public static int TryGoodNumber(int minNum, int maxNum)
        {
            int numbercount = maxNum - minNum;
            int maxforgood = 0;

            while (numbercount > 1)
            {
                numbercount = numbercount /= 2;
                maxforgood++;
            }

            return maxforgood;
        }
    }
}

