using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame2DEditor.Source
{

    public class Animation
    {
        private float frameTime;
        private bool isLooping;
        private TextureReel reel;

        public Animation(GraphicsDevice g, SpriteBatch sb, Texture texture, float frameTime, bool isLooping)
        {           
            this.frameTime = frameTime;
            this.isLooping = isLooping;
            this.reel = new TextureReel(g,sb,texture);
        }

        public Animation(GraphicsDevice g, SpriteBatch sb, float frameTime, bool isLooping)
        {
            this.frameTime = frameTime;
            this.isLooping = isLooping;
            this.reel = new TextureReel(g,sb);
        }

        public void AddFrame(Texture texture)
        {
            reel.AddTexture(texture);
        }

        public float GetFrameTime()
        {
            return frameTime;
        }

        public bool IsLooping()
        {
            return isLooping;
        }

        public int GetFrameCount()
        {          
            return reel.GetFrameCount();
        }

        public int GetFrameWidth()
        {          
            return reel.GetTextureWidth();
        }

        public int GetFrameHeight()
        {
            return reel.GetTextureHeight();
        }

        public Texture GetTexture(int index)
        {
            return reel.GetTexture(index);
        }
    }
}
