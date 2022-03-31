using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events {
    public class EventHandler<E> : IEventHandler<E> where E : IEvent {
        private List<IEventListener<E>> _eventListeners;
        public IReadOnlyList<IEventListener<E>> Listeners { get { return _eventListeners; } }
        public IHandler<E> Events { get; }

        public EventHandler() {
            _eventListeners = new List<IEventListener<E>>();
            Events = new Handler<E>();
        }

        public void AddListener(IEventListener<E> listener) {
            _eventListeners.Add(listener);
        }
    }
}
