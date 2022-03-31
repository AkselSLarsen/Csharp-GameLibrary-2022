using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Util.Interfaces {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IHasWorldPosition : IHasWorld {
        public Position WorldPosition { get; }
    }
}
