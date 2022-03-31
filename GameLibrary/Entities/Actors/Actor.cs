using GameLibrary.Actions;
using GameLibrary.Actions.Interactions;
using GameLibrary.UI.Visuals.Drawables;
using GameLibrary.Util;
using GameLibrary.World;
using GameLibrary.World.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Entities.Actors {
    public abstract class Actor : Entity, IActor {
        private IReadOnlyList<IAction> _actions;

        public Actor(List<IInteraction> interactions, List<IAction> actions, Box hitBox, Position regionalPosition, IRegion region, IDrawable drawable) : base(interactions, hitBox, regionalPosition, region, drawable) {
            _actions = actions;
        }

        public IReadOnlyList<IAction> Actions => _actions;

        public abstract void Tick();
    }
}
