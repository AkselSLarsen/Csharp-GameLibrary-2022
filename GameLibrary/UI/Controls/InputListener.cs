using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    public abstract class InputListener : IInputListener {
        private InputKeys _key;
        private ModifierKeys _mods;

        public InputListener(InputKeys key, ModifierKeys mods) {
            _key = key;
            _mods = mods;
            Register();
        }

        public (InputKeys, ModifierKeys) ListensFor() {
            return (_key, _mods);
        }

        public abstract void OnInput(IInput input);

        private void Register() {
            InputHandler.Singleton.AddInputListener(this);
        }
    }
}
