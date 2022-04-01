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
        public bool Stop { get; set; }
        public bool Pause { get; set; }
        public IWorld World { get; protected set; }
        public InputHandler InputHandler { get; protected set; }
        public Window MainWindow { get; protected set; }

        public Game(string settingsFilePath, Window mainWindow, InputHandler inputHandler, IWorld world) {
            SettingsLoader.LoadSettings(settingsFilePath);
            MainWindow = mainWindow;
            InputHandler = inputHandler;
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
                InputHandler.CatchInputs(this, MainWindow);
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