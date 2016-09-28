using System;

namespace Minesweeper.Models
{
    public class Player
    {
        private string playerName;
        private int playerPoints;

        public Player()
        {
        }

        public Player(string playerName, int playerPoints)
        {
            this.playerName = playerName;
            this.playerPoints = playerPoints;
        }

        public string Name
        {
            get
            {
                return playerName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }
                playerName = value;
            }
        }

        public int Points
        {
            get
            {
                return playerPoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Points cannot be negative number!");
                }
                playerPoints = value;
            }
        }
    }
}
