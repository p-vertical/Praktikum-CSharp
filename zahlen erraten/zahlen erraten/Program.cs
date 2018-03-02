using System;
namespace zahlen_erraten
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int zahl = rnd.Next(1, 101);
            Console.WriteLine("Errate eine zufällige Zahl zwischen 1 und 100. Das Programm wird dir sagen ob deine Zahl zu groß oder zu klein ist.");
            Console.WriteLine("Gib eine Zahl zwischen 1 und 100 ein.");
            int versuche = 1;
            int guess = Convert.ToInt32(Console.ReadLine());
            while (guess > 0)
            {
                if (guess < zahl)
                {
                    Console.WriteLine("Zu klein. Die gesuchte Zahl ist größer.");
                    Console.WriteLine("Gib eine weitere Zahl an.");
                }
                if (guess > zahl)
                {
                    Console.WriteLine("Zu Groß. Die gesuchte Zahl ist kleiner.");
                    Console.WriteLine("Gib eine weitere Zahl an.");
                }
                if (guess == zahl)
                {
                    Console.WriteLine("Richtig! Die gesuchte Zahl lautet " + zahl + ".");
                    Console.WriteLine("Du hast " + versuche + " Versuch(e) gebraucht.");
                    Console.WriteLine("Willst du nocheinmal spielen?");
                    string nochmal = Console.ReadLine();
                    if (nochmal != "ja")
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        zahl = rnd.Next(1, 101);
                        Console.WriteLine("Gib eine Zahl zwischen 1 und 100 ein.");
                        versuche = 0;
                    }
                }
                guess = Convert.ToInt32(Console.ReadLine());
                versuche++;
            }
            Console.ReadKey();
        }
    }
}