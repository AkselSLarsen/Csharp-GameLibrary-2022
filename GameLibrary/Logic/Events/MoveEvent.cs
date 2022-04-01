using GameLibrary.Entities;
using GameLibrary.Logic.Events.Abstracts;
using GameLibrary.Logic.Events.Interfaces;
using GameLibrary.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Logic.Events {
    public class MoveEvent : Event {
        private IEntity _target;
        private Position _offset;

        public MoveEvent(IEntity target, Position offset) {
            _target = target;
            _offset = offset;
        }

        public override void Run() {
            _target.RegionalPosition += _offset;
        }
    }
}
