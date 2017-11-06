using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame2DEditor.Source
{
    
    class TextureReel
    {
        private List<Texture> textures;
        private GraphicsDevice gDevice;
        private SpriteBatch sBatch;

        public TextureReel(GraphicsDevice g, SpriteBatch sb)
        {          
            textures = new List<Texture>();
            gDevice = g;
            sBatch = sb;
        }

        public TextureReel(GraphicsDevice g, SpriteBatch sb, Texture spriteSheet)
        {
            textures = SplitTexture(spriteSheet);
            gDevice = g;
            sBatch = sb;
        }

        public void AddTexture(Texture texture)
        {
            textures.Add(texture);
        }

        public int GetFrameCount()
        {
            return textures.Count;
        }

        public int GetTextureWidth()
        {
            if(textures.Count == 0)
            {
                return 0;
            }
            return textures[0].Width;         
        }

        public int GetTextureHeight()
        {
            if(textures.Count == 0)
            {
                return 0;
            }
            return textures[0].Height;
        }

        public Texture GetTexture(int index)
        {
            return textures[index];
        }

        private List<Texture> SplitTexture(Texture spriteSheet)
        {
            List<Texture> newList;
            newList = new List<Texture>(spriteSheet.Width / spriteSheet.Height);     

            for (int i = 0; i < newList.Capacity; i++)
            {
                RenderTarget2D newTarget = new RenderTarget2D(gDevice, spriteSheet.Height, spriteSheet.Height,false,SurfaceFormat.Color,DepthFormat.Depth24);
                gDevice.SetRenderTarget(newTarget);
                gDevice.Clear(Color.Transparent);
                sBatch.Begin();
                sBatch.Draw(spriteSheet, new Rectangle(0, 0, spriteSheet.Height, spriteSheet.Height), new Rectangle(i * spriteSheet.Height, 0, spriteSheet.Height, spriteSheet.Height), Color.White);
                sBatch.End();
                gDevice.SetRenderTarget(null);
                Texture newTex = new Texture((Texture2D)newTarget);
                newList.Add(newTex);
            }
            return newList;
        }

    }
}
