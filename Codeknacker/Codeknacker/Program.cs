using System;

namespace Codeknacker
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Title();
                
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("=================================================================================");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(">> Willkommen zu Codeknacker! <<\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Wähle eine Variante aus, die du ausführen möchtest.");
                Console.WriteLine("Gebe '0' ein, um eine Liste aller Varianten anzuzeigen.");
                Console.WriteLine("Beispiel: Schreibe '5' und drücke Enter, um Variante 5 zu starten.");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n>> Eingabe: ");
                int.TryParse(Console.ReadLine(), out int result);
                
                Console.Clear();
                Title();
                
                switch (result)
                {
                    case 0:
                        Variants();
                        break;
                    case 1:
                    case 2:
                    case 3:
                        Variante3.Run();
                        break;
                    case 4:
                        Variante4.Run();
                        break;
                    case 5:
                        Variante5.Run();
                        break;
                    case 6:
                        Variante6.Run();
                        break;
                    case 7:
                        Variante7.Run();
                        break;
                    case 8:
                    case 9:
                        Variante8.Run();
                        break;
                    case 10:
                        ZVariante1.Run();
                        break;
                    case 11:
                        ZVariante2.Run();
                        break;
                    case 12:
                        ZVariante3.Run();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[!] Ungültige Eingabe. Bitte eine Zahl zwischen 0 und 10 eingeben.");
                        break;
                        
                }

                // Abschließende linie und Wiederholung
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("=================================================================================");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n[!] Drücke Enter, um das Programm erneut zu starten.");
                Console.ReadLine();
            }
        }


        private static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
               ___               _             _                               _                     
              / __|    ___    __| |    ___    | |__   _ _     __ _     __     | |__    ___      _ _  
             | (__    / _ \  / _` |   / -_)   | / /  | ' \   / _` |   / _|    | / /   / -_)    | '_| 
              \___|   \___/  \__,_|   \___|   |_\_\  |_||_|  \__,_|   \__|_   |_\_\   \___|   _|_|_  
            _|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""|_|""""""| 
            ""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-'""`-0-0-' 
            ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void Variants()
        { 
            string result = "0          -> Liste aller Varianten anzeigen\n" +
                            "1, 2, 3    -> Variante 3\n" +
                            "4          -> Variante 4\n" +
                            "5          -> Variante 5\n" +
                            "6          -> Variante 6\n" +
                            "7          -> Variante 7\n" +
                            "8, 9       -> Variante 9\n" +
                            "10         -> Variante Z1" +
                            "11         -> Variante Z2 (Special)\n" +
                            "12         -> Variante Z3 (Special)";
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=================================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
