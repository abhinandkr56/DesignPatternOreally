public interface ICardComponent{
    void Add(ICardComponent cardComponent);
    ICardComponent Get(int index);
    bool Remove(ICardComponent cardComponent);

    string Display();
}