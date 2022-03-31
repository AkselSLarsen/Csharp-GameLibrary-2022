using GameLibrary.Actions.Interactions;
using GameLibrary.UI.Visuals.Drawables;
using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using GameLibrary.World.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Entities {
    public abstract class Entity : IEntity {
        private ulong _id;
        private IReadOnlyList<IInteraction> _interactions;
        private Box _hitBox;
        private Position _regionalPosition;
        private IRegion _region;
        private IDrawable _drawable;

        public Entity(List<IInteraction> interactions, Box hitBox, Position regionalPosition, IRegion region, IDrawable drawable) {
            _id = IHasID.NextID();
            _interactions = interactions;
            _hitBox = hitBox;
            _regionalPosition = regionalPosition;
            _region = region;
            _drawable = drawable;
        }

        public ulong ID => _id;
        public IReadOnlyList<IInteraction> Interactions => _interactions;
        public Box HitBox => _hitBox;
        public Position ViewPosition => _drawable.ViewPosition;
        public Position RegionalPosition => _regionalPosition;
        public IRegion Region => _region;

        public void Draw() {
            _drawable.Draw();
        }
    }
}
