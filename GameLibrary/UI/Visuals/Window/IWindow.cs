using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Visuals.Window {
    //Doesn't need documentation since it is internal.
    internal interface IWindow : IDrawer, IHasWorld {
        public Box ViewArea { get; }
    }
}
