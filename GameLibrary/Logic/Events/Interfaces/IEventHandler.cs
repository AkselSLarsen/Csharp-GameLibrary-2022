using GameLibrary.Logic.Events.Abstracts;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Interfaces {
    internal interface IEventHandler {
        public IReadOnlyList<EventListener> Listeners { get; }
        public void AddListener(EventListener listener);
        public void RemoveListener(EventListener listener);
    }
}
