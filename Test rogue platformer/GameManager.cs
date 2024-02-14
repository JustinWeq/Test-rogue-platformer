using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_rogue_platformer
{
    class GameManager
    {
        private static GameManager m_instance;
        private ContentManager m_contentManager;
        private Grid m_grid;
        private Renderer m_renderer;
        private Player m_player;
        public const bool TEST_MODE = true;
        private GameManager()
        { 
            //create the grid renderer and player
            m_player = new Player();
            m_grid = new Grid();
            m_renderer = Renderer.GetRenderer();
        }

        public void Update()
        {
            //if in test mode then move the camera
            if(TEST_MODE)
            {
                Vector2 camPos = new Vector2();
                if(Keyboard.GetState().IsKeyDown(Keys.Up))
                {
                    camPos.Y += 5;
                }

                if(Keyboard.GetState ().IsKeyDown(Keys.Down))
                {
                    camPos.Y -= 5;
                }

                if(Keyboard.GetState().IsKeyDown(Keys.Left))
                {
                    camPos.X += 5;
                }

                if(Keyboard.GetState().IsKeyDown (Keys.Right))
                {
                    camPos.X -= 5;
                }

                m_renderer.MoveCamera(camPos);
            }
        }

        public static GameManager Manager
        {
            get
            {
                if (m_instance == null)
                {
                    return m_instance = new GameManager();
                }
                else
                    return m_instance;
            }
        }
        /// <summary>
        /// returns the game manager instance without the unncessary if statement,
        /// will throw an exception if the game manager has not been initalized at least once
        /// </summary>
        /// <returns></returns>
        public static GameManager GetManagerUnsafe()
        {
            return m_instance;
        }

        /// <summary>
        /// returns the game manager safely but is slower then unsafe
        /// </summary>
        /// <returns></returns>
        public static GameManager GetManagerSafe()
        {
            return Manager;
        }

        public void SetContentManager(ContentManager contentManager)
        {
            m_contentManager = contentManager;
        }

        public ContentManager GetContentManager()
        {
            return m_contentManager;
        }

        public Grid GetGrid()
        {
            return m_grid;
        }

        public Renderer GetRenderer()
        { 
            return m_renderer;
        }

        public Player GetPlayer() 
        { 
            return m_player;
        }
    }
}
