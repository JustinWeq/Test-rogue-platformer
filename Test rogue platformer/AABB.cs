using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_rogue_platformer
{
    class AABB
    {
        private float m_width;
        private float m_height;
        private float m_x;
        private float m_y;

        public AABB()
        {
            m_width = 0.0f; m_height = 0.0f;
            m_x = 0.0f; m_y = 0.0f;
        }

        public AABB(float width = 0, float height = 0, float x = 0, float y = 0)
        {
            this.m_width = width;
            this.m_height = height;
            this.m_x = x;
            this.m_y = y;
        }

        public bool Collides(AABB other)
        {
            return other.m_x < m_x + m_width &&
                other.m_x + other.m_width > m_x &&
                other.m_y < m_y + m_height &&
                other.m_y + other.m_height > m_y;
        }
    }
}
