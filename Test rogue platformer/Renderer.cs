using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_rogue_platformer
{
     class Renderer
    {
        private static Renderer m_instance;
        private SpriteBatch m_spriteBatch;

        private Renderer()
        {

        }

        public static Renderer GetRenderer()
        {
            if (m_instance == null)
            {
                return m_instance = new Renderer();
            }
            else
                return m_instance;
        }

        /// <summary>
        /// returns the sprite batch
        /// returns null if the renderer is uninitialised 
        /// </summary>
        /// <returns></returns>
        public static SpriteBatch GetSpriteBatch()
        {
            return m_instance.m_spriteBatch;
        }

        public void Draw()
        {
            //begin drawing

        }

        public void SetSpriteBatch(SpriteBatch spriteBatch)
        {
            m_spriteBatch = spriteBatch;
        }
    }
}
