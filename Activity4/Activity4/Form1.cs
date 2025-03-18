using System.Diagnostics.Eventing.Reader;

namespace Activity4
{
    public partial class Form1 : Form
    {
        private int objWidth;
        private const int objHeight = 50;
        private int objX, objY;
        private int volX, volY;


        private int picX, picY;
        private const int picWidth = 1;
        private const int picHeight = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            volX = rnd.Next(2, 2);
            volY = rnd.Next(2, 2);
            objX = label1.Left;
            objY = label1.Top;
            objWidth = label1.Width;

            objWidth = pictureBox1.Width;

            picX = rnd.Next(0, ClientSize.Width - picWidth);
            picY = rnd.Next(0, ClientSize.Height - picHeight);
            pictureBox1.Size = new Size(picWidth, picHeight);
            pictureBox1.Location = new Point(picX, picY);


            objX = rnd.Next(0, ClientSize.Width - objWidth);
            objY = rnd.Next(0, ClientSize.Width - objHeight);

            this.SetStyle(
             ControlStyles.AllPaintingInWmPaint |
             ControlStyles.UserPaint |
             ControlStyles.DoubleBuffer,
             true);
            this.UpdateStyles();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = objX;
            label1.Top = objY;

          
            pictureBox3.Left += 1;

            pictureBox4.Left += 1;
            pictureBox5.Left += 1;

            objX += volX;

            if (objX < 0)
            {
                volX = -volX;
                Random rnd = new Random();
                label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }
            else if (objX + objWidth > ClientSize.Width)
            {
                volX = -volX;
                Random rnd = new Random();
                label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }

            objY += volY;

            if (objY < 0)
            {
                volY = -volY;
                Random rnd = new Random();
                label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }
            else if (objY + objHeight > ClientSize.Height)
            {
                volY = -volY;
                Random rnd = new Random();
                label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }



            picX += volX;
            picY += volY;

            pictureBox1.Location = new Point(picX, picY);

            if (picX < 0 || picX + picWidth > ClientSize.Width)
            {
                volX = -volX;
                Random rnd = new Random();
                pictureBox1.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }

            if (picY < 0 || picY + picHeight > ClientSize.Height)
            {
                volY = -volY;
                Random rnd = new Random();
                pictureBox1.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }

            Refresh();
            pictureBox2.Left -= 5;
            if (pictureBox2.Left < ClientSize.Width)
            {
                pictureBox2.Left = 0;
                Random drg = new Random();
                pictureBox2.Top = drg.Next(0, ClientSize.Height  - pictureBox2.Height);
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
