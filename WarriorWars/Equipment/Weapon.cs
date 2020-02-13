using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        //fields
        private int damage;

        private const int VAR_DAMAGE = 10;
        private const int GOODGUY_DAMAGE = VAR_DAMAGE;
        private const int BADGUY_DAMAGE = VAR_DAMAGE;

        //properties
        public int Damage => damage;

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // constructor
        public Weapon(Party party)
        {
            switch (party)
            {
                case Party.Resistance:
                    damage = GOODGUY_DAMAGE;
                    break;
                case Party.Stormtrooper:
                    damage = BADGUY_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}
