using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_rogue_platformer
{
     class Grid
    {
        private Player m_player;
        public void LoadLevel(String name)
        {

        }

        public void SetPlayer(Player player)
        {
            m_player = player;
        }

        public Player GetPlayer() {
            return m_player;
        }
    }
}
