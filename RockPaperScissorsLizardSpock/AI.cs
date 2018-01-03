using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class AI : Player
    {
        //member variables
        public int AIChampionNumber;
        public Random rnd;

        //constructor
        public AI()
        {

        }


        //member methods 

        public int getAIChampionNumber()
        {
            AIChampionNumber = rnd.Next(1, 5);
                return AIChampionNumber;

        }



        //use a list to for AI choices
    }
}
