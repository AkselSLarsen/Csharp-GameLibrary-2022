using System.Drawing;

namespace GameLibrary.Util {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public class Box {
        public Position TopLeft { get; set; }
        public Position BottomRight { get; set; }
        public Position Middle {
            get { return (TopLeft + BottomRight) / 2.0f; }
        }

        public Box(Position topLeft, Position bottomRight) {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public (float, float, float) Size() {
            return (BottomRight.PosX - TopLeft.PosX,
                BottomRight.PosY - TopLeft.PosY,
                BottomRight.PosZ - TopLeft.PosZ);
        }

        public bool Overlaps(Box box) {
            if(TopLeft.PosX > box.TopLeft.PosX &&
                TopLeft.PosY > box.TopLeft.PosY &&
                TopLeft.PosZ > box.TopLeft.PosZ &&
                box.TopLeft.PosX > BottomRight.PosX &&
                box.TopLeft.PosY > BottomRight.PosY &&
                box.TopLeft.PosZ > BottomRight.PosZ) {
                return true;
            }
            if (TopLeft.PosX < box.TopLeft.PosX &&
                TopLeft.PosY < box.TopLeft.PosY &&
                TopLeft.PosZ < box.TopLeft.PosZ &&
                box.TopLeft.PosX < BottomRight.PosX &&
                box.TopLeft.PosY < BottomRight.PosY &&
                box.TopLeft.PosZ < BottomRight.PosZ) {
                return true;
            }
            return false;
        }

        public static implicit operator RectangleF(Box b) {
            return new RectangleF(b.TopLeft.PosX, b.TopLeft.PosY,
                b.TopLeft.PosX - b.BottomRight.PosX, b.TopLeft.PosY - b.BottomRight.PosY);
        }
    }
}
