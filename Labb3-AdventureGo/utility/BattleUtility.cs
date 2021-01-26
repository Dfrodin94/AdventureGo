using Labb3_AdventureGo.monsters;
using System;

namespace Labb3_AdventureGo.utility
{
    internal static class BattleUtility
    {
        public static bool AdventureChance() // klar och fin!
        {
            Random random = new Random();

            int randomNbr = random.Next(1, 10);

            if (randomNbr == 1)
            {
                Console.WriteLine("You see nothing but swaying grass all around you...");
                Console.WriteLine("[Press enter to continue]");
                Console.ReadLine();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Battle(Player player, SpecificMonster monster)
        {
            bool keepGoing = true;
            Console.WriteLine($"Uh oh! A {monster.Name} appeared!");

            while (keepGoing)
            {
                Console.WriteLine($"You hit the monster, dealing {monster.TakeDmg(player.Attack())} damage");
                Console.WriteLine("Uuoooah *slurp*");
                Console.WriteLine($"The monster hits you, dealing {player.TakeDmg(monster.Attack())} damage");

                // player.Attack(player, monster);
                //monster.Attack(player, monster);
                keepGoing = BattleWinner(player, monster, keepGoing);

                if (keepGoing)
                {
                    Console.WriteLine($"{player.Name} has: {player.Hp} hp left");
                    Console.WriteLine($"{monster.Name} has: {monster.Hp} hp left");
                    Console.WriteLine("[press enter to continue]");
                    Console.ReadLine();
                }
            }
        }

        public static bool BattleWinner(Player player, SpecificMonster monster, bool keepGoing)
        {
            if (monster.IsDead())
            {
                Console.WriteLine($"You killed the monster, gaining {monster.Exp} experience and {monster.Gold} gold! \n");
                GetExpGold(player, monster);
                keepGoing = false;
                return keepGoing;
            }
            else if (player.IsDead())
            {
                keepGoing = false;
                return keepGoing;
            }

            return keepGoing;
        } //klar och fin och så!

        public static void GetExpGold(Player player, SpecificMonster monster) // klar och fin och så!
        {
            player.Exp += monster.Exp;
            player.Gold += monster.Gold;
            player.LvlUp();
            Console.WriteLine($"You are level {player.Lvl}, and you have {player.Exp} exp and {player.Hp} hp, and {player.Gold} gold");
        }

        public static int RealDmg(Player player, SpecificMonster monster) // FIXA, gör ATTACK och TAKEDMG metoder istället
        {
            int realDmg = monster.Dmg - player.Toughness;

            if (realDmg <= 0)
            {
                realDmg = 0;
            }

            return realDmg;
        }
    }
}