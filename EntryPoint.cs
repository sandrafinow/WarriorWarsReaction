using System;
using System.Threading;
using WarriorWarsRecreation.Enum;

namespace WarriorWarsRecreation
{
    class EntryPoint
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Ross", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5 )
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(1000);
            }
        }
    }
}
