using GameLibrary.Logic.Events;
using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    public class EventInputListener : InputListener {
        private IEvent _evt;
        private IHandler<IEvent> _target;

        public EventInputListener(InputKeys key, ModifierKeys mods, IEvent evt, IHandler<IEvent> target) : base(key, mods) {
            _evt = evt;
            _target = target;
        }

        public override void OnInput(IInput input) {
            _target.Add(_evt);
        }
    }
}