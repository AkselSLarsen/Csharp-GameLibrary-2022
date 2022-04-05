using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Abstracts {
    /// <summary>
    /// Events represents a desired change to the state of the gameworld.
    /// Instead of changing the game data directly, it allows more versitility to create an event,
    /// that can be listened for and even changed or discarded if needed.
    /// </summary>
    public abstract class Event : IEvent {
        private ulong _id;

        protected Event() {
            _id = IHasID.NextID();
        }

        public ulong ID => _id;
        public bool Cancel { get; set; }

        public void Run() {
            EventHandler.Singleton.OnEventRun(this);
            if(!Cancel) {
                EventEffect();
            }
        }
        protected abstract void EventEffect();
    }
}
