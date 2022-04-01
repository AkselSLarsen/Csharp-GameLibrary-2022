using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Abstracts {
    public class Event : IEvent {
        private ulong _id;
        private Action _action;

        public Event(Action action) {
            _id = IHasID.NextID();
            _action = action;
        }

        public ulong ID => _id;

        public void Run() {
            _action.Invoke();
        }
    }
}
