namespace Moreplugins.Assets.Textures
{
    public partial class MPTextureRegister
    {
        public static string ParticleTexturePath => $"Moreplugins/Assets/Textures/ParticleTextures/";
        public static Tex2DWithPath BloomCircle { get; private set; }
        public static Tex2DWithPath Butterfly { get; private set; }
        public static Tex2DWithPath WhiteCircle { get; private set; }
        public static Tex2DWithPath Fire { get; private set; }
        public static void LoadParticleTextures()
        {
            BloomCircle = new Tex2DWithPath($"Moreplugins/Assets/Textures/ParticleTextures/{nameof(BloomCircle)}");
            Butterfly = new Tex2DWithPath($"Moreplugins/Assets/Textures/ParticleTextures/{nameof(Butterfly)}");
            WhiteCircle = new Tex2DWithPath($"Moreplugins/Assets/Textures/ParticleTextures/{nameof(WhiteCircle)}");
            Fire = new Tex2DWithPath($"Moreplugins/Assets/Textures/ParticleTextures/{nameof(Fire)}");
        }
        public static void UnloadParticleTextures()
        {
            BloomCircle = null;
            Butterfly = null;
            WhiteCircle = null;
            Fire = null;
        }
    }
}
