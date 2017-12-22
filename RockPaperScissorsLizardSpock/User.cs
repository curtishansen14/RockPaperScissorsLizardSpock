using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class User
    {
        //member variables
        public string name;
        public string score;
        public string champion;
        public Player playerOne;
        public Player playerTwo;


        //constructor
        public User()
        {
            Text.askForName();
            name = Console.ReadLine();
        }
        //member methods
         public string getPlayerChampion()
        {
            Text.askForChampion();
            champion = Console.ReadLine();
            return champion;
        }
    }
}
