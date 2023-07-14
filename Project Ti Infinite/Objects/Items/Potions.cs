namespace Project_Ti_Infinite.Objects.Items
{
    public class Potions : Item
    {
        public Potions(string name) : base(name)
        {
            this.name = name;
        }

        public Potions(string name, int cost) : base(name, cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
