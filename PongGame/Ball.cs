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

        //// Physics engine:
        //int currentSpeed = 3;
        //int maxSpeed = 10;
        //int velocity = 1;
        //int acceleration = 10;

        public Ball(int r)
        {
            this.radius = r;
        }

        // Methods:

        public int getRadius()
        {
            return this.radius;
        }

        public void updatePos(int d)
        {

        }

        public void hitPaddle(bool b)
        {

        }

        public void hitWall(bool b)
        {

        }
    }
}
