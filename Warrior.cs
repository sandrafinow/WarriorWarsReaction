using WarriorWarsRecreation.Enum;
using WarriorWarsRecreation.Equipment;
using System;

namespace WarriorWarsRecreation
{
    class Warrior
    {

        private const int GOOD_GUY_START_HEALTH = 20;
        private const int BAD_GUY_START_HEALTH = 20;

        private readonly Faction faction;

        private string name;
        private int health;
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;


        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public Warrior (string name, Faction faction)
        {
            this.name = name;
            this.faction = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_START_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_START_HEALTH;
                    break;
            }
        }

        public void Attack (Warrior opponent)
        {
            int attackDamage = weapon.Damage - opponent.armor.ArmorPoints;

            opponent.health = opponent.health - attackDamage;

            AttackResult(opponent, attackDamage);
        }

        public void AttackResult (Warrior opponent, int damage)
        {
            if (opponent.health <= 0)
            {
                opponent.isAlive = false;

                Misc.ColouredWriteLine($"{opponent.name} is dead!", ConsoleColor.Red);
                Misc.ColouredWriteLine($"{name} is victorious!!", ConsoleColor.Green);
            }
            else
            {

                Console.WriteLine($"{name} attacked {opponent.name} for {damage}.\n" +
                    $"{name} current health: {health}\n" +
                    $"{ opponent.name} current health: {opponent.health}\n" +
                    new string('-', 40) + "\n");
            }
        }
    }
}
