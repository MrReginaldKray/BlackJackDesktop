using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDesktop
{
    public class CPlayer : CChips
    {
        private string playerName;

        public CPlayer()
        {
            playerName = "unknown";
        }

        void setPlayerName(string name)
        {
            if (name != "" || name[0] != ' ')
            {
                playerName = name;
            }
        }

        public CPlayer(string name, int coins)
        {
            setPlayerName(name);
            setCoins(coins);
        }

        string getPlayerName()
        {
            return playerName;
        }
    }
}
