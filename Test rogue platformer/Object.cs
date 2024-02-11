using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_rogue_platformer
{
    class Object
    {
        private AABB m_aabb;
        private Texture2D m_sprite;

        public Object(AABB aabb = null,Texture2D sprite = null)
        {
            m_aabb = aabb;
            m_sprite = sprite;
            if (aabb == null)
                m_aabb = new AABB();
        }
    }
}
