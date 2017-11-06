using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame2DEditor.Source
{
   
    public class AnimationHandler
    {
        private Animation animation;

        public AnimationHandler(Animation animation)
        {
            this.animation = animation;
        }

        public float TotalAnimationTime()
        {
            return animation.GetFrameTime() * animation.GetFrameCount();
        }

        public Animation GetAnimation()
        {
            return animation;
        }

        public int GetFrameIndex(float dt)
        {
            if(animation.IsLooping())
            {
                return (int)((dt / animation.GetFrameTime()) % animation.GetFrameCount());
            }
            else
            {
                return Math.Min((int)(dt / animation.GetFrameTime()), animation.GetFrameCount() - 1);
            }
        }
       
        public void Draw(float dt, SpriteBatch spriteBatch, Vector2 position, SpriteEffects spriteEffects, float scale)
        {
            if (animation == null)
            {
                throw new Exception("No animation is currently linked to this handler.");
            }                    
            spriteBatch.Draw(animation.GetTexture(GetFrameIndex(dt)), position, null, Color.White, 0, new Vector2(0, 0), scale, spriteEffects, 0);           
        }

    }
}
