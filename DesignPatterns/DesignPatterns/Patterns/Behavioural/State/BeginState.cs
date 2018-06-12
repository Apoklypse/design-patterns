using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.State
{
    public class BeginState : IState
    {
        public void EndPhase(GameContext context)
        {
            Console.WriteLine("Begin Turn");
            context.State = new PreCombatState();
        }
    }
}
