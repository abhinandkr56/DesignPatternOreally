public class OnTrial : IState
{
    public SubscriptionManger _manager;

    public OnTrial(SubscriptionManger manger){
        _manager = manger;
    }
    public void Expire()
    {
        throw new NotImplementedException();
    }

    public void Pay()
    {
        _manager.currentState = new PaidState(_manager);
    }
}