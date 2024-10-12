public class TrialExpiredState : IState
{
    public SubscriptionManger _manager;

    public TrialExpiredState(SubscriptionManger manger){
        _manager = manger;
    }
    public void Expire()
    {
        throw new NotImplementedException();
    }

    public void Pay()
    {
        throw new NotImplementedException();
    }
}