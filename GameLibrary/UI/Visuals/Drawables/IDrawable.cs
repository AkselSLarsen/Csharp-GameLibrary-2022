using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Visuals.Drawables {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IDrawable : IHasID, IHasViewPosition {
        public abstract void Draw();
    }
}