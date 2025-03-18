namespace ActivityTrex
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
            timer1 = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            dead = new PictureBox();
            Score = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dead).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // player
            // 
            player.Image = Properties.Resources.running;
            player.Location = new Point(22, 176);
            player.Name = "player";
            player.Size = new Size(55, 69);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            player.Click += player_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.obstacle_1;
            pictureBox2.Location = new Point(567, 191);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.obstacle_2;
            pictureBox3.Location = new Point(730, 193);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // dead
            // 
            dead.Image = Properties.Resources.dead;
            dead.Location = new Point(22, 176);
            dead.Name = "dead";
            dead.Size = new Size(55, 69);
            dead.SizeMode = PictureBoxSizeMode.StretchImage;
            dead.TabIndex = 3;
            dead.TabStop = false;
            dead.Visible = false;
            dead.Click += pictureBox1_Click_1;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Location = new Point(730, 20);
            Score.Name = "Score";
            Score.Size = new Size(37, 15);
            Score.TabIndex = 4;
            Score.Text = "00000";
            Score.Click += Score_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 246);
            Controls.Add(Score);
            Controls.Add(dead);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(player);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dead).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox player;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox dead;
        private Label Score;
    }
}
