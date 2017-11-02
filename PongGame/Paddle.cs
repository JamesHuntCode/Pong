using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PongGame
{
    class Paddle
    {
        private int height;
        private int width;

        public Paddle(int h, int w)
        {
            this.height = h;
            this.width = w;
        }

        // Methods:

        public int getHeight()
        {
            return this.height;
        }

        public int getWidth()
        {
            return this.width;
        }

        public void updatePos(int d)
        {
            if (d == 1) // Move right
            {

            } 
            else // Move left
            {

            }
        }
    }
}
