public class Card : ICardComponent{
    protected readonly string _name;
    protected readonly int _attack;
    protected readonly int _defence;

    public Card(string name, int attack, int defense){
        _name = name;
        _attack = attack;
        _defence = defense;
    }

    public void Add(ICardComponent cardComponent)
    {
        throw new NotImplementedException();
    }

    public string Display()
    {
       return _name;
    }

    public ICardComponent Get(int index)
    {
        throw new NotImplementedException();
    }

    public bool Remove(ICardComponent cardComponent)
    {
        throw new NotImplementedException();
    }
}