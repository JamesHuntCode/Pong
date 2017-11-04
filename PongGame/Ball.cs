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

        private int xSpeed;
        private int ySpeed;

        private int numHits;
        private int highScore;

        public Ball(int r, int x, int y)
        {
            Random rnd = new Random();

            this.radius = r;
            this.posX = x;
            this.posY = y;

            if (rnd.Next(0, 2) == 1)
            {
                this.xSpeed = -5;
            }
            else
            {
                this.xSpeed = 5;
            }
            this.ySpeed = 5;
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

        public int getNumHits()
        {
            return this.numHits;
        }

        public int getHighScore()
        {
            return this.highScore;
        }

        // Behavioural methods:

        public void updatePos(int windowHeight, int windowWidth)
        {
            this.posX += xSpeed;
            this.posY += ySpeed;
        }

        // Method used to bounce the ball off edges correctly:

        public void hitEdges(int width, int height)
        {
            if (this.posY < 0)
            {
                this.ySpeed *= -1;
            }

            if (this.posX < 0 || this.posX > width)
            {
                this.xSpeed *= -1;
            }

            if (this.posY > height)
            {
                resetPosition();
            }
        }

        public void hitPaddle()
        {
            this.numHits++;

            this.xSpeed++;

            this.ySpeed *= -1;
        }

        // Method called when ball goes off the bottom of the screen:

        public void resetPosition()
        {
            this.posX = 540;
            this.posY = 100;

            Random rnd = new Random();

            if (rnd.Next(0, 2) == 1)
            {
                this.xSpeed = -5;
            }
            else
            {
                this.xSpeed = 5;
            }

            this.ySpeed = 5;

            this.highScore = numHits;

            this.numHits = 0;
        }
    }
}
