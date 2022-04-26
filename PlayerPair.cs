using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodMatchApp
{
    //PlayerPair object class used when ordering player pairs by match %
    public class PlayerPair
    {
        //Playerpair parameterized constructor
        public PlayerPair(string playerOneName, string playerTwoName, int playerMatch)
        {
            this.playerOneName = playerOneName;
            this.playerTwoName = playerTwoName;
            this.playerMatch = playerMatch;
        }

        //PlayerPair propeties
        public String playerOneName { get; set; }

        public String playerTwoName { get; set; }

        public int playerMatch { get; set; }

    }
}
