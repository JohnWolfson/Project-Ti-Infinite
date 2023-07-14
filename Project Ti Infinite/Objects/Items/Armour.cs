namespace Project_Ti_Infinite.Objects.Items
{
    public class Armour : Item
    {
        public Armour(string name) : base(name)
        {
            this.name = name;
        }

        public Armour(string name, int cost) : base(name, cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
