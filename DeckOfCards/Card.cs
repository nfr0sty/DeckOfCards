namespace DeckOfCards;

public class Card
{
    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }
    public string Suit{get; private set;} 
    public string Rank{get; private set;}

    public string GetCardInfo()
    {
        return $"{Suit} | {Rank}";
    }
}