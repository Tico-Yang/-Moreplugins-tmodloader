using Terraria.ModLoader;

namespace Moreplugins.Assets.Textures
{
    public partial class MPTextureRegister : ModSystem
    {
        public override void Load()
        {
            LoadParticleTextures();
            LoadGeneral();
        }
        public override void Unload()
        {
            UnloadParticleTextures();
            UnloadGeneral();
        }
    }
}
