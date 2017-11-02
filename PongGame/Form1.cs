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

        public void setup()
        {
           
        }

        public void draw()
        {
            Graphics pongPlayArea;

            pongPlayArea = picPongGame.CreateGraphics();
            pongPlayArea.Clear(Color.Black);
        }

        // All button events (GAME CONTROLS):

        private void btnStart_Click(object sender, EventArgs e) // Start
        {
           
        }

        private void btnPause_Click(object sender, EventArgs e) // Pause
        {

        }

        private void btnStop_Click(object sender, EventArgs e) // Stop
        {

        }

        private void btnRestart_Click(object sender, EventArgs e) // Restart
        {

        }
    }
}
