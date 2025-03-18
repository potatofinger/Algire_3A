using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ActivityTrex
{
    public partial class Form1 : Form
    {
        int score = 0;
        int gravity = 10;
        int jumpSpeed = -20;
        int groundLevel;
        int obstacleSpeed = 8;
        bool jumping = false;
        bool gameOver = false;

        WMPLib.WindowsMediaPlayer bgPlayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer bounce = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer gameOverSound = new WMPLib.WindowsMediaPlayer();
        SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\lancearveealgire\\OneDrive\\Documents\\Algire_3A\\ActivityTrex\\ActivityTrex\\bin\\Debug\\net8.0-windows\\sound\\bg.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            if (jumping)
            {
                player.Top += jumpSpeed;
                jumpSpeed += 2;

                if (player.Top >= groundLevel)
                {
                    player.Top = groundLevel;
                    jumping = false;
                }
            }

            pictureBox2.Left -= obstacleSpeed;
            pictureBox3.Left -= obstacleSpeed;
           

            if (pictureBox2.Left < 0)
            {
                pictureBox2.Left = ClientSize.Width + new Random().Next(200, 500);
                score += 2;
                Score.Text = "Score: " + score;
            }
            if (pictureBox3.Left < 0)
            {
                pictureBox3.Left = ClientSize.Width + new Random().Next(300, 600);
                score += 2;
                Score.Text = "Score: " + score;
            }
       




            if (player.Bounds.IntersectsWith(pictureBox3.Bounds))
            {

                soundPlayer.Stop();
                gameOverSound.URL = "C:\\Users\\lancearveealgire\\OneDrive\\Documents\\Algire_3A\\ActivityTrex\\ActivityTrex\\bin\\Debug\\net8.0-windows\\sound\\wrong-buzzer-6268.mp3";


                timer1.Enabled = false;

                player.Visible = false;
                dead.Visible = true;

                MessageBox.Show("Game Over!", "Dino Run", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gameOver = false;
                Score.Text = "Score: " + score;
                player.Top = groundLevel;
                player.Visible = true;
                dead.Visible = false;
                pictureBox2.Left = ClientSize.Width;
                pictureBox3.Left = ClientSize.Width + 300;
                soundPlayer.Play();
                timer1.Enabled = true;
            }

            if (player.Bounds.IntersectsWith(pictureBox2.Bounds))
            {

                soundPlayer.Stop();

                gameOverSound.URL = "C:\\Users\\lancearveealgire\\OneDrive\\Documents\\Algire_3A\\ActivityTrex\\ActivityTrex\\bin\\Debug\\net8.0-windows\\sound\\wrong-buzzer-6268.mp3";

                timer1.Enabled = false;

                player.Visible = false;
                dead.Visible = true;
                MessageBox.Show("Game Over!", "Dino Run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gameOver = false;
                Score.Text = "Score: " + score;
                player.Top = groundLevel;
                player.Visible = true;
                dead.Visible = false;
                pictureBox2.Left = ClientSize.Width;
                pictureBox3.Left = ClientSize.Width + 300;
                soundPlayer.Play();
                timer1.Enabled = true;
            }

    

            Refresh();


        }



        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
                jumpSpeed = -20;

            }

        }

        private void KeyisPress(object sender, KeyPressEventArgs e)
        {

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bounce.URL = "C:\\Users\\lancearveealgire\\Documents\\Algire_3A\\Activity5\\Activity5\\bin\\Debug\\net8.0-windows\\sound\\boing-101318.mp3";

            soundPlayer.Play();

            groundLevel = ClientSize.Height - player.Height;
            player.Top = groundLevel;
            dead.Top = groundLevel;
            dead.Visible = false;

            pictureBox2.Left = ClientSize.Width;
            pictureBox3.Left = ClientSize.Width + 300;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.UpdateStyles();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
