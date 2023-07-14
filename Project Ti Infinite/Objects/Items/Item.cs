namespace Project_Ti_Infinite.Objects.Items
{
    public abstract class Item
    {
        private protected string name;
        private protected int cost;
        public Item(string name) 
        {
            this.name = name;
        }

        public Item(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
