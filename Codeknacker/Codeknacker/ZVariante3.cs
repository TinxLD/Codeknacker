using System;
using System.Diagnostics;

namespace Codeknacker
{
    public static class ZVariante3
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=================================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">> Variante Zusatz 3 <<\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Vergleich 2 Große Zahlen mit Strings");

            int numbersize = 20000;

            string number1 = "123456789";
            string number2 = "888888888";

            numberResult result = CompareNumber(number1, number2);


            switch (result) 
            {
                case numberResult.num1:
                    Console.WriteLine(">> Nummer 1 Größer <<\n");
                    break;
                case numberResult.num2:
                    Console.WriteLine(">> Nummer 2 Größer <<\n");
                    break;
                case numberResult.same:
                    Console.WriteLine(">> Beide gleich <<\n");
                    break;
            }
        }

        public static numberResult CompareNumber(string num1, string num2)
        {
            //nicht gleiche länge = der längere string ist grßer
            if (num1.Length > num2.Length)
                return numberResult.num1;
            if (num1.Length < num2.Length)
                return numberResult.num2;

            //Wenn die länge gleich = jede zahl einzelend vergleichen
            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine($"Num1 num:{num1[i]} | Num2 num:{num2[i]}");

                if (num1[i] > num2[i])
                    return numberResult.num1;
                if (num1[i] < num2[i])
                    return numberResult.num2;
            }

            // Zahlen sind gleich
            return numberResult.same;
        }

        public enum numberResult
        {
            num1,
            num2,
            same
        }
    }
}