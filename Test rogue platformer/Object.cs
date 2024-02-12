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
    class Object
    {
        protected AABB m_aabb;
        protected Texture2D m_sprite;

        public Object(AABB aabb = null,Texture2D sprite = null)
        {
            m_aabb = aabb;
            m_sprite = sprite;
            if (aabb == null)
                m_aabb = new AABB();
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, float camX = 0.0f, float camY = 0.0f)
        {
            //draw the sprite
            spriteBatch.Draw(m_sprite, new Vector2(m_aabb.X, m_aabb.Y) - new Vector2(camX, camY), Color.White);
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
