using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_AdventureGo.monsters
{
    class SpecificMonster : Monster 
    {
        public SpecificMonster ()
        {

        }

        public SpecificMonster(String name, int exp, int hp, int dmg)
        {
            this.Name = name;
            this.Exp = exp;
            this.Hp = hp;
            this.Dmg = dmg; 
        }

    }
}
