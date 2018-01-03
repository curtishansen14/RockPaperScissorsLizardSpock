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
        public int judge;
        public string humans;
        public Player playerOne;
        public Player playerTwo;

        //constructor
        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();

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
                    Text.PleaseTryAgain();
                    Text.askNumberofHumans();
                    playGame();
                    //text function that says try again.
                    break;
            }
        }

        //The function below compares player 1 and player 2 champions. PlayerTwo isn't quite finished. 
        //Use the function they sent you where Judge = D. Judge will be used to declare winner 
        public void CompareChampions()
        {
            judge = (5 + playerOne.champion - playerTwo.champion) % 5;
        }
    }
}
