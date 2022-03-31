using System.Drawing;

namespace GameLibrary.Util {
    /// <summary>
#warning unwritten summery    /// 
    /// </summary>
    public class Position {
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }

        public Position(float posX, float posY) {
            PosX = posX;
            PosY = posY;
            PosZ = 0;
        }

        public Position(float posX, float posY, float posZ) {
            PosX = posX;
            PosY = posY;
            PosZ = posZ;
        }

        public static Position operator +(Position pos1, Position pos2) {
            return new Position(pos1.PosX + pos2.PosX,
                pos1.PosY + pos2.PosY,
                pos1.PosZ + pos2.PosZ);
        }
        public static Position operator -(Position pos1, Position pos2) {
            return new Position(pos1.PosX - pos2.PosX,
                pos1.PosY - pos2.PosY,
                pos1.PosZ - pos2.PosZ);
        }

        public static Position operator *(Position pos, float multiplier) {
            return new Position(pos.PosX * multiplier, pos.PosY * multiplier, pos.PosZ * multiplier);
        }

        public static Position operator /(Position pos, float divisor) {
            return new Position(pos.PosX / divisor, pos.PosY / divisor, pos.PosZ / divisor);
        }

        // I just learned that I absolutly love the operator keyword, I mean like defining implicit conversions is a dream come true :D
        public static implicit operator PointF(Position p) {
            return new PointF(p.PosX, p.PosY);
        }
    }
}
