using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameLibrary.Settings {
    public static class SettingsSaver {
        public static void SaveSettings(string settingsFilePath) {
            using (XmlWriter writer = XmlWriter.Create(settingsFilePath)) {
                writer.WriteStartDocument();
                writer.WriteStartElement("Settings");
                writer.WriteElementString("VisualType", "ASCII");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }

        private static void SaveVisualType(XmlDocument doc, string settingsFilePath) {
            
        }
    }
}
