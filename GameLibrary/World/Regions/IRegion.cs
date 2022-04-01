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
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IRegion : IHasWorldPosition, ITickable, IHasID {
        public IHandler<IEntity> Entities { get; }
        public IHandler<IEvent> Events { get; }
    }
}
