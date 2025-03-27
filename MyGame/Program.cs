using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy loki = new Enemy("Loki");

            loki.SetName("Loki Laufeyson");

            Console.WriteLine($"Name is {loki.GetName()} and HP is {loki.GetHealth()}");

        }
    }
}
