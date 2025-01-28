namespace DeckOfCards;

public class Dealer
{
    private Deck _deck;

    public Dealer(Deck deck)
    {
        _deck = deck;
        _deck.Shuffle();
    }
    public void DealCards(Player player, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Card card = _deck.GetCard();
            if (card != null)
            {
                player.ReceiveCard(card);
            }
            else
            {
                Console.WriteLine("Карты в колоде закончились.");
                break;
            }
        }
    }
}