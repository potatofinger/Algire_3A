namespace Activity3
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
            lbscore = new Label();
            lbtf = new Label();
            lbnum1 = new Label();
            lbop = new Label();
            lbnum2 = new Label();
            txtans = new TextBox();
            btncheck = new Button();
            SuspendLayout();
            // 
            // lbscore
            // 
            lbscore.AutoSize = true;
            lbscore.Location = new Point(12, 9);
            lbscore.Name = "lbscore";
            lbscore.Size = new Size(39, 15);
            lbscore.TabIndex = 0;
            lbscore.Text = "Score:";
            // 
            // lbtf
            // 
            lbtf.AutoSize = true;
            lbtf.Location = new Point(12, 101);
            lbtf.Name = "lbtf";
            lbtf.Size = new Size(26, 15);
            lbtf.TabIndex = 1;
            lbtf.Text = "Got";
            // 
            // lbnum1
            // 
            lbnum1.AutoSize = true;
            lbnum1.Location = new Point(44, 50);
            lbnum1.Name = "lbnum1";
            lbnum1.Size = new Size(19, 15);
            lbnum1.TabIndex = 2;
            lbnum1.Text = "00";
            lbnum1.Click += lbnum1_Click;
            // 
            // lbop
            // 
            lbop.AutoSize = true;
            lbop.Location = new Point(88, 50);
            lbop.Name = "lbop";
            lbop.Size = new Size(15, 15);
            lbop.TabIndex = 3;
            lbop.Text = "+";
            // 
            // lbnum2
            // 
            lbnum2.AutoSize = true;
            lbnum2.Location = new Point(132, 50);
            lbnum2.Name = "lbnum2";
            lbnum2.Size = new Size(19, 15);
            lbnum2.TabIndex = 4;
            lbnum2.Text = "00";
            // 
            // txtans
            // 
            txtans.Location = new Point(176, 47);
            txtans.Name = "txtans";
            txtans.Size = new Size(100, 23);
            txtans.TabIndex = 5;
            txtans.TextChanged += txtans_TextChanged;
            // 
            // btncheck
            // 
            btncheck.Location = new Point(282, 47);
            btncheck.Name = "btncheck";
            btncheck.Size = new Size(75, 23);
            btncheck.TabIndex = 6;
            btncheck.Text = "check";
            btncheck.UseVisualStyleBackColor = true;
            btncheck.Click += btncheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 125);
            Controls.Add(btncheck);
            Controls.Add(txtans);
            Controls.Add(lbnum2);
            Controls.Add(lbop);
            Controls.Add(lbnum1);
            Controls.Add(lbtf);
            Controls.Add(lbscore);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbscore;
        private Label lbtf;
        private Label lbnum1;
        private Label lbop;
        private Label lbnum2;
        private TextBox txtans;
        private Button btncheck;
    }
}
