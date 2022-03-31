using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Util.State {
    public class StateMachine {
        public IHandler<State> States { get; }
        public State CurrentState { get; protected set; }

        public StateMachine() {
            States = new Handler<State>();
        }

        public State GetState() {
            if(CurrentState == null) {
                if(States.GetAsList().Count == 0) {
                    throw new Exception("StateMachine class: Cannot get the CurrentState of a stateless StateMachine object.");
                }
                CurrentState = States.GetAsList().ElementAt(0);
            }
            return CurrentState;
        }

        public void TryChangeState() {
            foreach(StateTransition transition in GetState().Transitions) {
                if(transition.ShouldChangeState()) {
                    CurrentState = transition.TargetState;
                    return;
                }
            }
        }

    }
}
