namespace Activity5
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
            ball = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            computer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computer).BeginInit();
            SuspendLayout();
            // 
            // ball
            // 
            ball.BackColor = Color.Transparent;
            ball.Image = Properties.Resources._067a2c0aa638eda14ce4e86b9a9318a9;
            ball.Location = new Point(425, 189);
            ball.Name = "ball";
            ball.Size = new Size(166, 154);
            ball.SizeMode = PictureBoxSizeMode.Zoom;
            ball.TabIndex = 0;
            ball.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // player
            // 
            player.BackColor = Color.Red;
            player.Location = new Point(-1, 198);
            player.Name = "player";
            player.Size = new Size(36, 145);
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // computer
            // 
            computer.BackColor = Color.Blue;
            computer.Location = new Point(745, 174);
            computer.Name = "computer";
            computer.Size = new Size(36, 145);
            computer.TabIndex = 2;
            computer.TabStop = false;
            computer.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(computer);
            Controls.Add(player);
            Controls.Add(ball);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)computer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private PictureBox player;
        private PictureBox computer;
    }
}
