using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PongGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Timer implemented to control the game events:
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

            timer.Interval = 10; // Update every milisecond

            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            draw();
        }

        // Defined at class level due to use in multiple methods:

        Ball b = new Ball(10, 540, 100); // Change 2nd and 3rd param when possible - (x and y coords)

        Paddle p = new Paddle(100, 10, 500, 500); // Change 3rd param when possible - (x coord)

        private void draw()
        {
            Graphics pong;

            pong = picPongGame.CreateGraphics();
            pong.Clear(Color.Black);

            SolidBrush myBrush = new SolidBrush(Color.White);

            // Draw ball:

            int size = b.getRadius();

            pong.FillEllipse(myBrush, b.getX(), b.getY(), size, size);

            // Draw paddle:

            int height = p.getHeight();

            int width = p.getWidth();

            pong.FillRectangle(myBrush, p.getX(), p.getY(), height, width);

            // Allow ball to move:

            b.updatePos();

            int[] ballCoords = new int[2] { b.getX(), b.getY() };
            int[] paddleCoods = new int[2] { p.getX(), p.getY() };

            // Ball has hit a wall:



            // Ball has made contact with the paddle:

            int distance = b.getX() - p.getX();

            if ((p.getY() == b.getY()) && (distance > 0))
            {
                b.hitPaddle();
            }

            // Check ball is on the screen:

            if (b.outOfPlay())
            {
                // Generate new ball and remove old one from program entirely 
                // Take a life away from the user
                // if user has no lives end the game
            }
        }

        // Handle user clicking the arrow keys:

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) // User wants to move right
            {
                p.updatePos(1, 0, this.picPongGame.Width);
            }
            else if (e.KeyCode == Keys.Left) // User wants to move left
            {
                p.updatePos(0, 0, this.picPongGame.Width);
            }
        }
    }
}
