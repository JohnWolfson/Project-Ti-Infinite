namespace Project_Ti_Infinite.Singletons
{
    public sealed class Terminal
    {
        private static Terminal instance = null;

        public static Terminal Instance { get { if(instance == null) { instance = new Terminal(); } return instance; } }

        #region Initiliase

        public void Initialise()
        {
            Console.SetWindowSize(171, 50);
            Console.SetBufferSize(172, 51);
            Console.Clear();
            drawOuterBorders();
            drawInnerBorders();
        }

        private void drawOuterBorders()
        {
            Draw.RectangleFromTop(170, 48, 0, 0, ConsoleColor.Blue);
            Draw.RectangleFromTop(170, 3, 0, 0, ConsoleColor.Blue);
            Draw.RectangleFromTop(146, 44, 24, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(24, 44, 146, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(122, 34, 24, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(61, 9, 85, 39, ConsoleColor.Blue);
            Console.SetCursorPosition(78, 2);
            Console.Write("Ti Infinite");
        }

        private void drawInnerBorders()
        {
            Draw.Rectangle(20, 5, 2, 5, color: ConsoleColor.Green);
            Draw.Rectangle(20, 3, 2, 11, color: ConsoleColor.Green);
            Draw.Rectangle(20, 2, 2, 15, color: ConsoleColor.Green);
            Draw.Rectangle(20, 3, 2, 18, color: ConsoleColor.Green);
            Draw.Rectangle(20, 25, 2, 22, color: ConsoleColor.Green);
            Draw.Rectangle(20, 10, 148, 5, color: ConsoleColor.Red);
            Draw.Rectangle(20, 10, 148, 16, color: ConsoleColor.Red);
        }

        #endregion

        #region Update Displays

        public void UpdatePlayerDetails(string name = null, int level = int.MinValue, int health = int.MinValue, int maxHealth = int.MinValue, int stamina = int.MinValue, int maxStamina = int.MinValue, int armour = int.MinValue)
        {
            //clearArea(19, 5, 3, 6);
        }

        public void UpdatePlayerAbilities()
        {

        }

        public void UpdatePlayerXP()
        {

        }

        public void UpdatePlayerEquipment()
        {

        }

        public void UpdatePlayerInventory()
        {

        }

        #endregion

        private void clearArea(int width, int height, int xpos, int ypos)
        {
            for (int y = ypos; y < ypos + height; y++)
            {
                string length = "";
                Console.SetCursorPosition(xpos, y);
                for (int x = 0; x < width; x++)
                {
                    length += " ";
                }
                Console.Write(length);
            }
        }
    }
}