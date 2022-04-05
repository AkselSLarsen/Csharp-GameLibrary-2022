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
        private Dictionary<Type, List<EventListener>> _eventListeners;
        private List<Event> _events;

        private EventHandler() {
            _eventListeners = new Dictionary<Type, List<EventListener>>();
        }

        public static EventHandler Singleton {
            get {
                if (_singleton == null) {
                    _singleton = new EventHandler();
                }
                return _singleton;
            }
        }

        public IReadOnlyDictionary<Type, List<EventListener>> Listeners => _eventListeners;
        public IReadOnlyList<Event> Events => _events;

        public void AddListener(EventListener listener) {
            if(!_eventListeners.ContainsKey(listener.EventType)) {
                _eventListeners.Add(listener.EventType, new List<EventListener>());
            }
            _eventListeners[listener.EventType].Add(listener);
        }
        public void RemoveListener(EventListener listener) {
            if (!_eventListeners.ContainsKey(listener.EventType)) {
                _eventListeners.Add(listener.EventType, new List<EventListener>());
            }
            _eventListeners[listener.EventType].Remove(listener);
        }
        public void AddEvent(Event evt) {
            _events.Add(evt);
        }

        public void OnEventRun(Event evt) {
            _eventListeners[evt.GetType()].ForEach((eventListener) => {
                eventListener.OnEvent(evt);
            });
        }
    }
}
