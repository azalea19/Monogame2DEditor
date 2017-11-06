using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame2DEditor.Source
{

    class Particle
    {
        private Texture texture;
        private Vector2 position;
        private Vector2 velocity;
        private float angle;
        private float angularVelocity;
        private Color color;
        private float size;
        private int ttl;
        private int maxttl;
        public int numStages;

        public Particle(Texture texture, Vector2 position, Vector2 velocity, float angle, float angularVelocity, Color color, float size, int ttl, int numStages)
        {
            this.texture = texture;
            this.position = position;
            this.velocity = velocity;
            this.angle = angle;
            this.angularVelocity = angularVelocity;
            this.color = color;
            this.size = size;
            this.ttl = ttl;
            maxttl = ttl;
            this.numStages = numStages;
        }

        public int GetTimeToLive()
        {
            return ttl;
        }

        public void Update()
        {
            ttl--;
            position += velocity;
            angle += angularVelocity;
        }

        public void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            Rectangle sourceRect = new Rectangle(0, 0, texture.Width, texture.Height);
            Vector2 origin = new Vector2(texture.Width / 2, texture.Height / 2);
            float alphaScale = (float)Math.Sqrt(ttl / (float)maxttl);
            spriteBatch.Draw(texture, position - camera.GetPosition(), sourceRect, color * alphaScale, angle, origin, size, SpriteEffects.None, 0f);
        }
    }
}
