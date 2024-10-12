using System.Text;

public class CardDeck : ICardComponent
{
    private List<ICardComponent> _cardComponents = new();

    public void Add(ICardComponent cardComponent)
    {
        _cardComponents.Add(cardComponent);
    }

    public string Display()
    {
       StringBuilder sb = new StringBuilder();

        foreach (var item in _cardComponents)
        {
            sb.Append(item.Display());
            sb.Append(" ");
        }

        return sb.ToString().Trim();
    }

    public ICardComponent Get(int index)
    {
        return _cardComponents[index];
    }

    public bool Remove(ICardComponent cardComponent)
    {
        return _cardComponents.Remove(cardComponent);
    }
}