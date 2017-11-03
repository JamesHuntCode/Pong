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

        private int posX;
        private int posY;

        public Paddle(int h, int w, int x, int y)
        {
            this.height = h;
            this.width = w;
            this.posX = x;
            this.posY = y;
        }

        // Getter methods:

        public int getHeight()
        {
            return this.height;
        }

        public int getWidth()
        {
            return this.width;
        }

        public int getX()
        {
            return this.posX;
        }

        public int getY()
        {
            return this.posY;
        }

        // Behavioural methods:

        public void updatePos(int d, int leftSide, int rightSide)
        {
            if (d == 1) // Move right
            {
                this.posX += 50;

                if ((this.posX + 80) > rightSide) // Player has gone too far right
                {
                    this.posX -= 50;
                }
            } 
            else // Move left
            {
                this.posX -= 50;

                if (this.posX < leftSide) // Player has gone too far left
                {
                    this.posX += 50;
                }
            }
        }
    }
}
