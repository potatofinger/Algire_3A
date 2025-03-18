namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ground = new PictureBox();
            flappyBird = new PictureBox();
            pipeBottom = new PictureBox();
            pipeTop = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            scoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-10, 576);
            ground.Name = "ground";
            ground.Size = new Size(939, 155);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(170, 146);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(80, 60);
            flappyBird.SizeMode = PictureBoxSizeMode.AutoSize;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(560, 373);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(101, 197);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(703, 0);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(112, 223);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 3;
            pipeTop.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Location = new Point(231, 611);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(50, 20);
            scoreText.TabIndex = 4;
            scoreText.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 693);
            Controls.Add(scoreText);
            Controls.Add(pipeTop);
            Controls.Add(pipeBottom);
            Controls.Add(flappyBird);
            Controls.Add(ground);
            Name = "Form1";
            Text = "Form1";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ground;
        private PictureBox flappyBird;
        private PictureBox pipeBottom;
        private PictureBox pipeTop;
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreText;
    }
}
