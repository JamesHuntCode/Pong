using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PongGame
{
    class Ball
    {
        private int radius;

        private int posX;
        private int posY;

        private int xSpeed = 5;
        private int ySpeed = 5;

        public Ball(int r, int x, int y)
        {
            this.radius = r;
            this.posX = x;
            this.posY = y;
        }

        // Getter methods:

        public int getRadius()
        {
            return this.radius;
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

        public void updatePos(int windowHeight, int windowWidth)
        {
            this.posX += xSpeed;
            this.posY += ySpeed;
        }

        public void hitEdges(int width, int height)
        {
            if (this.posY < 0)
            {
                ySpeed *= -1;
            }

            if (this.posX < 0 || this.posX > width)
            {
                xSpeed *= -1;
            }

            if (this.posX > height)
            {
                reset();
            }
        }

        public void hitPaddle()
        {
            ySpeed *= -1;
        }

        public void reset()
        {

        }
    }
}
