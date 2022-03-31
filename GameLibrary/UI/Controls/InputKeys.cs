using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.UI.Controls {
    public enum InputKeys : byte {
        #region letters
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z,
        #endregion
        #region mouse
        LeftClick,
        RightClick,
        MiddleClick,
        MiddleRollUp,
        MiddleRollDown,
        #endregion
        #region command
        Space,
        Enter,
        ArrowLeft,
        ArrowRight,
        ArrowUp,
        ArrowDown,
        #endregion
        #region syntax 
        Comma,
        Dot,
        #endregion
        #region math
        LessThan,
        MoreThan,
        #endregion
        #region symbol
        And,
        Hashtag
        #endregion
    }
}
