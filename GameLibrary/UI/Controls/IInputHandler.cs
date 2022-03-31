using GameLibrary.Entities;
using GameLibrary.Logic;
using GameLibrary.UI.Visuals.Window;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    internal interface IInputHandler {
        public Dictionary<(InputKeys, ModifierKeys), List<IInputListener>> Listeners { get; }
        public void AddInputListener(IInputListener listener);
        public void CatchInputs(Game game, Window window);

        public static IInput InputFromConsoleKeyInfo(ConsoleKeyInfo keyInfo) {
            InputKeys key = InputKeyFromConsoleKey(keyInfo.Key);
        }
        public static InputKeys InputKeyFromConsoleKey(ConsoleKey key) {
            switch(key) {
                #region ConsoleKey to InputKeys mapping
                #region letters
                case ConsoleKey.A:
                    return InputKeys.A;
                case ConsoleKey.B:
                    return InputKeys.B;
                case ConsoleKey.C:
                    return InputKeys.C;
                case ConsoleKey.D:
                    return InputKeys.D;
                case ConsoleKey.E:
                    return InputKeys.E;
                case ConsoleKey.F:
                    return InputKeys.F;
                case ConsoleKey.G:
                    return InputKeys.G;
                case ConsoleKey.H:
                    return InputKeys.H;
                case ConsoleKey.I:
                    return InputKeys.I;
                case ConsoleKey.J:
                    return InputKeys.J;
                case ConsoleKey.K:
                    return InputKeys.K;
                case ConsoleKey.L:
                    return InputKeys.L;
                case ConsoleKey.M:
                    return InputKeys.M;
                case ConsoleKey.N:
                    return InputKeys.N;
                case ConsoleKey.O:
                    return InputKeys.O;
                case ConsoleKey.P:
                    return InputKeys.P;
                case ConsoleKey.Q:
                    return InputKeys.Q;
                case ConsoleKey.R:
                    return InputKeys.R;
                case ConsoleKey.S:
                    return InputKeys.S;
                case ConsoleKey.T:
                    return InputKeys.T;
                case ConsoleKey.U:
                    return InputKeys.U;
                case ConsoleKey.V:
                    return InputKeys.V;
                case ConsoleKey.W:
                    return InputKeys.W;
                case ConsoleKey.X:
                    return InputKeys.X;
                case ConsoleKey.Y:
                    return InputKeys.Y;
                case ConsoleKey.Z:
                    return InputKeys.Z;
                #endregion

                #endregion
                default:
#warning should be implemented before release
                    throw new NotImplementedException();
            }
        }
    }
}
