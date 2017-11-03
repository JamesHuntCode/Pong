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

        private int currentSpeed = 5;
        private int maxSpeed = 15;

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

        public void updatePos()
        {
            this.posY += currentSpeed;

            if (currentSpeed >= maxSpeed) // Limit the ball's movement to a certain speed
            {
                currentSpeed = maxSpeed;
            }
        }

        public void hitPaddle()
        {
            this.currentSpeed -= 5;
        }

        public void hitWall()
        {
           
        }

        public bool outOfPlay() // Return true or false value which indicates ball status
        {
            return (this.posY > 0);
        }
    }
}
