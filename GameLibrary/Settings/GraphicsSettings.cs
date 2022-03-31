using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Settings {
    //Doesn't need documentation since it is internal.
    internal static class GraphicsSettings {
        private static VisualTypes _visualType = VisualTypes.Unset;
        internal static VisualTypes VisualType {
            get {
                if(_visualType == VisualTypes.Unset) {
                    throw new SettingsException("VisualType must be set before using graphics.");
                }
                return _visualType;
            }
            set {
                if(_visualType != VisualTypes.Unset) {
                    throw new SettingsException("VisualType cannot be changed after set.");
                }
                if(value == VisualTypes.Winforms) {
                    if (!Environment.GetEnvironmentVariable("OS").ToLower().Contains("windows")) { 
                        throw new SettingsException("Winform graphics are only supported on windows computers.");
                    }
                }
                _visualType = value;
            }
        }

    }
}
