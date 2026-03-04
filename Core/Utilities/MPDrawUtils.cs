using Microsoft.Xna.Framework;
using Terraria;

namespace Moreplugins.Core.Utilities
{
    public static partial class MPUtils
    {
        public static bool OutOffScreen(Vector2 pos, float areamult = 1f)
        {
            float halfwidth = Main.screenWidth / 2;
            float halfheight = Main.screenHeight / 2;
            if (pos.X < Main.screenPosition.X - halfwidth * areamult)
                return true;
            if (pos.Y < Main.screenPosition.Y - halfheight * areamult)
                return true;
            if (pos.X > Main.screenPosition.X + Main.screenWidth + halfwidth * areamult)
                return true;
            if (pos.Y > Main.screenPosition.Y + Main.screenHeight + halfheight * areamult)
                return true;
            return false;
        }
    }
}
