using GameLibrary.Settings;
using GameLibrary.Util;
using GameLibrary.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameLibrary.UI.Visuals.Drawables {
    public abstract class Drawable : IDrawable {
        private ulong _id;
        private Action _draw;
        
        public Drawable(IDrawer drawer) {
            switch(GraphicsSettings.VisualType) {
                case VisualTypes.Unset:
                    throw new SettingsException("Drawable class: Cannot create instance before settings are loaded.");
                case VisualTypes.ASCII:
                    _draw = ASCIIDraw();
                    break;
                case VisualTypes.Winforms:
                    _draw = WinformsDraw();
                    break;
            }          
            
            _id = IHasID.NextID();
            drawer.Drawables.Add(this);
        }

        public ulong ID { get { return _id; } }

        public abstract Position ViewPosition { get; }

        public void Draw() {
            _draw.Invoke();
        }

        /// <summary>
        /// Used by ASCII graphics.
        /// </summary>
        /// <returns>The desired char to write in the console.</returns>
        protected abstract char GetChar();
        /// <summary>
        /// Used by ASCII graphics.
        /// </summary>
        /// <returns>The color of the desired char to be written in the console.</returns>
        protected abstract ConsoleColor GetColor();
        /// <summary>
        /// Used by Winforms graphics.
        /// </summary>
        /// <returns>The Graphics object used by Winforms.</returns>
        protected abstract Graphics GetGraphics();
        /// <summary>
        /// Used by Winforms graphics.
        /// </summary>
        /// <returns>The shape of the drawable.</returns>
        protected abstract Position[] GetShape();
        /// <summary>
        /// Used by Winforms graphics.
        /// </summary>
        /// <returns>The brush used to draw the drawable.</returns>
        protected abstract Brush GetBrush();

        private Action ASCIIDraw() {
            return new Action(() => {
                Console.ForegroundColor = GetColor();
                Console.Write(GetChar());
            });
        }

        // Platform validation is taken care of in GraphicsSettings.
#pragma warning disable CA1416 // Validate platform compatibility
        private Action WinformsDraw() {
            return new Action(() => {
                PointF[] shape = new PointF[GetShape().Length];
                for(int i=0; i<shape.Length; i++) {
                    shape[i] = GetShape()[i]+ViewPosition;
                }

                GetGraphics().FillPolygon(GetBrush(), shape);
            });
        }
#pragma warning restore CA1416 // Validate platform compatibility
    }
}
