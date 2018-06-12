using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.State
{
    public class PreCombatState : IState
    {
        public void EndPhase(GameContext context)
        {
            Console.WriteLine("Pre-Combat");
            context.State = new CombatState();
        }
    }
}
