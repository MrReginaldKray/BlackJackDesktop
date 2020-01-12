using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDesktop
{
    public class CChips
    {
        private int coins;

        protected CChips()
        {
            coins = 500;
        }

        protected int getCoins()
        {
            return coins;
        }

        protected void setCoins(int coins)
        {
            if (coins > this.coins)
            {
                this.coins = coins;
            }
        }

        protected void decreaseCoins(int value)
        {
            coins -= value;
        }

        protected void addCoins(int value)
        {
            if (value >= 10)
            {
                coins += value;
            }
        }
    }
}
