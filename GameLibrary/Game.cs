using GameLibrary.Settings;
using GameLibrary.UI.Controls;
using GameLibrary.UI.Visuals.Window;
using GameLibrary.World;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameLibrary {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public class Game : IGame {
        private static Game _singleton;

        private Game() { }

        public bool Stop { get; set; }
        public bool Pause { get; set; }
        public IWorld World { get; protected set; }
        public Window MainWindow { get; protected set; }

        public static Game Singleton {
            get {
                if (_singleton == null) {
                    throw new Exception("You must call Game.Setup(string, IWorld, Window) before using Game.Singleton.");
                }
                return _singleton;
            }
        }

        public void Setup(string settingsFilePath, IWorld world, Window mainWindow) {
            _singleton = new Game();

            SettingsLoader.LoadSettings(settingsFilePath);
            MainWindow = mainWindow;
            World = world;
        }

        public void GameLoop(int tickFrequency = 500, int frameRate = 50) {
            Task.Run(() => {
                while (!Stop) {
                    MainWindow.Tick();

                    Thread.Sleep(frameRate);
                }
            });

            Task.Run(() => {
                InputHandler.Singleton.CatchInputs(MainWindow);
            });
            
            while(!Stop) {
                if(!Pause) {
                    World.Tick();
                }

                Thread.Sleep(tickFrequency);
            }


        }
    }
}