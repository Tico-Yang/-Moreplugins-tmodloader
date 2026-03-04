using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ModLoader;

namespace Moreplugins.Assets
{
    public class Tex2DWithPath
    {
        public Asset<Texture2D> Texture { get; }
        public string Path { get; }
        public Tex2DWithPath(Asset<Texture2D> texture, string path)
        {
            Path = path;
            Texture = texture;
        }
        public Tex2DWithPath(string path)
        {
            Path = path;
            Texture = Request<Texture2D>($"{Path}");
        }
        public Texture2D Value => Texture.Value;
        public int Height => Texture.Height();
        public int Width => Texture.Width();
        public Vector2 Size()
        {
            return new Vector2(Value.Width, Value.Height);
        }
    }
}
