namespace Project_Ti_Infinite.Objects.Characters
{
    public abstract class Character
    {
        private protected string name;
        private bool dead;
        public Stats Stats;

        public Character(string name)
        {
            this.name = name;
            dead = false;
            Stats = new Stats(this);
        }

        #region Get/Sets

        public bool IsDead()
        {
            return dead;
        }

        #region Stats

        public int GetHealth()
        {
            return Stats.GetHealth();
        }

        #endregion

        #endregion

        public void TakeDamage(int damage)
        {
            bool dead = Stats.TakeDamage(damage);
            if (dead)
                death();
        }

        public void Heal(int heal)
        {
            Stats.Heal(heal);
        }

        private void death()
        {
            dead = true;
        }
    }

    public class Stats
    {
        public object parent;
        public Abilities Abilities;
        private int level;
        private int health;
        private int healthMax;
        private int exp;
        private int nextLevel;

        public Stats(object parent, int level = 1, int health = 13, int healthMax = 13, int exp = 0, int nextLevel = 50)
        {
            this.parent = parent;
            Abilities = new Abilities();
            this.level = level;
            this.health = health;
            this.healthMax = healthMax;
            this.exp = exp;
            this.nextLevel = nextLevel;
        }

        #region Get/Sets

        public int GetHealth()
        {
            return health;
        }

        #endregion

        public bool TakeDamage(int damage)
        {
            health -= damage;
            if (health < 1)
                return true;
            else return false;
        }

        public void Heal(int heal)
        {
            health += heal;
            if (health > healthMax)
                health = healthMax;
        }
    }

    public class Abilities
    {
        private int str;
        private int dex;
        private int con;
        private int strMod;
        private int dexMod;
        private int conMod;
        private int stamina;
        private int staminaMax;

        public Abilities(int str = 6, int dex = 6, int con = 6)
        {
            this.str = str;
            this.dex = dex;
            this.con = con;
            UpdateAbilityMods();
            stamina = staminaMax;
        }

        #region Get/Sets

        public int GetStrMod()
        {
            return strMod;
        }

        public int GetDexMod()
        {
            return dexMod;
        }

        public int GetConMod()
        {
            return conMod;
        }

        public int GetStamina()
        {
            return stamina;
        }

        #endregion

        public void UpdateAbilityMods()
        {
            strMod = str / 3;
            dexMod = dex / 3;
            conMod = con / 3;
            staminaMax = 4 + 2 * dexMod;
            if (staminaMax < 7)
                staminaMax = 7;
        }
    }
}
