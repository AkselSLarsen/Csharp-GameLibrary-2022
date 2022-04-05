using GameLibrary.Entities;
using GameLibrary.Logic;
using GameLibrary.Logic.Events.Abstracts;
using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util.Interfaces;
using GameLibrary.World.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.World {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IWorld : ITickable {
        public IHandler<IRegion> Regions { get; }
        public IHandler<Event> Events { get; }
    }
}