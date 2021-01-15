using Labb3_AdventureGo.data;
using Labb3_AdventureGo.monsters;
using Labb3_AdventureGo.utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_AdventureGo
{
    static class Meny
    {

        public static void GameHeader()
        {
            String menyHeader =
                "************************ \n" +
                "* Welcome to the game! * \n" +
                "************************";

            Console.WriteLine(menyHeader);

        }

        public static void GameMeny()
        {
            bool keepGoing = true;
            GameHeader();

            Console.Write("Enter your name: ");
            String playerName = Console.ReadLine();
            Player player = new Player(playerName,1,0,200,10);


            MonsterData data = new MonsterData();
            List<SpecificMonster> monsterList = data.GetMonsters();
            SpecificMonster monster;
            

            while (keepGoing)
            {

                Console.WriteLine("1. Go Adventuring");
                Console.WriteLine("2. Show details about your character");
                Console.WriteLine("3. Exit game");
                Console.Write("> ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                         if (BattleUtility.AdventureChance())
                        {
                            monster = data.RandomMonster();

                            BattleUtility.Battle(player, monster);
                        }
                       
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                }

                keepGoing = WinOrLoose(player);

            }

        }

        public static bool WinOrLoose(Player p)
        {
            bool keepGoing = true;

            if (p.IsDead())
            {
                Console.WriteLine("You were killed by the monster :(");
                keepGoing = false;
                return keepGoing;
            }

            else if (p.Lvl == 10)
            {
                Console.WriteLine("Congratulations, you won the game!");
                keepGoing = false;
                return keepGoing;

            }

            return keepGoing;

        }



    }
}
