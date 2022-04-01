using GameLibrary.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Entities.Actors {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IControlableActor : IActor {
        public IReadOnlyList<EventInputListener> Listeners { get; }
        public void AddListener(EventInputListener listener);
    }
}
