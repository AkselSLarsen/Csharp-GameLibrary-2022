using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Util.State {
    public class StateTransition {
        private Func<bool> _shouldChangeState;
        public State TargetState { get; set; }

        public StateTransition(State targetState, Func<bool> shouldChangeState) {
            TargetState = targetState;
            _shouldChangeState = shouldChangeState;
        }
        
        public bool ShouldChangeState() {
            if(_shouldChangeState.Invoke()) {
                return true;
            }
            return false;
        }
    }
}
