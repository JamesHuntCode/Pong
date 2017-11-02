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

        public void timer_Tick(object sender, EventArgs e)
        {
            // Call all methods that need updating from here:

            draw();

        }

        Graphics pong;

        Ball b = new Ball(10, 0, 0);

        Paddle p = new Paddle(100, 10, 0, 500);

        public void draw()
        {
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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) // User wants to move right
            {
                p.updatePos(1);
            }
            else if (e.KeyCode == Keys.Left) // User wants to move left
            {
                p.updatePos(0);
            }
        }
    }
}
