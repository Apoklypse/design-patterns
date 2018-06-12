using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.State
{
    public interface IState
    {
        void EndPhase(GameContext context);
    }
}
