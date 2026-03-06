using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.ID;

namespace Moreplugins.Assets.Textures
{
    public partial class MPTextureRegister
    {
        public static string ParticleTexturePath => $"Moreplugins/Assets/Textures/ParticleTextures/";
        public static Tex2DWithPath BloomCircle { get; private set; }
        public static Tex2DWithPath Butterfly { get; private set; }
        public static Tex2DWithPath WhiteCircle { get; private set; }
        public static Tex2DWithPath Fire { get; private set; }
        public static Tex2DWithPath ShinyOrb { get; private set; }
        public static Texture2D SharpTear => TextureAssets.Extra[ExtrasID.SharpTears].Value;
        public static void LoadParticleTextures()
        {
            BloomCircle = new Tex2DWithPath($"{ParticleTexturePath}{nameof(BloomCircle)}");
            Butterfly = new Tex2DWithPath($"{ParticleTexturePath}{nameof(Butterfly)}");
            WhiteCircle = new Tex2DWithPath($"{ParticleTexturePath}{nameof(WhiteCircle)}");
            Fire = new Tex2DWithPath($"{ParticleTexturePath}{nameof(Fire)}");
            ShinyOrb = new Tex2DWithPath($"{ParticleTexturePath}{nameof(ShinyOrb)}");
        }
        public static void UnloadParticleTextures()
        {
            BloomCircle = null;
            Butterfly = null;
            WhiteCircle = null;
            Fire = null;
            ShinyOrb = null;
        }
    }
}
