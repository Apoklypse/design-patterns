using System;

namespace DesignPatterns.Patterns.Behavioural.State
{
    public class PostCombatState : IState
    {
        public void EndPhase(GameContext context)
        {
            Console.WriteLine("Post-Combat");
            context.State = new EndState();
        }
    }
}