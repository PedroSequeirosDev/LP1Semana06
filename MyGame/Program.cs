using System;
using System.Globalization;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string AmountofEnemies = args[0];
            int EnemiesConverted = int.Parse(AmountofEnemies);

            Enemy[] AllEnemies = new Enemy[EnemiesConverted];

            for (int NumberofEnemies = 0; NumberofEnemies < EnemiesConverted; NumberofEnemies++)
            {
                Console.Write($"Nome do inimigo {NumberofEnemies + 1}: ");
                AllEnemies[NumberofEnemies] = new Enemy(Console.ReadLine());
            }

            foreach (Enemy enemy in AllEnemies)
            {
                enemy.TakeDamage(50);
                enemy.PickupPowerUp(PowerUp.Shield, 50);
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");


            }



        }
    }
}
