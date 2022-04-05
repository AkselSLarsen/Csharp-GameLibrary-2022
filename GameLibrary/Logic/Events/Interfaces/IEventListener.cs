using GameLibrary.Logic.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Interfaces {
    internal interface IEventListener<E> where E : IEvent {
        public Type EventType { get; }
        public void OnEvent(E evt);
    }
}
