using GameLibrary.Entities;
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
        private IHandler<IWorldEvent> _events;

        public IHandler<IRegion> Regions { get { return _regions; } }
        public IHandler<IWorldEvent> Events { get { return _events; } }

        public World() {
            _regions = new Handler<IRegion>();
        }

        public void Tick() {
            List<IWorldEvent> toRemove = new List<IWorldEvent>(); 
            foreach (IWorldEvent e in Events.GetAsList()) {
                e.Run();

                toRemove.Add(e);
            }
            foreach (IWorldEvent e in toRemove) {
                Events.Remove(e.ID);
            }


            IReadOnlyCollection<IRegion> regions = Regions.GetAsList();
            Parallel.For(0, regions.Count, (i, loopState) => {
                regions.ElementAt(i).Tick();
            });
        }
    }
}
