using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Util.Interfaces {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public interface IHasID {
        private static ulong _totalID;
        public static ulong NextID() {
            return _totalID++;
        }
        public ulong ID { get; }

        bool Equals(object obj) {
            if(obj is IHasID) {
                IHasID IHI = (IHasID)obj;
                if(IHI.ID == this.ID) {
                    return true;
                }
            }
            return false;
        }

#warning Implementation is uniform but not scrambled.
        int GetHashCode() {
            return (int)((ID % int.MaxValue*2)-int.MaxValue);
        }
    }
}
