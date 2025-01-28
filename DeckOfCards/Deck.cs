namespace DeckOfCards;

public class Deck
{
    private List<Card> _cards = new List<Card>();
    private Random _random = new Random();

    public Deck()
    {
        string[] suits = { "♥", "♦", "♣", "♠" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "ВАЛЕТ", "ДАМА", "КОРОЛЬ", "ТУЗ" };

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                _cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        for (int i = _cards.Count - 1; i > 0; i--)
        {
            int j = _random.Next(0, i + 1);
            (_cards[i], _cards[j]) = (_cards[j], _cards[i]);
        }
    }

    public Card GetCard()
    {
        if (_cards.Count == 0)
        {
            Console.WriteLine("Колода пуста");
            return null;
        }
        
        Card card = _cards[0];
        _cards.RemoveAt(0);
        return card;
    }
}