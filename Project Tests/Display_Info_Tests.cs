using Project_Ti_Infinite.Objects;

namespace Project_Tests
{
    [TestClass]
    public class Display_Info_Tests
    {
        [TestMethod]
        public void Test_Display_Info_Contructor_Details()
        {
            Display_Info info = new Display_Info(characterName: "Character", characterHealth: 15, characterHealthMax: 20, characterStamina: 10, characterStaminaMax: 12,
                characterArmourClass: 10);
            Assert.IsNotNull(info);
            Assert.AreEqual("Character", info.GetCharacterName());
            Assert.AreEqual(15, info.GetCharacterHealth());
            Assert.AreEqual(20, info.GetCharacterHealthMax());
            Assert.AreEqual(10, info.GetCharacterStamina());
            Assert.AreEqual(12, info.GetCharacterStaminaMax());
            Assert.AreEqual(10, info.GetCharacterArmourClass());
            info = new Display_Info(characterName: "Character");
            Assert.IsNotNull(info);
            Assert.AreEqual("Character", info.GetCharacterName());
            Assert.AreEqual(int.MinValue, info.GetCharacterHealth());
            Assert.AreEqual(int.MinValue, info.GetCharacterHealthMax());
            Assert.AreEqual(int.MinValue, info.GetCharacterStamina());
            Assert.AreEqual(int.MinValue, info.GetCharacterStaminaMax());
            Assert.AreEqual(int.MinValue, info.GetCharacterArmourClass());
            info = new Display_Info(characterHealth: 10, characterStamina: 12);
            Assert.IsNotNull(info);
            Assert.AreEqual("", info.GetCharacterName());
            Assert.AreEqual(10, info.GetCharacterHealth());
            Assert.AreEqual(int.MinValue, info.GetCharacterHealthMax());
            Assert.AreEqual(12, info.GetCharacterStamina());
            Assert.AreEqual(int.MinValue, info.GetCharacterStaminaMax());
            Assert.AreEqual(int.MinValue, info.GetCharacterArmourClass());
        }

        [TestMethod]
        public void Test_Display_Info_Constructor_Abilities()
        {
            Display_Info info = new Display_Info(characterStr: 11, characterStrMod: 3, characterDex: 10, characterDexMod: 3, characterCon: 12, characterConMod: 4);
            Assert.IsNotNull(info);
            Assert.AreEqual(11, info.GetCharacterStr());
            Assert.AreEqual(3, info.GetCharacterStrMod());
            Assert.AreEqual(10, info.GetCharacterDex());
            Assert.AreEqual(3, info.GetCharacterDexMod());
            Assert.AreEqual(12, info.GetCharacterCon());
            Assert.AreEqual(4, info.GetCharacterConMod());
            info = new Display_Info(characterDex: 15, characterDexMod: 5);
            Assert.IsNotNull(info);
            Assert.AreEqual(int.MinValue, info.GetCharacterStr());
            Assert.AreEqual(int.MinValue, info.GetCharacterStrMod());
            Assert.AreEqual(15, info.GetCharacterDex());
            Assert.AreEqual(5, info.GetCharacterDexMod());
            Assert.AreEqual(int.MinValue, info.GetCharacterCon());
            Assert.AreEqual(int.MinValue, info.GetCharacterConMod());
            info = new Display_Info(characterStr: 10, characterDex: 11, characterCon: 10);
            Assert.IsNotNull(info);
            Assert.AreEqual(10, info.GetCharacterStr());
            Assert.AreEqual(int.MinValue, info.GetCharacterStrMod());
            Assert.AreEqual(11, info.GetCharacterDex());
            Assert.AreEqual(int.MinValue, info.GetCharacterDexMod());
            Assert.AreEqual(10, info.GetCharacterCon());
            Assert.AreEqual(int.MinValue, info.GetCharacterConMod());
        }

        [TestMethod]
        public void Test_Display_Info_XP()
        {
            Display_Info info = new Display_Info(characterXP: 30, characterNextLevel: 50);
            Assert.IsNotNull(info);
            Assert.AreEqual(30, info.GetCharacterXP());
            Assert.AreEqual(50, info.GetCharacterNextLevel());
            info = new Display_Info(characterXP: 45);
            Assert.IsNotNull(info);
            Assert.AreEqual(45, info.GetCharacterXP());
            Assert.AreEqual(int.MinValue, info.GetCharacterNextLevel());
            info = new Display_Info(characterNextLevel: 75);
            Assert.IsNotNull(info);
            Assert.AreEqual(int.MinValue, info.GetCharacterXP());
            Assert.AreEqual(75, info.GetCharacterNextLevel());
        }

        [TestMethod]
        public void Test_Display_Info_Equipment()
        {
            Display_Info info = new Display_Info(characterWeapon: "Longsword", characterOffHand: "Shield", characterArmour: "Leather");
            Assert.IsNotNull(info);
            Assert.AreEqual("Longsword", info.GetCharacterWeapon());
            Assert.AreEqual("Shield", info.GetCharacterOffHand());
            Assert.AreEqual("Leather", info.GetCharacterArmour());
            info = new Display_Info(characterArmour: "Leather");
            Assert.IsNotNull(info);
            Assert.AreEqual("", info.GetCharacterWeapon());
            Assert.AreEqual("", info.GetCharacterOffHand());
            Assert.AreEqual("Leather", info.GetCharacterArmour());
            info = new Display_Info(characterWeapon: "Shortsword", characterOffHand: "Empty");
            Assert.IsNotNull(info);
            Assert.AreEqual("Shortsword", info.GetCharacterWeapon());
            Assert.AreEqual("Empty", info.GetCharacterOffHand());
            Assert.AreEqual("", info.GetCharacterArmour());
        }
    }
}