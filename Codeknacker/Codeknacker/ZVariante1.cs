using System;


namespace Codeknacker
{
    public static class ZVariante1
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=================================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">> Variante Zusatz 1 <<\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In dieser Variante gibst du die Zufallszahl an und der Computer muss diese erraten.");

            Console.WriteLine("Gebe eine Zufallszahl an, die der Computer erraten soll!");
            int secretNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Gebe das Minimum der Zahlen an von denen Geraten wird! z.B = 10");
            int min = int.Parse(Console.ReadLine());


            Console.WriteLine($"Gebe das Maximum der Zahlen an von denen Geraten wird! z.B = 100 (Diese MUSS größer sein als das Minimum: > {min})");
            int max = int.Parse(Console.ReadLine());

            Random random = new Random();

            if(min > max || min > secretNumber || max < secretNumber || min == max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du hast einen Fehler gemacht bitte versuche es erneut!");
                return;
            }   
            
            
            int computernumber = random.Next(min, max + 1);

            int newmin = min;
            int newmax = max;

            while (computernumber != secretNumber)
            {
                Console.WriteLine($"Der Computer sagt: {computernumber}");
                Console.WriteLine("Geben an ob diese zu Groß oder zu Klein ist");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Schreibe 'G' für zu Groß und 'K' für zu klein");
                Console.WriteLine($"Tipp: Deine Nummer war: {secretNumber}");
                Console.ForegroundColor = ConsoleColor.White;

                string userinput = Console.ReadLine();


                if (userinput == "G" || userinput == "g")
                {
                    newmax = computernumber;
                    computernumber = (computernumber + newmin) / 2;
                }
                else if(userinput == "K" || userinput == "k")
                {
                    newmin = computernumber;
                    computernumber = (computernumber + newmax) / 2;
                }

                Console.WriteLine($"Max:{newmax} Min:{newmin}");
            }


            if(computernumber == secretNumber)
            {
                //Schreibe das Ergebniss
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nDer Computer hat es geschafft! ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Die Zahl war: {computernumber}");
            }
        }
    }
}
