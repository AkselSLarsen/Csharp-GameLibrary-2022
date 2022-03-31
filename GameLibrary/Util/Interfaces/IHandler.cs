using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Util.Interfaces {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IHandler<T> where T : IHasID {
        public IReadOnlyCollection<T> GetAsList();
        public IReadOnlyDictionary<ulong, T> GetAsDictionary();
        public T Get(ulong id);
        public bool Add(T t);
        public T Remove(ulong id);
    }
}
