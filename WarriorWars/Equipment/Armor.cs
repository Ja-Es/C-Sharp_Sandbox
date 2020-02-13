using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        //fields
        private int protection;

        private const int VAR_PROTECTION = 3;
        private const int GOODGUY_PROTECTION = VAR_PROTECTION;
        private const int BADGUY_PROTECTION = VAR_PROTECTION;

        //properties
        public int Protection => protection;

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // constructor
        public Armor(Party party)
        {
            switch (party)
            {
                case Party.Resistance:
                    protection = GOODGUY_PROTECTION;
                    break;
                case Party.Stormtrooper:
                    protection = BADGUY_PROTECTION;
                    break;
                default:
                    break;
            }
        }
    }
}
