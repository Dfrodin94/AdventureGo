using Labb3_AdventureGo.utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_AdventureGo.monsters
{
    abstract class Monster : IGameMechanics
    {
        private string name;
        private int exp;
        private int hp;
        private int dmg;

        public string Name { get => name; set => name = value; }
        public int Exp { get => exp; set => exp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Dmg { get => dmg; set => dmg = value; }

        public void Attack(Player p, SpecificMonster s)
        {
            p.Hp -= s.Dmg;

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
