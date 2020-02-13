using System;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        // fields
        public readonly string name;
        private int health;
        private bool alive = true;

        private Weapon weapon;
        private Armor armor;

        private readonly Party PARTY;

        private const int VAR_HEALTH = 20;
        private const int GOODGUY_STARTING_HEALT = VAR_HEALTH;
        private const int BADGUY_STARTING_HEALT = VAR_HEALTH;


        private int reaction;
        private ConsoleColor winnercolor;
        private ConsoleColor loosercolor;

        // properties
        public bool Alive => alive;

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // constructor
        public Warrior(string warriorName, Party party)
        {
            this.name = warriorName;
            this.PARTY = party;

            switch (party)
            {
                case Party.Resistance:
                    weapon = new Weapon(party);
                    armor = new Armor(party);
                    health = GOODGUY_STARTING_HEALT;
                    break;
                //case Party.Jedi:
                //    weapon = new Weapon();
                //    armor = new Armor();
                //    health = goodguyStartingHealth;
                //    break;
                case Party.Stormtrooper:
                    weapon = new Weapon(party);
                    armor = new Armor(party);
                    health = BADGUY_STARTING_HEALT;
                    break;
                default:
                    break;
            }

        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // methods

        public void Attack(Warrior opponent)
        {
            Random random = new Random();
            int actualDamage = random.Next(3,weapon.Damage) / opponent.armor.Protection;
            int health_preAttack = opponent.health;
            opponent.health = opponent.health - actualDamage;


            Console.WriteLine($"{name} attacked {opponent.name}");
            Console.WriteLine($"{opponent.name}'s health dropped from {health_preAttack} to {opponent.health}");
            Console.WriteLine("---------------------------------------------");
            if (opponent.health <= 0)
            {
                opponent.alive = false;

                reaction = (opponent.PARTY == Party.Resistance) ? 1 : 2; // if bad guy wins = 1, if ggod guy wins = 2

                if (reaction == 1)
                {
                    winnercolor = ConsoleColor.Yellow;
                    loosercolor = ConsoleColor.Red;
                    Console.WriteLine("BOOOOH!!!", Console.ForegroundColor = ConsoleColor.Red);
                }
                else
                {
                    winnercolor = ConsoleColor.Green;
                    loosercolor = ConsoleColor.Red;
                    Console.WriteLine("HURRAY!!!", Console.ForegroundColor = ConsoleColor.Green);
                }
                Console.WriteLine($"{opponent.name} is knocked out!", Console.ForegroundColor = winnercolor);
                Console.WriteLine($"{name} is victorious!", Console.ForegroundColor = loosercolor);
                Console.ResetColor();
            }

        }

    }
}
