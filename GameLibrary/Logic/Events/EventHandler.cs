using GameLibrary.Logic.Events.Abstracts;
using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public class EventHandler : IEventHandler {
        private static EventHandler _singleton;
        private List<EventListener> _eventListeners;

        private EventHandler() {
            _eventListeners = new List<EventListener>();
        }

        public static EventHandler Singleton {
            get {
                if (_singleton == null) {
                    _singleton = new EventHandler();
                }
                return _singleton;
            }
        }

        public IReadOnlyList<EventListener> Listeners { get; }

        public void AddListener(EventListener listener) {
            _eventListeners.Add(listener);
        }
        public void RemoveListener(EventListener listener) {
            _eventListeners.Remove(listener);
        }
    }
}
