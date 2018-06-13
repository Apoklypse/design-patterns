namespace DesignPatterns.Patterns.Behavioural.State
{
    public class GameContext
    {
        public GameContext()
        {
            this.State = new BeginState();
        }

        public IState State { get; set; }

        public void EndPhase()
        {
            this.State.EndPhase(this);
        }
    }
}