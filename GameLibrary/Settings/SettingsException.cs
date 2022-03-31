using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Settings {
    /// <summary>
    /// An exception type thrown when something in the settings prevents an attempted action.
    /// </summary>
    public class SettingsException : Exception {
        public SettingsException() : base() { }
        public SettingsException(string message) : base(message) { }
    }
}
