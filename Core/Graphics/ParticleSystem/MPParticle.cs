using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace Moreplugins.Core.Graphics.ParticleSystem
{
    public abstract class MPParticle : ModType
    {
        public int Type;
        public bool Important = false;
        /// <summary>
        /// 使用材质
        /// </summary>
        public virtual string Texture => (GetType().Namespace + "." + GetType().Name).Replace('.', '/');
        /// <summary>
        /// 该粒子存在了多少帧，一般不需要手动修改这个值
        /// </summary>
        public int Time = 0;
        /// <summary>
        /// 粒子的存在时间上限
        /// </summary>
        public int Lifetime = 0;
        public bool UseScreenCut = true;
        /// <summary>
        /// 这个是屏幕外裁剪的倍率，1对应的是扩展出半个屏幕的距离
        /// </summary>
        public float ScreenCut = 0.2f;
        /// <summary>
        /// 位置与向量
        /// </summary>
        public Vector2 Position;
        public Vector2 Velocity;
        public Vector2 Origin;
        public Color DrawColor;
        public float Rotation;
        public float Scale = 1f;
        /// <summary>
        /// 粒子的透明度
        /// </summary>
        public float Opacity = 1f;

        /// <summary>
        /// 生命周期的进度，介于0到1之间。
        /// 0表示粒子刚生成，1表示粒子消失。
        /// </summary>
        public float LifetimeRatio => Time / (float)Lifetime;

        /// <summary>
        /// 渲染的混合模式，默认为<see cref="BlendState.AlphaBlend"/>.
        /// </summary>
        public virtual BlendState UseBlendStateID => BlendState.AlphaBlend;
        protected override void Register()
        {
            Type = MPParticleManager.ParticlesCollection.Count;
            if (MPParticleManager.ParticlesCollection.Contains(this))
                MPParticleManager.ParticlesCollection.Add(this);
        }
        public virtual void OnSpawn() { }

        /// <summary>
        /// 粒子的更新，默认不做任何操作
        /// </summary>
        public virtual void Update()
        {

        }
        public virtual void OnKill() { }
        /// <summary>
        /// 覆写这个就可以自定义绘制
        /// </summary>
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Texture2D texture = ModContent.Request<Texture2D>(Texture).Value;
            spriteBatch.Draw(texture, Position - Main.screenPosition, null, DrawColor * Opacity, Rotation, texture.Size() / 2, Scale, SpriteEffects.None, 0);
        }
    }
}
