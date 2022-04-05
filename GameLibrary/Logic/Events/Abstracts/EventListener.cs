using GameLibrary.Logic.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Abstracts {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public abstract class EventListener : IEventListener<Event> {
        public EventListener() {
            Register();
        }

        public abstract Type EventType { get; }

        public abstract void OnEvent(Event evt);

        public void Register() {
            EventHandler.Singleton.AddListener(this);
        }
    }
}