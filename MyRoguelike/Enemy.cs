using System;
using Humanizer;

namespace MyRoguelike
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        internal static int HowManyPowerUps;
        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }

        static Enemy()
        {
            HowManyPowerUps = 0;
        }
        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public string SetName(string CharName)
        {
            this.name = CharName;

            int NameLength = CharName.Length;

            return name;
        }

        internal void PickupPowerUp(PowerUp powerup, float Value)
        {
            if (powerup == PowerUp.Health)
            {
                health += Value;
                if (health > 100)
                {
                    health = 100;
                }
            }
            else if (powerup == PowerUp.Shield)
            {
                shield += Value;
                if (shield > 100)
                {
                    shield = 100;
                }
            }

            HowManyPowerUps += 1;


        }

        public static int GetHowManyPowerUps()
        {
            return HowManyPowerUps;
        }

    }
    
}