using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Moreplugins.Assets.Textures;
using Moreplugins.Core.Graphics.ParticleSystem;
using Moreplugins.Core.Utilities;
using Terraria;

namespace Moreplugins.Content.Particles
{
    public class WhiteCircle : MPParticle
    {
        public Vector2 BeginScale;
        public Vector2 Vector2Scale;
        public override BlendState UseBlendStateID => BlendState.AlphaBlend;
        public WhiteCircle(Vector2 position, Vector2 velocity, Color color, int time, Vector2 scale)
        {
            Position = position;
            Velocity = velocity;
            DrawColor = color;
            Lifetime = time;
            BeginScale = scale;
        }
        public override void Update()
        {
            Velocity *= 0.9f;
            Vector2Scale = Vector2.Lerp(BeginScale, Vector2.Zero, EasingHelper.EaseInCubic(LifetimeRatio));
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Texture2D texture = MPTextureRegister.BloomCircle.Value;
            spriteBatch.Draw(texture, Position - Main.screenPosition, null, DrawColor * Opacity, Rotation, texture.Size() / 2, Vector2Scale, SpriteEffects.None, 0);
        }
    }
}
