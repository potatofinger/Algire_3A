namespace Activity2
{
    public partial class Form1 : Form
    {
        public static string filename = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            DialogResult result = newForm.ShowDialog();
            label1.Text = filename;
            pictureBox1.Load(filename);

        }


        
    }
}
