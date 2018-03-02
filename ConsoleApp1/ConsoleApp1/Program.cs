using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = AskForName();

            if (name.ToLower().Trim() == "tobias")
            {
                Console.WriteLine("da du dieses Quiz geschrieben hast musst du es nicht spielen, sondern hast automatisch Gewonnen!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("du hast dich dazu entschieden dieses Quiz zu spielen.");
            Console.WriteLine("Beantworte alle Fragen richtig um zu gewinnen.");
            Console.ReadKey();
            while (true)
            {

                var bereit = ready();
                if (bereit.ToLower().Trim() != "ja")
                {
                    Console.Clear();
                    Console.WriteLine("Falsche Einstellung!");
                    Console.ReadKey();
                    return;
                }
                var sterne = Question1();
                if (sterne != 1)
                {
                    string againn = Failed();
                    if (againn == "ja")
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                    //break;
                    //continue;
                }
                Console.WriteLine("Richtig, das war noch recht einfach.");
                Console.ReadKey();
                var pluto = Question2();
                if (pluto.ToLower().Trim() != "russland")
                {
                    Failed();
                    return;
                }
                Console.WriteLine("Richtig! Das ist nicht dein erster Versuch, oder?");
                Console.ReadKey();
                var octopus = Question3();
                if (octopus != 3)
                {
                    Failed();
                    return;
                }
                Console.WriteLine("Richtig!");
                Console.Clear();
                Console.WriteLine("Glückwunsch " + name + ",");
                Console.WriteLine("du hast alle Fragen richtig beantwortet.");
                Console.WriteLine("Hat dir das Quiz gefallen?");
                string bewertung = Console.ReadLine();
                if (bewertung.ToLower().Trim() != "ja")
                {
                    Failed();
                    return;
                }
                Console.Clear();
                Console.WriteLine("schön");
                Console.WriteLine("Willst du nocheinmal anfangen?");
                string again = Console.ReadLine();
                if (again.ToLower().Trim() != "ja")
                {
                    Console.ReadKey();
                    return;
                }
                Console.ReadKey();
            }
        }
        private static int Question3()
        {
            Console.Clear();
            Console.WriteLine("Frage 3:");
            Console.WriteLine("Wieviele Herzen hat ein Oktopus?");
            int octopus = Convert.ToInt32(Console.ReadLine());
            return octopus;
        }
        private static string Question2()
        {
            Console.Clear();
            Console.WriteLine("Frage 2:");
            Console.WriteLine("Welches Land ist größer als der Pluto?");
            string pluto = Console.ReadLine();
            return pluto;
        }
        private static string ready()
        {
            Console.Clear();
            Console.WriteLine("Bist du bereit?");
            string bereit = Console.ReadLine();
            return bereit;
        }
        private static int Question1()
        {
            Console.Clear();
            Console.WriteLine("Frage 1:");
            Console.WriteLine("Wieviele Sterne hat unser Sonnensystem?");
            int sterne = Convert.ToInt32(Console.ReadLine());
            return sterne;
        }
        private static string Failed()
        {
            Console.Clear();
            Console.WriteLine("Falsch!");
            Console.WriteLine("Willst du es nochmal versuchen?");
            string againn = Console.ReadLine();
            Console.ReadKey();
            return againn;
        }
        private static string AskForName()
        {
            Console.WriteLine("Hallo, wie ist dein Name?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hallo " + name + ",");
            return name;
        }
    }
}