using CS4125.Data.UserData;

namespace CS4125.Data.Finance.State;

public class Context
{
    private State _state;

    // Constructor
    public Context(State state)
    {
        this._state = state;
    }

    // Gets or sets the state
    public State State
    {
        get => _state;
        set
        {
            _state = value;
            Console.WriteLine("State: " + _state.GetType().Name);
        }
    }

    public void Request()
    {
        //change state based on tier bronze silver or gold
        State = State.Tier switch
        {
            Tier.Bronze => new BronzeTierSub(State),
            Tier.Silver => new SilverTierSub(State),
            Tier.Gold => new GoldTierSub(State),
            _ => new BronzeTierSub(State)
        };
    }
    //handle
    public void Handle()
    {
        State.Handle(this);
    }
}