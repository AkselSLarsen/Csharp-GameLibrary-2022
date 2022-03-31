using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary.Settings {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public static class SettingsLoader {
        public static void LoadSettings(string settingsFilePath) {
            XmlDocument doc = new XmlDocument();
            doc.Load(settingsFilePath);

            LoadVisualType(doc, settingsFilePath);
            
        }

        private static void LoadVisualType(XmlDocument doc, string settingsFilePath) {
            XmlNode visualType = doc.DocumentElement.GetElementsByTagName("VisualType").Item(0);
            if (visualType == null) {
                throw new IOException($"XML file \"{settingsFilePath}\" has no value for VisualType");
            }
            switch (visualType.InnerText) {
                case "ASCII":
                    GraphicsSettings.VisualType = VisualTypes.ASCII;
                    break;
                case "Winforms":
                    GraphicsSettings.VisualType = VisualTypes.Winforms;
                    break;
                default:
                    throw new IOException($"XML file \"{settingsFilePath}\" has invalid value for VisualType");
            }
        }
    }
}
