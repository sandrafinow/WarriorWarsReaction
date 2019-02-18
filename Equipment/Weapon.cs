using WarriorWarsRecreation.Enum;

namespace WarriorWarsRecreation.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 10;
        private const int BAD_GUY_DAMAGE = 9;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }


        public Weapon (Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
            }
        }

    }
}