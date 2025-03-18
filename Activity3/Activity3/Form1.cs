using static System.Formats.Asn1.AsnWriter;

namespace Activity3
{
    public partial class Form1 : Form
    {

        private int num1;
        private int num2;
        private int score;
        private char optr;
        private int CorrectAnswer;

        Random random = new Random();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void lbnum1_Click(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
         
            int userAnswer;
            bool correct = int.TryParse(txtans.Text, out userAnswer);

           
            if (correct && userAnswer == CorrectAnswer)
            {
                lbtf.ForeColor = Color.Green;
                lbtf.Text = "Correct";
                score++;  
                lbscore.Text = $"Score: {score}"; 
            }
 
            if (!correct || userAnswer != CorrectAnswer)
            {
                lbtf.Text = "Incorrect";
                lbtf.ForeColor = Color.Red;  
            }
 
      
            num1 = random.Next(6, 10);
            num2 = random.Next(1, 5);
            int operatorIndex = random.Next(0, 4);
 
            if (operatorIndex == 0)
            {
                optr = '+';
                CorrectAnswer = num1 + num2;
            }
            if (operatorIndex == 1)
            {
                optr = '-';
                CorrectAnswer = num1 - num2;
            }
            if (operatorIndex == 2)
            {
                optr = '*';
                CorrectAnswer = num1 * num2;
            }
            if (operatorIndex == 3)
            {
                optr = '/';
                CorrectAnswer = num1 / num2;
            }

  
            lbnum1.Text = num1.ToString();
            lbnum2.Text = num2.ToString();
            lbop.Text = optr.ToString();
            txtans.Text = "";

        }

private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            num1 = rnd.Next(6, 10);
            num2 = rnd.Next(1, 5);
            lbnum1.Text = num1.ToString();
            lbnum2.Text = num2.ToString();
            int operatorIndex = rnd.Next(0, 4);

       
            if (operatorIndex == 0)
            {
                optr = '+';
                CorrectAnswer = num1 + num2;
            }
            if (operatorIndex == 1)
            {
                optr = '-';
                CorrectAnswer = num1 - num2;
            }
            if (operatorIndex == 2)
            {
                optr = '*';
                CorrectAnswer = num1 * num2;
            }
            if (operatorIndex == 3)
            {
                optr = '/';
                CorrectAnswer = num1 / num2;
            }

            lbop.Text = optr.ToString();
            lbscore.Text = $"Score: {score}";
            lbtf.ForeColor = Color.Red;
            txtans.Text = "";
        }

        private void txtans_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
