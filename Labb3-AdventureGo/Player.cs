using Labb3_AdventureGo.items;
using Labb3_AdventureGo.utility;
using System;

namespace Labb3_AdventureGo
{
    class Player : IBattleMechanics
    {
        private string name;
        private int lvl;
        private int exp;
        private int hp;
        private int strength;
        private int toughness;
        private int gold;

        public Player()
        {
        }

        public Player(string name, int lvl, int exp, int hp, int strength, int toughness, int gold)
        {
            this.name = name;
            this.lvl = lvl;
            this.exp = exp;
            this.hp = hp;
            this.strength = strength;
            this.Toughness = toughness;
            this.gold = gold;
        }

        public void LvlUp()
        {
            if (exp >= 200)
            {
                int tempExp = exp;
                tempExp -= 200;

                Exp = tempExp;
                Lvl += 1;
                Hp = 200;
                Dmg += 3;

                // hade gått att göra en metod i klassen BattleUtility som lvl:ar upp monster här och sänker exp etc. 
            }
        }

        public int Attack()
        {
            Random rndm = new Random();

            int attack = rndm.Next(5, strength);
            return attack;
        }

        public int TakeDmg(int dmg)
        {
            dmg -= toughness;

            if (dmg <= 0)
            {
                dmg = 0;
            }

            hp -= dmg;

            return dmg;
        }

        public void WearItem(BaseItem item)
        {
            if (item.Type == "ring")
            {
                int strength = item.getBonus();
                this.strength += strength;
            }
            else
            {
                int toughness = item.getBonus();
                this.toughness += toughness;

                // wear amulet
            }
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

        public void ShowStats()
        {
            Console.WriteLine("********");
            Console.WriteLine($"* Name: {name}");
            Console.WriteLine($"* Level: {lvl}");
            Console.WriteLine($"* Hp: {hp}/200");
            Console.WriteLine($"* Exp: {exp}/200");
            Console.WriteLine($"* Gold: {gold}");
            Console.WriteLine($"* Strength: {strength}");
            Console.WriteLine($"* Toughness: {Toughness}");
            Console.WriteLine("******** \n");

            Console.WriteLine("[Press enter to continue]");
            Console.ReadLine();
        }

        public string Name { get => name; set => name = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Exp { get => exp; set => exp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Dmg { get => strength; set => strength = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Toughness { get => toughness; set => toughness = value; }
    }
}