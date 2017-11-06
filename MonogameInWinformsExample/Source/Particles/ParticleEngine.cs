using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame2DEditor.Source
{

    class ParticleEngine
    {

        private float scale;
        private bool enabled = false;
        private Random random;
        private Vector2 emitterLocation { get; set; }
        private List<Particle> particles;
        private List<Texture> textures;
        private int particleStages;
        float startTime;
        float particlesPerSecond;
        int particlesCreated;

        public ParticleEngine(List<Texture> textures, Vector2 location, int particleStages, float scale, float particlesPerSecond)
        {
            this.particleStages = particleStages;
            this.scale = scale;
            this.textures = textures;
            emitterLocation = location;
            particles = new List<Particle>();            
            random = new Random();         
            startTime = 0;
            this.particlesPerSecond = particlesPerSecond;
            particlesCreated = 0;
        }

        private Particle GenerateNewParticle()
        {
            Texture texture = textures[random.Next(textures.Count)];
            Vector2 position = emitterLocation;
            Vector2 velocity = new Vector2(1f * (float)(random.NextDouble() * 2 - 1), 1f * (float)(random.NextDouble() * 2 - 1));
            float angle = 0;
            float angularVelocity = 0.1f * (float)(random.NextDouble() * 2 - 1);
            Color color = Color.White;//new Color((float)m_random.NextDouble(), (float)m_random.NextDouble(), (float)m_random.NextDouble());
            float size = (float)(random.NextDouble() * 0.8 + 0.2) * scale;
            int ttl = 1 + random.Next(100,500);

            return new Particle(texture, position, velocity, angle, angularVelocity, color, size, ttl, particleStages);
        }

        public void Restart(float gameTime)
        {
            startTime = gameTime;
            particlesCreated = 0;
        }

        public void SetEmitterLocation(Vector2 location)
        {
            emitterLocation = location;
        }

        public void SetEnabled(bool value)
        {
            enabled = value;
        }

        public void Update(float gameTime)
        {
            float dt = gameTime - startTime;
            int newParticles = (int)(dt * particlesPerSecond) - particlesCreated;
            particlesCreated += newParticles;
            
            if(enabled)
            {
                for (int i = 0; i < newParticles; i++)
                {
                    particles.Add(GenerateNewParticle());
                }                
            }

            for (int particle = 0; particle < particles.Count; particle++)
            {
                particles[particle].Update();
                if (particles[particle].GetTimeToLive() <= 0)
                {
                    particles.RemoveAt(particle);
                    particle--;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            for(int i =0; i < particles.Count; i++)
            {
                particles[i].Draw(spriteBatch, camera);
            }
        }
    }
}
