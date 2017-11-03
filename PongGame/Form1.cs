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

            SetStyle(ControlStyles.AllPaintingInWmPaint
        |   ControlStyles.UserPaint
        |   ControlStyles.DoubleBuffer, true);

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

        Paddle p = new Paddle(100, 10, 500, 550); // Change 3rd param when possible - (x coord)

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

            b.updatePos(this.picPongGame.Width, this.picPongGame.Height);
            b.hitEdges(this.picPongGame.Width, this.picPongGame.Height);

            // Generate developer information:

            this.txtBallX.Text = "Ball X: " + Convert.ToString(b.getX());
            this.txtPaddleX.Text = "Paddle X: " + Convert.ToString(p.getX());

            this.txtBallY.Text = "Ball Y: " + Convert.ToString(b.getY());
            this.txtPaddleY.Text = "Paddle Y: " + Convert.ToString(p.getY());

            // Ball has made contact with the paddle:

            int distance = p.getX() - b.getX();

            if ((b.getY() == p.getY()) && (-100 <= distance && distance <= 100))
            {
                b.hitPaddle();
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
