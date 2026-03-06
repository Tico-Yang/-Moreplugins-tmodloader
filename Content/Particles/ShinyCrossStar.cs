using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Moreplugins.Assets;
using Moreplugins.Assets.Textures;
using Moreplugins.Core.Graphics.ParticleSystem;
using System;
using Terraria;

namespace Moreplugins.Content.Particles
{
    public class ShinyCrossStar : MPParticle
    {
        public bool UseRot = false;
        public override BlendState UseBlendStateID => BlendState.Additive;
        public Color InitColor;
        public float SpinSpeed = 0;
        private float BeginScale;
        public ShinyCrossStar(Vector2 position, Vector2 velocity, Color color, int lifetime, float Rot, float opacity, float scale, float spinSpeed = 0f)
        {
            Position = position;
            Velocity = velocity;
            InitColor = color;
            Lifetime = lifetime;
            Rotation = Rot;
            Opacity = opacity;
            Scale = BeginScale = scale;
            SpinSpeed = spinSpeed;
        }
        public override void OnSpawn()
        {
        }

        public override void Update()
        {
            Scale *= 0.93f;
            DrawColor = Color.Lerp(InitColor, InitColor * 0.2f, (float)Math.Pow(LifetimeRatio, 30));
            Velocity *= 0.95f;
            Rotation += SpinSpeed;
            //太小的情况下直接处死粒子就行了
            if (Scale < BeginScale * 0.15f)
                Time = Lifetime;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Texture2D star = MPTextureRegister.SharpTear;
            Tex2DWithPath shinyOrb = MPTextureRegister.ShinyOrb;
            Vector2 drawPos = Position - Main.screenPosition;

            Vector2 starScale = new Vector2(1.2f, 0.8f);
            spriteBatch.Draw(star, drawPos, null, DrawColor * Opacity, Rotation, star.Size() / 2, starScale * Scale, SpriteEffects.None, 0);
            spriteBatch.Draw(star, drawPos, null, DrawColor * Opacity, Rotation + PiOver2, star.Size() / 2, starScale * Scale, SpriteEffects.None, 0);
            //防止过曝
            spriteBatch.Draw(shinyOrb.Value, drawPos, null, Color.Lerp(Color.White, DrawColor, 0.5f) * 0.95f * Opacity, 0, shinyOrb.Value.Size() / 2, Scale * 0.75f, SpriteEffects.None, 0);
        }
    }
}
