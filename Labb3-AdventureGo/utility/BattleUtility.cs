using Labb3_AdventureGo.monsters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_AdventureGo.utility
{
    static class BattleUtility
    {

        public static bool AdventureChance() 
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

        public static void Battle(Player p, SpecificMonster s)
        {

            bool keepGoing = true;
            Console.WriteLine($"Uh oh! A {s.Name} appeared!");

            while (keepGoing)
            {

                Console.WriteLine($"You hit the monster, dealing {p.Dmg} damage");
                Console.WriteLine("Uuoooah *slurp*");
                Console.WriteLine($"The monster hits you, dealing {s.Dmg} damage");

                p.Attack(p, s);
                s.Attack(p, s);
                keepGoing = BattleWinner(p, s, keepGoing);

                if (keepGoing)
                {
                    Console.WriteLine($"{p.Name} has: {p.Hp} hp left");
                    Console.WriteLine($"{s.Name} has: {s.Hp} hp left");
                    Console.WriteLine("[press enter to continue]");
                    Console.ReadLine();

                }

            }
        }

        public static bool BattleWinner(Player p, SpecificMonster s, bool keepGoing)
        {
            if (s.IsDead())
            {
                Console.WriteLine($"You killed the monster, gaining {s.Exp} experience! \n");
                GetExp(p, s);
                keepGoing = false;
                return keepGoing;

            }
            else if (p.IsDead())
            {
            
                keepGoing = false;
                return keepGoing;
                
            }

            return keepGoing;



        }

        public static void GetExp(Player p, SpecificMonster s)
        {
            p.Exp += s.Exp;
            p.LvlUp();
            Console.WriteLine($"You are level {p.Lvl}, and you have {p.Exp} exp and {p.Hp} hp");
        }

    }
}
