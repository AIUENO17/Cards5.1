using System.Collections;
using System.Collections.Generic;


public class Card 
{
    public enum Suit
    {
        Invalide = -1,

        Club,
        Dia,
        Heart,
        Spade,

        Max
    }


    public Suit CardSuit = Suit.Invalide;

    public int Number = 0;



    public Card(Suit suit, int number)
    {

        this.CardSuit = suit;

        this.Number = number;
    }
   
        
    
}
