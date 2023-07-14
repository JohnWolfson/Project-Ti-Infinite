namespace Project_Ti_Infinite.Objects
{
    public class Display_Info
    {
        private string characterName = string.Empty;
        private int characterLevel;
        private int characterHealth;
        private int characterHealthMax;
        private int characterStamina;
        private int characterStaminaMax;
        private int characterArmourClass;
        private int characterStr;
        private int characterStrMod;
        private int characterDex;
        private int characterDexMod;
        private int characterCon;
        private int characterConMod;
        private int characterXP;
        private int characterNextLevel;
        private string characterWeapon = string.Empty;
        private string characterOffHand = string.Empty;
        private string characterArmour = string.Empty; 

        public Display_Info(string characterName = "", int characterLevel = int.MinValue, int characterHealth = int.MinValue, int characterHealthMax = int.MinValue,
            int characterStamina = int.MinValue, int characterStaminaMax = int.MinValue, int characterArmourClass = int.MinValue)
        {
            this.characterName = characterName;
            this.characterLevel = characterLevel;
            this.characterHealth = characterHealth;
            this.characterHealthMax = characterHealthMax;
            this.characterStamina = characterStamina;
            this.characterStaminaMax = characterStaminaMax;
            this.characterArmourClass = characterArmourClass;
        }

        public Display_Info(int characterStr = int.MinValue, int characterStrMod = int.MinValue, int characterDex = int.MinValue, int characterDexMod = int.MinValue,
            int characterCon = int.MinValue, int characterConMod = int.MinValue)
        {
            this.characterStr = characterStr;
            this.characterStrMod = characterStrMod;
            this.characterDex = characterDex;
            this.characterDexMod = characterDexMod;
            this.characterCon = characterCon;
            this.characterConMod = characterConMod;
        }

        public Display_Info(int characterXP = int.MinValue, int characterNextLevel = int.MinValue)
        {
            this.characterXP = characterXP;
            this.characterNextLevel = characterNextLevel;
        }

        public Display_Info(string characterWeapon = "", string characterOffHand = "", string characterArmour = "")
        {
            this.characterWeapon = characterWeapon;
            this.characterOffHand = characterOffHand;
            this.characterArmour = characterArmour;
        }

        public string GetCharacterName() { return characterName; }
        public int GetCharacterLevel() { return characterLevel; }
        public int GetCharacterHealth() { return characterHealth; }
        public int GetCharacterHealthMax() { return characterHealthMax; }
        public int GetCharacterStamina() { return characterStamina; }
        public int GetCharacterStaminaMax() {  return characterStaminaMax; }
        public int GetCharacterArmourClass() {  return characterArmourClass; }
        public int GetCharacterStr() { return characterStr; }
        public int GetCharacterStrMod() { return characterStrMod; }
        public int GetCharacterDex() {  return characterDex; }
        public int GetCharacterDexMod() {  return characterDexMod; }
        public int GetCharacterCon() { return characterCon; }
        public int GetCharacterConMod() {  return characterConMod; }
        public int GetCharacterXP() { return characterXP; }
        public int GetCharacterNextLevel() { return characterNextLevel; }
        public string GetCharacterWeapon() { return characterWeapon; }
        public string GetCharacterOffHand() { return characterOffHand; }
        public string GetCharacterArmour() { return characterArmour; }
    }
}
