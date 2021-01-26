using Labb3_AdventureGo.monsters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb3_AdventureGo.data
{
    class MonsterData
    {
        private Random random = new Random();

        public List<SpecificMonster> GetMonsters()
        {
            List<SpecificMonster> monsterList = new List<SpecificMonster>(); // hade gått att göra egna klasser av varje monster

            monsterList.Add(new SpecificMonster("Devil", 100, 60, 10, 100));
            monsterList.Add(new SpecificMonster("Worm", 20, 30, 4, 100));
            monsterList.Add(new SpecificMonster("Imp", 50, 20, 8, 100));
            monsterList.Add(new SpecificMonster("Demonic Fire", 5, 10, 12, 100));
            monsterList.Add(new SpecificMonster("Spirit", 7, 15, 10, 100));

            return monsterList;
        }

        public SpecificMonster RandomMonster()
        {
            SpecificMonster monster = new SpecificMonster();

            List<SpecificMonster> monsterList = GetMonsters();

            int max = monsterList.Count() - 1;

            monster = monsterList[random.Next(0, max)];

            return monster;
        }

        public List<SpecificMonster> TestData()
        {
            List<SpecificMonster> monsterList = new List<SpecificMonster>();
            monsterList.Add(new SpecificMonster("TestMonster", 240, 200, 240, 1000));

            return monsterList;
        }
    }
}