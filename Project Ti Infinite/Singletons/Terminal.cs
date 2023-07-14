using Project_Ti_Infinite.Objects;

namespace Project_Ti_Infinite.Singletons
{
    public sealed class Terminal
    {
        private static Terminal instance;

        public static Terminal Instance { get { if(instance == null) { instance = new Terminal(); } return instance; } }

        #region Initiliase

        public void Initialise()
        {
            Console.SetWindowSize(171, 50);
            Console.SetBufferSize(172, 51);
            Console.Clear();
            drawOuterBorders();
            drawInnerBorders();
            drawDescriptions();
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
            Draw.Rectangle(20, 9, 148, 16, color: ConsoleColor.Red);
        }

        private void drawDescriptions()
        {
            Console.SetCursorPosition(4, 6);
            Console.Write("Name: ISP");
            Console.SetCursorPosition(4, 7);
            Console.Write("Lvl: 1");
            Console.SetCursorPosition(4, 8);
            Console.Write("HP: 13/13");
            Console.SetCursorPosition(4, 9);
            Console.Write("STA: 10/10");
            Console.SetCursorPosition(4, 10);
            Console.Write("AC: 10");
            Console.SetCursorPosition(4, 12);
            Console.Write("STR: 12 (+4)");
            Console.SetCursorPosition(4, 13);
            Console.Write("DEX: 9 (+3)");
            Console.SetCursorPosition(4, 14);
            Console.Write("CON: 9 (+3)");
            Console.SetCursorPosition(4, 16);
            Console.Write("XP: 0");
            Console.SetCursorPosition(4, 17);
            Console.Write("LU: 50");
            Console.SetCursorPosition(4, 19);
            Console.Write("Weapon: Shortsword");
            Console.SetCursorPosition(4, 20);
            Console.Write("OfHand: N/A");
            Console.SetCursorPosition(4, 21);
            Console.Write("Armour: Leather");
            Console.SetCursorPosition(4, 23);
            Console.Write("Inventory");
            Console.SetCursorPosition(4, 25);
            Console.Write("Gold: 0");
            Console.SetCursorPosition(150, 6);
            Console.Write("Fight Order");
            Console.SetCursorPosition(150, 8);
            Console.Write("Thief");
            Console.SetCursorPosition(150, 9);
            Console.Write("Mercenary");
            Console.SetCursorPosition(150, 10);
            Console.Write("Mercenary");
            Console.SetCursorPosition(150, 11);
            Console.Write("Thug");
            Console.SetCursorPosition(150, 12);
            Console.Write("Thug");
            Console.SetCursorPosition(150, 13);
            Console.Write("Thug");
            Console.SetCursorPosition(150, 14);
            Console.Write("Scout");
            Console.SetCursorPosition(150, 15);
            Console.Write("ISP");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(150, 17);
            Console.Write("Enemies");
            Console.SetCursorPosition(150, 19);
            Console.Write("Thief");
            Console.SetCursorPosition(150, 20);
            Console.Write("Thug");
            Console.SetCursorPosition(150, 21);
            Console.Write("Mercenary");
            Console.SetCursorPosition(150, 22);
            Console.Write("Scout");
            Console.SetCursorPosition(150, 23);
            Console.Write("Thug");
            Console.SetCursorPosition(150, 24);
            Console.Write("Thug");
            Console.SetCursorPosition(150, 25);
            Console.Write("Mercenary");
            Console.ForegroundColor = ConsoleColor.White;
        }

        #endregion

        #region Update Displays

        public void UpdatePlayerDetails(Display_Info info)
        {
            if(info.GetCharacterName() != "")
            {
                clearArea(12, 1, 10, 6);
                Console.SetCursorPosition(10, 6);
                Console.Write(info.GetCharacterName());
            }
            if(info.GetCharacterLevel() != int.MinValue)
            {
                clearArea(14, 1, 8, 7);
                Console.SetCursorPosition(9, 7);
                Console.Write(info.GetCharacterLevel());
            }
            if(info.GetCharacterHealth() != int.MinValue || info.GetCharacterHealthMax() != int.MinValue)
            {
                clearArea(15, 1, 7, 8);
                Console.SetCursorPosition(8, 8);
                Console.Write(info.GetCharacterHealth() + "/" + info.GetCharacterHealthMax());
            }
            if(info.GetCharacterStamina() != int.MinValue || info.GetCharacterStaminaMax() != int.MinValue)
            {
                clearArea(14, 1, 8, 9);
                Console.SetCursorPosition(9, 9);
                Console.Write(info.GetCharacterStamina() + "/" + info.GetCharacterStaminaMax());
            }
            if(info.GetCharacterArmourClass() != int.MinValue)
            {
                clearArea(15, 1, 7, 10);
                Console.SetCursorPosition(8, 10);
                Console.Write(info.GetCharacterArmourClass());
            }
        }

        public void UpdatePlayerAbilities(Display_Info info)
        {
            if(info.GetCharacterStr() != int.MinValue || info.GetCharacterStrMod() != int.MinValue)
            {
                clearArea(14, 1, 8, 12);
                Console.SetCursorPosition(9, 12);
                Console.Write(info.GetCharacterStr() + " (+" + info.GetCharacterStrMod() + ")");
            }
            if (info.GetCharacterDex() != int.MinValue || info.GetCharacterDexMod() != int.MinValue)
            {
                clearArea(14, 1, 8, 13);
                Console.SetCursorPosition(9, 13);
                Console.Write(info.GetCharacterDex() + " (+" + info.GetCharacterDexMod() + ")");
            }
            if (info.GetCharacterCon() != int.MinValue || info.GetCharacterConMod() != int.MinValue)
            {
                clearArea(14, 1, 8, 14);
                Console.SetCursorPosition(9, 14);
                Console.Write(info.GetCharacterCon() + " (+" + info.GetCharacterConMod() + ")");
            }
        }

        public void UpdatePlayerXP(Display_Info info)
        {
            if(info.GetCharacterXP() != int.MinValue)
            {
                clearArea(14, 1, 8, 16);
                Console.SetCursorPosition(8, 16);
                Console.Write(info.GetCharacterXP());
            }
            if(info.GetCharacterNextLevel() != int.MinValue)
            {
                clearArea(14, 1, 8, 17);
                Console.SetCursorPosition(8, 17);
                Console.Write(info.GetCharacterNextLevel());
            }
        }

        public void UpdatePlayerEquipment(Display_Info info)
        {
            if(info.GetCharacterWeapon() != "")
            {
                clearArea(10, 1, 12, 19);
                Console.SetCursorPosition(12, 19);
                Console.Write(info.GetCharacterWeapon());
            }
            if (info.GetCharacterOffHand() != "")
            {
                clearArea(10, 1, 12, 20);
                Console.SetCursorPosition(12, 20);
                Console.Write(info.GetCharacterOffHand());
            }
            if (info.GetCharacterArmour() != "")
            {
                clearArea(10, 1, 12, 21);
                Console.SetCursorPosition(12, 21);
                Console.Write(info.GetCharacterArmour());
            }
        }

        public void UpdatePlayerInventory()
        {
            clearArea(18, 23, 4, 25);
        }

        public void UpdatePlayerOptions()
        {

        }

        public void UpdateStory()
        {

        }

        public void UpdateEvents()
        {

        }

        public void UpdateFightOrder()
        {

        }

        public void UpdateEnemies()
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

        #region Input

        public int Input(int options)
        {
            bool answer = false;
            int input = 0;
            while (!answer)
            {
                input = inputLoop(options);
                if (input != 404)
                {
                    answer = !answer;
                }
            }
            return input;
        }

        private int inputLoop(int Options)
        {
            ConsoleKey Input = Console.ReadKey(true).Key;
            if (Input == ConsoleKey.D1 || Input == ConsoleKey.D2 || Input == ConsoleKey.D3 || Input == ConsoleKey.D4 || Input == ConsoleKey.D5 || Input == ConsoleKey.D6 || 
                Input == ConsoleKey.D7 || Input == ConsoleKey.D8 || Input == ConsoleKey.D9 || Input == ConsoleKey.D0 || Input == ConsoleKey.NumPad1 || Input == ConsoleKey.NumPad2 ||
                Input == ConsoleKey.NumPad3 || Input == ConsoleKey.NumPad4 || Input == ConsoleKey.NumPad5 || Input == ConsoleKey.NumPad6 || Input == ConsoleKey.NumPad7 ||
                Input == ConsoleKey.NumPad8 || Input == ConsoleKey.NumPad9 || Input == ConsoleKey.NumPad0)
            {
                string OptionString = Input.ToString();
                int OptionNumber = Convert.ToInt32(OptionString.Remove(0, 1));
                if (OptionNumber <= Options)
                    return OptionNumber;
            }
            return 404;
        }

        #endregion
    }
}