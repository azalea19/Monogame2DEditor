using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Monogame2DEditor.Source;
using MonogameInWinformsExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame2DEditor.Source
{
    public class Editor : GraphicsDeviceControl
    {
        protected override void Draw()
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
        }

        protected override void Initialize()
        {
            
        }
    }
}
