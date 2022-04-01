using GameLibrary.Interactions;
using GameLibrary.UI.Controls;
using GameLibrary.UI.Visuals.Drawables;
using GameLibrary.Util;
using GameLibrary.World.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Entities.Actors {
    public abstract class ControlableActor : Entity, IControlableActor {
        private List<IInputListener> _listeners;

        protected ControlableActor(List<IInteraction> interactions, Box hitBox, Position regionalPosition, IRegion region, IDrawable drawable, List<IInputListener> listeners) : base(interactions, hitBox, regionalPosition, region, drawable) {
            _listeners = listeners;
        }

        public IReadOnlyList<EventInputListener> Listeners => Listeners;

        public void AddListener(EventInputListener listener) {
            _listeners.Add(listener);
        }

        public abstract void Tick();
    }
}
