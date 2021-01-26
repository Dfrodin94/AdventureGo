using Labb3_AdventureGo.utility;
using System;

namespace Labb3_AdventureGo.monsters
{
    abstract class Monster : IBattleMechanics
    {
        private string name;
        private int exp;
        private int hp;
        private int dmg;
        private int gold;

        public string Name { get => name; set => name = value; }
        public int Exp { get => exp; set => exp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Dmg { get => dmg; set => dmg = value; }
        public int Gold { get => gold; set => gold = value; }

        public int Attack()
        {
            Random rndm = new Random();
            int attack = rndm.Next(1, dmg);
            return attack;
        }

        public int TakeDmg(int dmg)
        {
            hp -= dmg;
            return dmg;
        }

        public bool IsDead()
        {
            if (hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}