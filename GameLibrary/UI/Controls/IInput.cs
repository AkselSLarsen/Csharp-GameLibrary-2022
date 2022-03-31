using GameLibrary.Entities;
using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.UI.Visuals.Window;
using GameLibrary.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IInput {
        public InputKeys Key { get; }
        public ModifierKeys ModKeys { get; }
        public Position MousePosition { get; }
        public IEntity SelectedEntity { get; }
        public Window ActiveWindow { get; }
        public DateTime TimeStamp { get; }
    }
}
