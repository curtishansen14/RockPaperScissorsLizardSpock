using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variables
        public string humans;
        





        //constructor
        public Game()
        {

        }

        //member methods 

        public string getNumberofHumans()
        {
            Text.askNumberofHumans();
            humans = Console.ReadLine();
            return humans;
        }

        public void playGame()
        {

            switch (getNumberofHumans())
            {
                case "1":
                    //functions for player vs computer
                    break;
                case "2":
                    //functions for player vs player
                    break;
                default:
                    Text.pleaseTryAgain();
                    playGame();
                    break;
            }
        }
    }
}
