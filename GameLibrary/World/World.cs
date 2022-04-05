using GameLibrary.Entities;
using GameLibrary.Logic.Events.Abstracts;
using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Settings;
using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using GameLibrary.World.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.World {
    public class World : IWorld {
        private IHandler<IRegion> _regions;
        private IHandler<Event> _events;

        public IHandler<IRegion> Regions { get { return _regions; } }
        public IHandler<Event> Events { get { return _events; } }

        public World() {
            _regions = new Handler<IRegion>();
            _events = new Handler<Event>();
        }

        public void Tick() {
            List<IEvent> toRemove = new List<IEvent>(); 
            foreach (IEvent e in Events.GetAsList()) {
                e.Run();

                toRemove.Add(e);
            }
            foreach (IEvent e in toRemove) {
                Events.Remove(e.ID);
            }

            IReadOnlyCollection<IRegion> regions = Regions.GetAsList();
            Parallel.For(0, regions.Count, (i, loopState) => {
                regions.ElementAt(i).Tick();
            });
        }
    }
}
