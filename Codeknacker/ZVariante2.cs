using System;

namespace Codeknacker
{
    public static class ZVariante2
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=================================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">> Variante Zusatz 2 <<\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Dies gehört nicht zum Normalen Codeknacker Programm!");
            
            
            //Zufallszahlen von 0 bis 100.000.000.000
            
            //meherere Zufallszahlen bei denen das maximum zusammengerechnet wird 100.000.000.000 ergibt
            
            //1.000.000 max und 10.000 generierungen

            long min = 0;
            long max = 100_000_000_000; // Beispiel für einen größeren Zahlenbereich
            int anzahl = 200; // Anzahl der zu generierenden Zufallszahlen

            Random random = new Random();
            long[] zufallszahlen = new long[anzahl];

            for (int i = 0; i < anzahl; i++)
            {
                // Generierung einer Zufallszahl im Bereich von min bis max
                zufallszahlen[i] = (long)(random.NextDouble() * (max - min)) + min;
            }

            // Ausgabe der Zufallszahlen
            Console.WriteLine("Generierte Zufallszahlen:");
            foreach (var zahl in zufallszahlen)
            {
                Console.WriteLine(zahl);
            }
            
            //Die Zahlen sind haupsächlich im Bereich von größer als 20.000.000.000
        }
    }
}
