using System;
using System.Threading;

namespace WarriorWars
{
    class Program
    {
        // fields
        static readonly Random myrandom = new Random();
        
        static void Main()
        {
            Warrior warrior1 = readInName(Enum.Party.Stormtrooper);
            Warrior warrior2 = readInName(Enum.Party.Resistance);

            Thread.Sleep(1000);
            Console.WriteLine("Let the fight begin!");
            Console.WriteLine(" ");
            Thread.Sleep(1000);

            while (warrior1.Alive && warrior2.Alive)
            {
                if (myrandom.Next(0, 10) < 5)
                {
                    warrior1.Attack(warrior2);
                }
                else
                {
                    warrior2.Attack(warrior1);
                }

                Thread.Sleep(200);
            }
        }

        static Warrior readInName(Enum.Party party)
        {
            string ConsoleName;

            if (party == Enum.Party.Stormtrooper)
            {
                Console.WriteLine("Enter the name of warrior 1 (a Stormtrooper). If no name is given, it will be 'Stormtrooper 48679'");
                ConsoleName = Console.ReadLine();
                ConsoleName = (ConsoleName == "") ? "Stormtrooper 48679" : ConsoleName;
                Warrior int_warrior = new Warrior(ConsoleName, Enum.Party.Stormtrooper);
                Console.WriteLine($"{int_warrior.name} created.");
                return int_warrior;

            }
            else
            {
                Console.WriteLine("Enter the name of warrior 2 (from the restistance). If no name is given, it will be 'Princess Leia'");
                ConsoleName = Console.ReadLine();
                ConsoleName = (ConsoleName == "") ? "Princess Leia" : ConsoleName;
                Warrior int_warrior = new Warrior(ConsoleName, Enum.Party.Resistance);
                Console.WriteLine($"{int_warrior.name} created.");
                return int_warrior;
            }

        }
    }
}
