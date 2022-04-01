using GameLibrary.Logic.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    public class EventInputListener : IInputListener {
        private InputKeys _key;
        private ModifierKeys _mods;
        private IEvent _evt;

        public EventInputListener(InputKeys key, ModifierKeys mods, IEvent evt) {
            _key = key;
            _mods = mods;
            _evt = evt;
        }

        public (InputKeys, ModifierKeys) ListensFor() {
            return (_key, _mods);
        }

        public void OnInput(IInput input) {
            _evt.Run();
        }
    }
}