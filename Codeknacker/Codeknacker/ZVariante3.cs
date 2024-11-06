using System;
using System.Diagnostics;
using System.Text;

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

            string number1 = CreateRandomNumberString(numbersize);
            string number2 = CreateRandomNumberString(numbersize);

            NumberResult result = CompareNumber(number1, number2);


            switch (result) 
            {
                case NumberResult.num1:
                    Console.WriteLine(">> Nummer 1 Größer <<\n");
                    break;
                case NumberResult.num2:
                    Console.WriteLine(">> Nummer 2 Größer <<\n");
                    break;
                case NumberResult.same:
                    Console.WriteLine(">> Beide gleich <<\n");
                    break;
            }
        }

        public static NumberResult CompareNumber(string num1, string num2)
        {
            //nicht gleiche länge = der längere string ist grßer
            if (num1.Length > num2.Length)
                return NumberResult.num1;
            if (num1.Length < num2.Length)
                return NumberResult.num2;

            //Wenn die länge gleich = jede zahl einzelend vergleichen
            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine($"Num1 num:{num1[i]} | Num2 num:{num2[i]}");

                if (num1[i] > num2[i])
                    return NumberResult.num1;
                if (num1[i] < num2[i])
                    return NumberResult.num2;
            }

            // Zahlen sind gleich
            return NumberResult.same;
        }
        private static string CreateRandomNumberString(int length)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                sb.Append(random.Next(0, 10));
            }

            return sb.ToString().TrimStart('0');
        }

        public enum NumberResult
        {
            num1,
            num2,
            same
        }
    }
}
