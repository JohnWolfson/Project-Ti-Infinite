using Project_Ti_Infinite.Objects.Characters;

namespace Project_Tests
{
    [TestClass]
    public class Character_Tests
    {
        [TestMethod]
        public void TestPlayerAbilityScores() 
        {
            Player player = new Player("Player");
            Assert.AreEqual(2, player.Stats.Abilities.GetStrMod());
            Assert.AreEqual(2, player.Stats.Abilities.GetDexMod());
            Assert.AreEqual(2, player.Stats.Abilities.GetConMod());
            Assert.AreEqual(8, player.Stats.Abilities.GetStamina());
        }

        [TestMethod]
        public void TestNPCAbilityScores()
        {
            NPC npc = new NPC("NPC");
            Assert.AreEqual(2, npc.Stats.Abilities.GetStrMod());
            Assert.AreEqual(2, npc.Stats.Abilities.GetDexMod());
            Assert.AreEqual(2, npc.Stats.Abilities.GetConMod());
            Assert.AreEqual(8, npc.Stats.Abilities.GetStamina());
        }

        [TestMethod]
        public void TestPlayerHealth()
        {
            Player player = new Player("Player");
            Assert.AreEqual(13, player.GetHealth());
            player.TakeDamage(9);
            Assert.AreEqual(4, player.GetHealth());
            Assert.IsFalse(player.IsDead());
            player.Heal(7);
            Assert.AreEqual(11, player.GetHealth());
            player.Heal(5);
            Assert.AreEqual(13, player.GetHealth());
            player.TakeDamage(15);
            Assert.AreEqual(-2, player.GetHealth());
            Assert.IsTrue(player.IsDead());
        }

        [TestMethod]
        public void TestNPCHealth()
        {
            NPC npc = new NPC("npc");
            Assert.AreEqual(13, npc.GetHealth());
            npc.TakeDamage(9);
            Assert.AreEqual(4, npc.GetHealth());
            Assert.IsFalse(npc.IsDead());
            npc.Heal(7);
            Assert.AreEqual(11, npc.GetHealth());
            npc.Heal(5);
            Assert.AreEqual(13, npc.GetHealth());
            npc.TakeDamage(15);
            Assert.AreEqual(-2, npc.GetHealth());
            Assert.IsTrue(npc.IsDead());
        }
    }
}