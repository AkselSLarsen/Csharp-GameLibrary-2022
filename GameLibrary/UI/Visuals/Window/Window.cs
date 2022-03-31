using GameLibrary.Settings;
using GameLibrary.UI.Visuals.Drawables;
using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using GameLibrary.World;
using System;

namespace GameLibrary.UI.Visuals.Window {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public class Window : IWindow {
        private Box _viewArea;
        private IHandler<IDrawable> _drawables;
        private IWorld _world;

        public Window(IWorld world, Box viewArea) {
            _world = world;
            _viewArea = viewArea;

            _drawables = new Handler<IDrawable>();
        }

        public Box ViewArea => _viewArea;
        public IHandler<IDrawable> Drawables => _drawables;
        public IWorld World => _world;
        public void Tick() {
            switch (GraphicsSettings.VisualType) {
                case VisualTypes.Unset:
                    throw new SettingsException("Graphical settings are unset.");
                case VisualTypes.ASCII:
                    TickASCII();
                    break;
                case VisualTypes.Winforms:
                    TickWinforms();
                    break;
            }
        }

        protected virtual void TickASCII() {
            (int x, int y) = WindowSize();
            Action[][] drawActions = new Action[x][];
            for (int i = 0; i < x; i++) {
                drawActions[i] = new Action[y];
            }
            Action drawSpace = DrawSpace();
            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    drawActions[x][y] = drawSpace;
                }
            }
            foreach (IDrawable drawable in Drawables.GetAsList()) {
                Position p = drawable.ViewPosition;
                drawActions
                    [(int)Math.Floor(p.PosX)]
                    [(int)Math.Floor(p.PosY)] =
                () => {
                    drawable.Draw();
                };
            }

            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    drawActions[x][y].Invoke();
                }
                Console.WriteLine();
            }
        }

        private Action DrawSpace() {
            return () => {
                Console.Write(" ");
            };
        }

        protected virtual void TickWinforms() {
            foreach(IDrawable drawable in Drawables.GetAsList()) {
                drawable.Draw();
            }
        }

        public (int x, int y) WindowSize() {
            (float fx, float fy, _) = ViewArea.Size();
            return ((int)Math.Floor(fx),
                (int)Math.Floor(fy));
        }
    }
}