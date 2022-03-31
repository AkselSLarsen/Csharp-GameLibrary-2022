using GameLibrary.Logic.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IInputListener {
        public (InputKeys, ModifierKeys) ListensFor();
        public void OnInput(IInput input);
    }
}
