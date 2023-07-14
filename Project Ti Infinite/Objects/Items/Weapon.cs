namespace Project_Ti_Infinite.Objects.Items
{
    public class Weapon : Item
    {
        public Weapon(string name) : base(name)
        {
            this.name = name;
        }

        public Weapon(string name, int cost) : base(name, cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
