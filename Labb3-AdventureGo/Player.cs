using Labb3_AdventureGo.monsters;
using Labb3_AdventureGo.utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_AdventureGo
{
    class Player : IGameMechanics
    {

        private string name;
        private int lvl;
        private int exp;
        private int hp;
        private int dmg;

        public Player()
        {

        }

        public Player(string name, int lvl, int exp, int hp, int dmg)
        {
            this.name = name;
            this.lvl = lvl;
            this.exp = exp;
            this.hp = hp;
            this.dmg = dmg;
        }

        public void LvlUp ()
        {
            if (exp >= 200)
            {
                int tempExp = exp;
                tempExp -= 200;

                Exp = tempExp;
                Lvl += 1;
                Hp += 20;
                Dmg += 3;
            }


        }

        public void Attack(Player p, SpecificMonster s)
        {
            s.Hp -= p.dmg;

        }

        public bool IsDead ()
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


        public string Name { get => name; set => name = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }
        public int Hp { get => hp; set => hp = value; }
        public int Dmg { get => dmg; set => dmg = value; }


    }
}
