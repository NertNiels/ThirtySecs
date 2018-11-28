using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtySecs
{
    class Game
    {
    }

    class GameOptions
    {
        public GameDifficulty difficulty { get; private set; }
        public int numberOfWords;

        public GameOptions(GameDifficulty dif, int numWords)
        {
            difficulty = dif;
            numberOfWords = numWords;
        }

    }

    enum GameDifficulty
    {
        Easy,
        Normal,
        Hard
    }
}
