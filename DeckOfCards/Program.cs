namespace DeckOfCards;

class Program
{
    static void Main(string[] args)
    {
        Dealer dealer = new Dealer(new Deck());
        Player player = new Player();

        Console.Write("Сколько карт раздать игроку? ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int cardCount) && cardCount > 0)
        {
            dealer.DealCards(player, cardCount);
            player.ShowCards();
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное положительное число.");
        }
    }
}