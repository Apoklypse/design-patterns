namespace DesignPatterns.Patterns.Behavioural.State
{
    public class GameContext
    {
        public IState State { get; set; }

        public GameContext()
        {
            this.State = new BeginState();
        }

        public void EndPhase()
        {
            this.State.EndPhase(this);
        }
    }
}
