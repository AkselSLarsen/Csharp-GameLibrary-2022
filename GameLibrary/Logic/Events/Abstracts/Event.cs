using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Abstracts {
    public abstract class Event : IEvent {
        private ulong _id;

        protected Event() {
            _id = IHasID.NextID();
        }

        public ulong ID => _id;

        public abstract void Run();
    }
}
