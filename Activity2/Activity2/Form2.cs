using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            textBox1.Text = Path.GetFullPath(ofd.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1.filename = textBox1.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
