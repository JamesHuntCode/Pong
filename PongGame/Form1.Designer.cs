namespace PongGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPongGame = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPongGame)).BeginInit();
            this.SuspendLayout();
            // 
            // picPongGame
            // 
            this.picPongGame.Location = new System.Drawing.Point(13, 65);
            this.picPongGame.Name = "picPongGame";
            this.picPongGame.Size = new System.Drawing.Size(1132, 566);
            this.picPongGame.TabIndex = 0;
            this.picPongGame.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(317, 33);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "WELCOME TO PONG IN C#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Designed and created by James Hunt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picPongGame);
            this.Name = "Form1";
            this.Text = "Pong - James Hunt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPongGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPongGame;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
    }
}

