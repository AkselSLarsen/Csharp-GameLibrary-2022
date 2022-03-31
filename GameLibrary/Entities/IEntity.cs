using GameLibrary.Actions.Interactions;
using GameLibrary.UI.Visuals.Drawables;
using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Entities {
    /// <summary>
    /// The interface all entities must implement.
    /// In this context an entity is anything directly visable and/or interactable in the game world.
    /// An actor such as a creature roaming the world is an entity.
    /// An item laying on the ground waiting to be picked up is an entity.
    /// A wall that stops vision and/or movement is an entity.
    /// A menuscreen is NOT an entity because it is not in the game world.
    /// A visual effect like mist is NOT an entity becouse it is not directly visable,
    /// but mearly a visual effect. Unless of course the mist is not just a visual effect
    /// but a thematized wall.
    /// </summary>
    public interface IEntity : IDrawable, IHasRegionalPosition {
        public Box HitBox { get; }
        public IReadOnlyList<IInteraction> Interactions { get; }
    }
}
