using System.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;

namespace Monogame2DEditor.Source
{

    public class Texture
    {

        Texture2D texture;
        Microsoft.Xna.Framework.Color[] pixels;

        private Texture()
        {
        }

        public Texture(Texture2D texture)
        {
            this.texture = texture;
            pixels = new Microsoft.Xna.Framework.Color[this.texture.Width * this.texture.Height];
            this.texture.GetData<Microsoft.Xna.Framework.Color>(pixels);
        }

        public static Texture Create(ContentManager cm, string texturePath)
        {
            return new Texture(cm.Load<Texture2D>(texturePath));
        }

        public static implicit operator Texture2D(Texture texture)
        {
            return texture.texture;
        }

        public int Width
        {
            get
            {
                return texture.Width;
            }
        }

        public int Height
        {
            get
            {
                return texture.Height;
            }
        }

        public Microsoft.Xna.Framework.Color GetPixel(int x, int y)
        {
            return pixels[y * texture.Width + x];
        }

        public Microsoft.Xna.Framework.Color GetPixel(Vector2 position)
        {
            return GetPixel((int)position.X, (int)position.Y);
        }

        public Bitmap ToBitmap()
        {
            Bitmap img = new Bitmap(Width, Height);
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    img.SetPixel(x, y, System.Drawing.Color.FromArgb(GetPixel(x, y).A, GetPixel(x, y).R, GetPixel(x, y).G, GetPixel(x, y).B));
            return img;
        }

    }
}
