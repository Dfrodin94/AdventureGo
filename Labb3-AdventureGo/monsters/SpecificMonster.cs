using System;

namespace Labb3_AdventureGo.monsters
{
    internal class SpecificMonster : Monster
    {
        public SpecificMonster()
        {
        }

        public SpecificMonster(String name, int exp, int hp, int dmg, int gold)
        {
            this.Name = name;
            this.Exp = exp;
            this.Hp = hp;
            this.Dmg = dmg;
            this.Gold = gold;
        }
    }
}