using System.Media;
using System.Windows.Forms;



namespace Activity5
{
    public partial class Form1 : Form
    {
        private const int objHeight = 50;
        private int volX = 5, volY = 5;
        private int picX, picY;
        private const int picWidth = 120;
        private const int picHeight = 120;
      
        private bool goup;
        private bool godown;
        
        WMPLib.WindowsMediaPlayer bgPlayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer bounce = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer gameOverSound  = new WMPLib.WindowsMediaPlayer();
        SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\lancearveealgire\\Documents\\Algire_3A\\Activity5\\Activity5\\bin\\Debug\\net8.0-windows\\sound\\bg.wav");

        public Form1()
        {
            InitializeComponent();
           
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            picX += volX;

            picY += volY;

            ball.Location = new Point(picX, picY);
 
            if (picX < 0 || picX + picWidth > ClientSize.Width)
            {

                soundPlayer.Stop();
                gameOverSound.controls.play();
                timer1.Enabled = false;
                MessageBox.Show("Game Over");
                soundPlayer.Play();
                ball.Left = 255;
                ball.Top = 255;
                volX = -volX;
                timer1.Enabled = true;
            }

            if (picY < 0 || picY + picHeight > ClientSize.Height)
            {
                volY = -volY;

   
            }

            if (goup && player.Top > 0)
            {
                player.Top -= 5;
            }
            if (godown && player.Top + player.Height < ClientSize.Height)
            {
                player.Top += 5;
            }

            if (player.Bounds.IntersectsWith(ball.Bounds))
            {
                volX = -volX;
                volX = (int)(volX * 1);
                volY = (int)(volY * 1);
                bounce.controls.play();
            }

            if (computer.Top + computer.Height / 2 < ball.Top + ball.Height / 2)
            {
                computer.Top += 5;
            }
            else if (computer.Top + computer.Height / 2 > ball.Top + ball.Height / 2)
            {
                computer.Top -= 5;
            }

            if (computer.Top < 0)
            {
                computer.Top = 0;
            }
            if (computer.Bottom > ClientSize.Height)
            {
                computer.Top = ClientSize.Height - computer.Height;
            }

            if (computer.Bounds.IntersectsWith(ball.Bounds))
            {
                volX = -volX;
                volX = (int)(volX * 1);
                volY = (int)(volY * 1);
                bounce.controls.play();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          

            picX = ClientSize.Width / 2 - picWidth / 2;
            picY = ClientSize.Height / 2 - picHeight / 2;

            ball.Size = new Size(picWidth, picHeight);
            ball.Location = new Point(picX, picY);

            //bgPlayer.URL = "C:\\Users\\lancearveealgire\\Documents\\Algire_3A\\Activity5\\Activity5\\bin\\Debug\\net8.0-windows\\sound\\naruto.mp3";
            //Player.settings.setMode("loop", true);
            //Player.controls.play();
            bounce.URL = "C:\\Users\\lancearveealgire\\Documents\\Algire_3A\\Activity5\\Activity5\\bin\\Debug\\net8.0-windows\\sound\\boing-101318.mp3";
            gameOverSound.URL = "C:\\Users\\lancearveealgire\\Documents\\Algire_3A\\Activity5\\Activity5\\bin\\Debug\\net8.0-windows\\sound\\wrong-buzzer-6268.mp3";
            //soundPlayer.Play();


            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.DoubleBuffer, true);
            this.UpdateStyles();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down) 
            { 
            godown = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }
    }
}
