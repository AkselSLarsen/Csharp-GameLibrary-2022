using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Interfaces {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IEventHandler<E> where E : IEvent {
        public IHandler<E> Events { get; }
        public IReadOnlyList<IEventListener<E>> Listeners { get; }
        public void AddListener(IEventListener<E> listener);


        private static IEventHandler<E> EventHandler = null;
        public static IEventHandler<E> GetEventHandler() {
            if(EventHandler == null) {
                EventHandler = new EventHandler<E>();
            }
            return EventHandler;
        }
    }
}
