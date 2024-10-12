public class SubscriptionManger{
    public IState currentState;

    public SubscriptionManger()
    {
        currentState = new OnTrial(this);
    }
}