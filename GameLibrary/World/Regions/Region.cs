using GameLibrary.Entities;
using GameLibrary.Logic;
using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.World.Regions {
    public class Region : IRegion {
        private ulong _id;
        private IHandler<IEntity> _entities;
        private IHandler<IRegionalEvent> _events;
        private Position _position;
        private IWorld _world;

        public Region(Position position, IWorld world) {
            _id = IHasID.NextID();
            _entities = new Handler<IEntity>();
            _events = new Handler<IRegionalEvent>();

            _position = position;
            _world = world;
        }

        public ulong ID { get { return _id; } }
        public IHandler<IEntity> Entities { get { return _entities; } }
        public IHandler<IRegionalEvent> Events { get { return _events; } }
        public Position WorldPosition { get { return _position; } }
        public IWorld World { get { return _world; } }

        public void Tick() {
            List<IRegionalEvent> toRemove = new List<IRegionalEvent>();
            foreach (IRegionalEvent e in Events.GetAsList()) {
                e.Run();

                toRemove.Add(e);
            }
            foreach (IRegionalEvent e in toRemove) {
                Events.Remove(e.ID);
            }

            IReadOnlyCollection<IEntity> entities = Entities.GetAsList();
            Parallel.For(0, entities.Count, (i, loopState) => {
                if(entities.ElementAt(i) is ITickable) {
                    ITickable tickable = (ITickable)entities.ElementAt(i);
                    tickable.Tick();
                }
            });
        }

    }
}