using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDesktop
{
    public class CCardDeck
    {
        private int[,] cardDeck;
        private int remainingCards;

        public CCardDeck()
        {
            remainingCards = 52;

            cardDeck = new int[13, 5]   
            {
                {1 , 1, 2, 3, 4}, //Ass, Heart, Diamond, Spade, Club
                {2 , 1, 2, 3, 4}, //Two, Heart, Diamond, Spade, Club
                {3 , 1, 2, 3, 4}, //Three, Heart, Diamond, Spade, Club
                {4 , 1, 2, 3, 4}, //Four, Heart, Diamond, Spade, Club
                {5 , 1, 2, 3, 4}, //Five, Heart, Diamond, Spade, Club
                {6 , 1, 2, 3, 4}, //Six, Heart, Diamond, Spade, Club
                {7 , 1, 2, 3, 4}, //Seven, Heart, Diamond, Spade, Club
                {8 , 1, 2, 3, 4}, //Eight, Heart, Diamond, Spade, Club
                {9 , 1, 2, 3, 4}, //Nine, Heart, Diamond, Spade, Club
                {10, 1, 2, 3, 4}, //Ten, Heart, Diamond, Spade, Club
                {11, 1, 2, 3, 4}, //Jacks, Heart, Diamond, Spade, Club
                {12, 1, 2, 3, 4}, //Queens, Heart, Diamond, Spade, Club
                {13, 1, 2, 3, 4}  //Kings, Heart, Diamond, Spade, Club
            };
        }

        int getRemainingCards()
        {
            return remainingCards;
        }

        void decreaseRemainingCards()
        {
            remainingCards--;
        }

        int[,] getCardFromDeck()
        {
            //The randomly chosen card
            int[,] card = new int[1, 1];
            int randomNumber;
            int cardNumber;
            int cardSymbol;
            
            do
            {
                //Pick a random number and transfer it to randomNumber
                Random random = new Random();
                randomNumber = random.Next(0, 13);

                //Check if this card Number is available
                if (cardDeck[randomNumber, 0] != 0)
                {
                    //Choose randomNumber as cardNumber
                    cardNumber = randomNumber + 1;

                    do
                    {
                        //Generate a new randomNumber for pik(1), heart(2), cross(3), check(4)
                        randomNumber = random.Next(1, 5);
                        
                        //Check if a combination of a cardNumber and cardSymbol is available
                        if (cardDeck[cardNumber - 1, randomNumber] != 0)
                        {
                            //Choose randomNumber as cardSymbol
                            cardSymbol = randomNumber;

                            //Mark the choosen cardNumber and cardSymbol combination as taken
                            cardDeck[cardNumber - 1, cardSymbol] = 0;

                            //Check if this combination was the latest available combination with the cardNumber
                            //If so mark the cardNumber in the deck as taken with a 0
                            if (cardDeck[cardNumber - 1, 1] == 0 &&
                                cardDeck[cardNumber - 1, 2] == 0 &&
                                cardDeck[cardNumber - 1, 3] == 0 &&
                                cardDeck[cardNumber - 1, 4] == 0)
                            {
                                cardDeck[cardNumber - 1, 0] = 0;
                            }

                            break;
                        }

                    } while (true);

                    break;
                }

            } while (true);

            //Reduce the number of cards in the deck
            decreaseRemainingCards();

            //Prepare the card with the cardNumber and cardSymbol
            card[0,0] = cardNumber;
            card[0, 1] = cardSymbol;

            return card;
        }
    }
}
