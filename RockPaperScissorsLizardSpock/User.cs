using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class User : Player
    {
        //member variables
        public int ChampionNumber;
        public string ChampionName;


        //constructor
        public User()
        {
            Text.askForName();
            name = Console.ReadLine();
        }
        //member methods
         public string getPlayerChampion()
        {
            Text.askForChampionName();
            ChampionName= Console.ReadLine();
            return ChampionName;
        }
        public int getChampion()
        {
            switch (getPlayerChampion())
            {
                case "0":
                    ChampionNumber = 0;
                    return ChampionNumber;
                case "1":
                    ChampionNumber = 1;
                    return ChampionNumber;
                case "2":
                    ChampionNumber = 2;
                    return ChampionNumber;
                case "3":
                    ChampionNumber = 3;
                    return ChampionNumber;
                case "4":
                    ChampionNumber = 4;
                    return ChampionNumber;
                default:
                    Text.PleaseTryAgain();
                    Text.askForChampionName();
                    return getChampion();
                    

            }
        }
        public int setChampion()
        {
            champion = ChampionNumber;
            return champion;
        }
    }
}
