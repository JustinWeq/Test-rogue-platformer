using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_rogue_platformer
{
    class GameManager
    {
        private static GameManager instance;
        private GameManager()
        { 
        }

        public static GameManager Manager
        {
            get
            {
                if (instance == null)
                {
                    return instance = new GameManager();
                }
                else
                    return instance;
            }
        }
        /// <summary>
        /// returns the game manager instance without the unncessary if statement,
        /// will throw an exception if the game manager has not been initalized at least once
        /// </summary>
        /// <returns></returns>
        public static GameManager GetManagerUnsafe()
        {
            return instance;
        }

        /// <summary>
        /// returns the game manager safely but is slower then unsafe
        /// </summary>
        /// <returns></returns>
        public static GameManager GetManagerSafe()
        {
            return Manager;
        }
    }
}
