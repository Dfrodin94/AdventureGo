namespace Labb3_AdventureGo.items
{
    internal class Amulet : BaseItem
    {
        private int toughnessBonus;

        public Amulet(string name, int toughnessBonus, int cost)
        {
            this.toughnessBonus = toughnessBonus;
            this.Name = name;
            this.Cost = cost;
            this.Type = "amulet";
        }

        public int ToughnessBonus { get => toughnessBonus; set => toughnessBonus = value; }

        public override string ToString()
        {
            string text = $"Name: {Name} Toughness bonus: {toughnessBonus} cost: {Cost}";

            return text;
        }

        public override int getBonus()
        {
            return toughnessBonus;
        }
    }
}