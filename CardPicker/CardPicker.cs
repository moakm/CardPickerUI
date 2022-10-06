using System;

namespace CardPickerUI
{
    public class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            CardPicker picker = new CardPicker();
            string[] deck = new string[52];
            //string[] numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
            string[] drawnCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                drawnCards[i] = RandomValue() + " " + RandomSuit();
            }

            return drawnCards;
        }

        private static string RandomSuit()
        {
            CardSuit suit = (CardSuit)random.Next(1, 5);
            return suit.ToString();            
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if(value == 1) { return "As"; }
            if(value == 11) { return "Walet"; }
            if(value == 12) { return "Dama"; }
            if(value == 13) { return "Krol"; }
            return value.ToString();
        }
    }
}
