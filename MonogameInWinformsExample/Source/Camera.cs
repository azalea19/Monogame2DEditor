using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame2DEditor.Source
{

    public class Camera
    {
        private Vector2 position;
        private float margin;

        public Camera(Vector2 position, float margin)
        {
            this.position = position;
            this.margin = margin;
        }

        public void SetPosition(Vector2 position)
        {
            this.position = position;
        }

        public void SetX(float x)
        {
            this.position.X = x;
        }

        public void SetY(float y)
        {
            this.position.Y = y;
        }

        public Vector2 GetPosition()
        {
            return position;
        }

        public void SetMargin(float margin)
        {
            this.margin = margin;
        }

        public float GetMargin()
        {
            return margin;
        }
    }
}
