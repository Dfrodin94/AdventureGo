namespace Labb3_AdventureGo.items
{
    abstract class BaseItem
    {
        private string name;
        private int cost;
        private string type;

        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Type { get => type; set => type = value; }

        virtual public int getBonus()
        {
            int bonus = 0;
            return bonus;
        }
    }
}