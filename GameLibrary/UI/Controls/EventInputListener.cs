using GameLibrary.Logic.Events;
using GameLibrary.Logic.Events.Abstracts;
using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    public class EventInputListener : InputListener {
        private Event _evt;
        private IHandler<Event> _target;

        public EventInputListener(InputKeys key, ModifierKeys mods, Event evt, IHandler<Event> target) : base(key, mods) {
            _evt = evt;
            _target = target;
        }

        public override void OnInput(IInput input) {
            _target.Add(_evt);
        }
    }
}