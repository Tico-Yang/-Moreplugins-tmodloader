using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace Moreplugins.Assets.Textures
{
    public partial class MPTextureRegister : ModSystem
    {
        public static string GeneralPath => $"Moreplugins/Assets/Textures/GeneralTexture/";
        public static string InvisAssetPath => GeneralPath + "InvisAsset";
        public static Texture2D InvisAsset;
        public static void LoadGeneral()
        {
            InvisAsset= Request<Texture2D>(InvisAssetPath).Value;

        }
        public static void UnloadGeneral()
        {
            InvisAsset = null;
        }
    }
}
