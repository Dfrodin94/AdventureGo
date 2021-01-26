namespace Labb3_AdventureGo.items
{
    internal class Ring : BaseItem
    {
        private int strengthBonus;

        public Ring(string name, int strengthBonus, int cost)
        {
            this.StrengthBonus = strengthBonus;
            this.Name = name;
            this.Cost = cost;
            this.Type = "ring";
        }

        public int StrengthBonus { get => strengthBonus; set => strengthBonus = value; }

        public override int getBonus()
        {
            return strengthBonus;
        }

        public override string ToString()
        {
            string text = $"Name: {Name} Strength bonus: {strengthBonus} cost: {Cost}";

            return text;
        }
    }
}