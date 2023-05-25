using System;

namespace Heist
{
    public class Bank
    {
        public int DifficultyLevel { get; set; }

        public Bank(int difficultyLevel)
        {
            DifficultyLevel = difficultyLevel;
        }
    }
}