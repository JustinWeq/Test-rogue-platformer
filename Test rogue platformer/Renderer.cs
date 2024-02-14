using Microsoft.Xna.Framework;
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
        private Vector2 m_camera;
        private GameManager m_manager;

        public static Renderer Instance
        {
            get { return GetRenderer(); }
        }

        private Renderer()
        {

            //get the manager
            m_manager = GameManager.Manager;

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
            m_spriteBatch.Begin();

            //begin by drawing the player
            m_manager.GetPlayer().Draw(m_spriteBatch, m_camera);

            //end drawing
            m_spriteBatch.End();

        }

        public void SetSpriteBatch(SpriteBatch spriteBatch)
        {
            m_spriteBatch = spriteBatch;
        }

        public void MoveCamera(Vector2 camera)
        {
            m_camera += camera;
        }

        public void SetCamera(Vector2 camera)
        {
            m_camera = camera;
        }


    }
}
