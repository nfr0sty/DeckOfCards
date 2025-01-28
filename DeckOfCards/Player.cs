namespace DeckOfCards;

public class Player
{
    private List<Card> _playerCards = new List<Card>();

    public void ReceiveCard(Card card)
    {
        if (card != null)
        {
            _playerCards.Add(card);
        }
    }

    public void ShowCards()
    {
        Console.WriteLine($"Карты игрока:");
        foreach (var card in _playerCards)
        {
            Console.WriteLine($"{card.Rank} | {card.Suit}");
        }
    }
}