using GameLibrary.Actions;
using GameLibrary.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Entities.Actors {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IActor : ITickable, IEntity {

        public IReadOnlyList<IAction> Actions { get; }

    }
}
