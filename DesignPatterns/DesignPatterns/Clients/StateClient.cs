﻿using DesignPatterns.Patterns.Behavioural.State;
using DesignPatterns.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Clients
{
    public class StateClient : Client
    {
        public StateClient()
        {
            this.Name = "State";
            this.Category = PatternCategories.Behavioural;
        }

        protected override void PerfomAction()
        {
            var context = new GameContext();
            context.EndPhase();
            context.EndPhase();
            context.EndPhase();
            context.EndPhase();
            context.EndPhase();
        }
    }
}
