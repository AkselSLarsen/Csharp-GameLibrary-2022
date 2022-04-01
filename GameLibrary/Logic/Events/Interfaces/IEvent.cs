﻿using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Interfaces {
    /// <summary>
    /// Events represents a desired change to the state of the gameworld.
    /// Instead of changing the game data directly, it allows more versitility to create an event,
    /// that can be listened for and even changed or discarded if needed.
    /// </summary>
    public interface IEvent : IHasID, IRunnable {

    }
}
