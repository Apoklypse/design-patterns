using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.State
{
    public class CombatState : IState
    {
        public void EndPhase(GameContext context)
        {
            Console.WriteLine("Combat");
            context.State = new PostCombatState();
        }
    }
}
