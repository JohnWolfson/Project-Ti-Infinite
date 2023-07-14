namespace Project_Ti_Infinite.Objects.Characters
{
    public class Player : Character
    {
        public Inventory Inventory;

        public Player(string name) : base(name)
        {
            this.name = name;
            Inventory = new Inventory();
        }
    }

    public class Inventory
    {
        private int gold;
    }
}
