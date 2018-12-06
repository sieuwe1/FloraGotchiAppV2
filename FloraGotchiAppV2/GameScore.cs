using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraGotchiAppV2
{
    public class GameScore
    {

        int score = 5000;

        public GameScore()
        {
                
        }

        public void AddScore(int add)
        {
            score = score + add;

        }

        public int GetScore()
        {
            
            return score;

        }

    }
}
