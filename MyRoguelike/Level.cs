using System;
using System.Globalization;
using Humanizer;

namespace MyRoguelike
{
public class Level
  {
        private int NumberofRooms;
        private Toughness Dificulty;

        private int NumberofEnemies;

        private Enemy[] EnemiesInRoom;

        private string name;

        public Level(int NumberofRooms, Toughness Dificulty)
        {
            this.NumberofRooms = NumberofRooms;
            this.Dificulty = Dificulty;
            NumberofEnemies = 0;
            EnemiesInRoom = new Enemy[NumberofRooms];
        }
        public string GetName()
        {
            return name;
        }

        public void SetEnemyInRoom(int RoomIndex, Enemy enemy)
        {
            EnemiesInRoom[RoomIndex] = enemy;
            NumberofEnemies += 1;
        }

        public int GetNumRooms()
        {
            return NumberofRooms;
        }

        public int GetNumEnemies()
        {
            return NumberofEnemies;
        }

        public Toughness GetToughness()
        {
            return Dificulty;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < NumberofRooms; i++)
            {

                if (EnemiesInRoom[i] != null)
                {
                    string letterstowords = i.ToOrdinalWords(new CultureInfo("en")).Transform(To.TitleCase);
                    Console.WriteLine($"{letterstowords} room: {EnemiesInRoom[i].GetName()}");
                    
                }
            }
        }
    }
}