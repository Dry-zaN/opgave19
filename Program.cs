using System;

namespace opgave1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.Title = "Kredittjek.jpg.exe";
            Console.Write("Indtast din alder: ");
            input = Convert.ToInt32(Console.ReadLine());


            if (input < 18)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kredittjek afvist!\nMan skal være minimum 18 år, du indtastede: {0}", input);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);
            }
            else if (input >= 18)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du er blevet godkendt!\nSom {0} årig er der kun 2000% renter per måned", input);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Environment.Exit(0);

            }
        }
    }
}