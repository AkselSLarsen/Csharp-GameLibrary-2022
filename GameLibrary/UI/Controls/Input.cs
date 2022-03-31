using GameLibrary.Entities;
using GameLibrary.UI.Visuals.Window;
using GameLibrary.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    public class Input : IInput {
        private InputKeys _key;
        private ModifierKeys _modKeys;
        private Position _mousePosition;
        private IEntity _selectedEntity;
        private Window _activeWindow;
        private DateTime _timeStamp;

        public Input(InputKeys key, ModifierKeys modKeys) {
            _key = key;
            _modKeys = modKeys;
            _mousePosition = new Position(0, 0);

            _timeStamp = DateTime.Now;
        }
        public Input(InputKeys key, ModifierKeys modKeys, Position mousePosition) : this(key, modKeys) {
            _mousePosition = mousePosition;
        }
        public Input(InputKeys key, ModifierKeys modKeys, IEntity selectedEntity) : this(key, modKeys) {
            _selectedEntity = selectedEntity;
        }
        public Input(InputKeys key, ModifierKeys modKeys, Position mousePosition,
            IEntity selectedEntity) : 
            this(key, modKeys, mousePosition) {
            _selectedEntity = selectedEntity;
        }
        public Input(InputKeys key, ModifierKeys modKeys, Position mousePosition,
            Window activeWindow) :
            this(key, modKeys, mousePosition) {
            _activeWindow = activeWindow;
        }
        public Input(InputKeys key, ModifierKeys modKeys, Position mousePosition,
            IEntity selectedEntity, Window activeWindow) :
            this(key, modKeys, mousePosition, selectedEntity) {
            _activeWindow = activeWindow;
        }


        public InputKeys Key => _key;
        public ModifierKeys ModKeys => _modKeys;
        public Position MousePosition => _mousePosition;
        public IEntity SelectedEntity => _selectedEntity;
        public Window ActiveWindow => _activeWindow;
        public DateTime TimeStamp => _timeStamp;
    }
}
