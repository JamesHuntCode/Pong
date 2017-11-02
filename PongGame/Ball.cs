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

        public void updatePos(int d)
        {
            
        }

        public void hitPaddle(bool b)
        {
            if (b == true) // User has hit the ball with the paddle
            {

            }
        }

        public void hitWall(bool b)
        {
            if (b == true) // The ball has hit a wall
            {
                
            }
        }

        public void outOfPlay(bool b)
        {
            if (b == true) // User has missed the ball and the ball is gone
            {

            }
        }
    }
}
