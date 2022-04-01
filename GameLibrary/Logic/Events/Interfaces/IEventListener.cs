using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events.Interfaces {
    internal interface IEventListener {
        public Func<IEvent, bool> ListensFor();
        public void OnEvent(IEvent evt);
    }
}
