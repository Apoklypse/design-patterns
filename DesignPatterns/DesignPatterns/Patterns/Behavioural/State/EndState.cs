using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.State
{
    class EndState : IState
    {
        public void EndPhase(GameContext context)
        {
            Console.WriteLine("End Turn");
        }
    }
}
