using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_rogue_platformer
{
    class Object : AABB
    {

        protected Texture2D m_sprite;

        public Object(Texture2D sprite = null) : base()
        {
            
            m_sprite = sprite;

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, float camX = 0.0f, float camY = 0.0f)
        {
            //draw the sprite
            spriteBatch.Draw(m_sprite, new Vector2(X, Y) - new Vector2(camX, camY), Color.White);
        }

        public void Draw(SpriteBatch spriteBatch,Vector2 cam)
        {
            Draw(spriteBatch, cam.X, cam.Y);
        }

        public void SetSprite(Texture2D sprite)
        {
            m_sprite = sprite;
        }

        public Texture2D GetSprite()
        {
            return m_sprite;
        }

        public void LoadSprite(String assetName)
        {
            //load the sprite
            
        }
    }
}
