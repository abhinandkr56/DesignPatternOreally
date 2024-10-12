
public class PaidState : IState{
    public SubscriptionManger _manager;

    public PaidState(SubscriptionManger manger){
        _manager = manger;
    }

    public void Expire()
    {
        _manager.currentState = new TrialExpiredState(_manager);
    }

    public void Pay()
    {
        throw new NotImplementedException();
    }
}