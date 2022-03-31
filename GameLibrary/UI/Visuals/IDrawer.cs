using GameLibrary.Logic;
using GameLibrary.UI.Visuals.Drawables;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Visuals {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IDrawer : ITickable {
        public IHandler<IDrawable> Drawables { get; }
    
    }
}
