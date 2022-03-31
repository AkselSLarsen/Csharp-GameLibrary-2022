using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Util.Interfaces;

namespace GameLibrary.Util {
    public class Handler<T> : IHandler<T> where T : IHasID {
        private Dictionary<ulong, T> _internal;
        private readonly object key = new object();

        public Handler() {
            _internal = new Dictionary<ulong, T>();
        }

        public IReadOnlyCollection<T> GetAsList() {
            return _internal.Values.ToList();
        }
        public IReadOnlyDictionary<ulong, T> GetAsDictionary() {
            return _internal;
        }
        public T Get(ulong id) {
            return _internal[id];
        }
        public bool Add(T t) {
            lock(key) {

                if (_internal.ContainsKey(t.ID)) {
                    return false;
                }
                _internal.Add(t.ID, t);

                if (_internal.ContainsKey(t.ID)) {
                    return true;
                }
                return false;

            }
        }
        public T Remove(ulong id) {
            lock (key) {

                if (_internal.ContainsKey(id)) {
                    T re = _internal[id];
                    _internal.Remove(id);

                    if (!_internal.ContainsKey(id)) {
                        return re;
                    }
                }
                return default(T); // Can be null

            }
        }
    }
}