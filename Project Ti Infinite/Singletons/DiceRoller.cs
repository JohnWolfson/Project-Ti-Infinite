namespace Project_Ti_Infinite.Singletons
{
    public sealed class DiceRoller
    {
        private static DiceRoller instance;

        public static DiceRoller Instance { get { if(instance == null) { instance = new DiceRoller(); } return instance; } }

        private Random random = new Random();

        public int Roll12()
        {
            return random.Next(1, 13);
        }

        public int RollCustom(int max)
        {
            return random.Next(1, (max + 1));
        }

        public int RollRange(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
