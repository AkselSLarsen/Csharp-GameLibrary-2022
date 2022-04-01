using GameLibrary.Settings;
using GameLibrary.UI.Visuals.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public class InputHandler : IInputHandler {
        private static InputHandler _singleton;
        private Dictionary<(InputKeys, ModifierKeys), List<IInputListener>> _listeners;

        private InputHandler() {
            _listeners = new Dictionary<(InputKeys, ModifierKeys), List<IInputListener>>();
        }

        public static InputHandler Singleton {
            get {
                if(_singleton == null) {
                    _singleton = new InputHandler();
                }
                return _singleton;
            }
        }

        public IReadOnlyDictionary<(InputKeys, ModifierKeys), List<IInputListener>> Listeners => _listeners;

        public void AddInputListener(IInputListener listener) {
            if (Listeners[listener.ListensFor()] == null) {
                _listeners[listener.ListensFor()] = new List<IInputListener>();
            }
            _listeners[listener.ListensFor()].Add(listener);
        }

        public void CatchInputs(Game game, Window window) {
            switch (GraphicsSettings.VisualType) {
                case VisualTypes.Unset:
                    throw new SettingsException("Cannot handle inputs when visual type is unset.");
                case VisualTypes.ASCII:
                    CatchASCIIInputs(game, window);
                    break;
                case VisualTypes.Winforms:
                    CatchWinformsInputs(game, window);
                    break;
            }
        }

        protected virtual void CatchASCIIInputs(Game game, Window window) {
            while(!game.Stop) {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                // We run it in a task as an attempt to catch all inputs
                // regardless of how long the calculation of what to do with the input takes.
                Task.Run(() => {
                    HandleInput(IInputHandler.InputFromConsoleKeyInfo(keyInfo));
                });
            }
        }

        protected virtual void CatchWinformsInputs(Game game, Window window) {
            throw new NotImplementedException();
        }

        protected void HandleInput(IInput input) {
            if(Listeners[(input.Key, input.ModKeys)] != null) {
                foreach(IInputListener iil in Listeners[(input.Key, input.ModKeys)]) {
                    iil.OnInput(input);
                }
            }
        }
    }
}