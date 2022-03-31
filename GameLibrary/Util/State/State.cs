using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Util.State {
    public class State : IHasID, IRunnable {
        private ulong _id;
        private IList<StateTransition> _transitions;
        private Action _action;
        public ulong ID { get { return _id; } }
        public IList<StateTransition> Transitions { get { return _transitions; } }

        public State(IList<StateTransition> transitions, Action action) {
            _id = IHasID.NextID();
            _transitions = transitions;
            _action = action;
        }

        public void Run() {
            _action.Invoke();
        }
    }
}
