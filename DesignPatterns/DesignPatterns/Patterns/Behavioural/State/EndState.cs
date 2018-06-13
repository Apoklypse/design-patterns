using System;

namespace DesignPatterns.Patterns.Behavioural.State
{
    internal class EndState : IState
    {
        public void EndPhase(GameContext context)
        {
            Console.WriteLine("End Turn");
        }
    }
}