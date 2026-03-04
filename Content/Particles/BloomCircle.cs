using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Moreplugins.Assets.Textures;
using Moreplugins.Core.Graphics.ParticleSystem;
using Moreplugins.Core.Utilities;
using Terraria;

namespace Moreplugins.Content.Particles
{
    public class BloomCircle : MPParticle
    {
        public float BeginScale;
        public override BlendState UseBlendStateID => BlendState.Additive;
        public BloomCircle(Vector2 position, Vector2 velocity, Color color, int time, float scale)
        {
            Position = position;
            Velocity = velocity;
            DrawColor = color;
            Lifetime = time;
            BeginScale = scale;
        }
        public override void Update()
        {
            Velocity *= 0.8f;
            Scale = MathHelper.Lerp(BeginScale, 0, EasingHelper.EaseInCubic(LifetimeRatio));
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Texture2D texture = MPTextureRegister.BloomCircle.Value;
            spriteBatch.Draw(texture, Position - Main.screenPosition, null, DrawColor * Opacity, Rotation, texture.Size() / 2, Scale, SpriteEffects.None, 0);
        }
    }
}
