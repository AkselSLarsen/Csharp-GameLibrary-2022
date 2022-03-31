using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Entities.Objects {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IStructure : IEntity {
        public bool BlocksSight { get; }
        public bool BlocksMovement { get; }

    }
}
