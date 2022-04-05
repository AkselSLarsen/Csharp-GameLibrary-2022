using GameLibrary.UI.Controls;
using GameLibrary.UI.Visuals.Window;
using GameLibrary.Util.Interfaces;
using GameLibrary.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary {
    //Doesn't need documentation since it is internal.
    internal interface IGame : IHasWorld {
        public bool Stop { get; set; }
        public bool Pause { get; set; }
        public Window MainWindow { get; }
        public void Setup(string settingsFilePath, IWorld world, Window mainWindow);
        public void GameLoop(int tickFrequency = 500, int frameRate = 50);
    
    }
}
