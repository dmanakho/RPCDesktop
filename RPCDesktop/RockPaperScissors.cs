using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPCDesktop
{
    public partial class RockPaperScissors : Form
    {
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton RadioButtonScissors;
        private RadioButton RadioButtonPaper;
        private GroupBox groupBox2;
        private Label LabelResult;
        private GroupBox groupBox3;
        private Label LabelAI;
        private GroupBox groupBox4;
        private Button ButtonReset;
        private Label LabelWInningP;
        private Label LabelForWinningP;
        private Label LabelNumberOfRounds;
        private Label LabelForNumberOfR;
        private Button ButtonPlay;
        private RadioButton RadioButtonRock;

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonRock = new System.Windows.Forms.RadioButton();
            this.RadioButtonPaper = new System.Windows.Forms.RadioButton();
            this.RadioButtonScissors = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.LabelAI = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LabelForNumberOfR = new System.Windows.Forms.Label();
            this.LabelNumberOfRounds = new System.Windows.Forms.Label();
            this.LabelWInningP = new System.Windows.Forms.Label();
            this.LabelForWinningP = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Mr. Manakhov RPC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonScissors);
            this.groupBox1.Controls.Add(this.RadioButtonPaper);
            this.groupBox1.Controls.Add(this.RadioButtonRock);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player\'s Choice";
            // 
            // RadioButtonRock
            // 
            this.RadioButtonRock.AutoSize = true;
            this.RadioButtonRock.Location = new System.Drawing.Point(26, 85);
            this.RadioButtonRock.Name = "RadioButtonRock";
            this.RadioButtonRock.Size = new System.Drawing.Size(154, 50);
            this.RadioButtonRock.TabIndex = 0;
            this.RadioButtonRock.TabStop = true;
            this.RadioButtonRock.Text = "Rock";
            this.RadioButtonRock.UseVisualStyleBackColor = true;
            this.RadioButtonRock.CheckedChanged += new System.EventHandler(this.RadioButtonRock_CheckedChanged);
            // 
            // RadioButtonPaper
            // 
            this.RadioButtonPaper.AutoSize = true;
            this.RadioButtonPaper.Location = new System.Drawing.Point(26, 155);
            this.RadioButtonPaper.Name = "RadioButtonPaper";
            this.RadioButtonPaper.Size = new System.Drawing.Size(168, 50);
            this.RadioButtonPaper.TabIndex = 1;
            this.RadioButtonPaper.TabStop = true;
            this.RadioButtonPaper.Text = "Paper";
            this.RadioButtonPaper.UseVisualStyleBackColor = true;
            // 
            // RadioButtonScissors
            // 
            this.RadioButtonScissors.AutoSize = true;
            this.RadioButtonScissors.Location = new System.Drawing.Point(26, 221);
            this.RadioButtonScissors.Name = "RadioButtonScissors";
            this.RadioButtonScissors.Size = new System.Drawing.Size(218, 50);
            this.RadioButtonScissors.TabIndex = 2;
            this.RadioButtonScissors.TabStop = true;
            this.RadioButtonScissors.Text = "Scissors";
            this.RadioButtonScissors.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelResult);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(595, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 376);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Round Result";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LabelAI);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1171, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 376);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AI Choice";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.Location = new System.Drawing.Point(96, 149);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(300, 63);
            this.LabelResult.TabIndex = 0;
            this.LabelResult.Text = "Be afraid!!!";
            // 
            // LabelAI
            // 
            this.LabelAI.AutoSize = true;
            this.LabelAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAI.Location = new System.Drawing.Point(58, 149);
            this.LabelAI.Name = "LabelAI";
            this.LabelAI.Size = new System.Drawing.Size(463, 63);
            this.LabelAI.TabIndex = 1;
            this.LabelAI.Text = "You gonna lose!!!";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ButtonReset);
            this.groupBox4.Controls.Add(this.LabelWInningP);
            this.groupBox4.Controls.Add(this.LabelForWinningP);
            this.groupBox4.Controls.Add(this.LabelNumberOfRounds);
            this.groupBox4.Controls.Add(this.LabelForNumberOfR);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1108, 626);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 518);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistics";
            // 
            // LabelForNumberOfR
            // 
            this.LabelForNumberOfR.AutoSize = true;
            this.LabelForNumberOfR.Location = new System.Drawing.Point(19, 104);
            this.LabelForNumberOfR.Name = "LabelForNumberOfR";
            this.LabelForNumberOfR.Size = new System.Drawing.Size(383, 46);
            this.LabelForNumberOfR.TabIndex = 0;
            this.LabelForNumberOfR.Text = "Number of Rounds:";
            // 
            // LabelNumberOfRounds
            // 
            this.LabelNumberOfRounds.AutoSize = true;
            this.LabelNumberOfRounds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelNumberOfRounds.Location = new System.Drawing.Point(410, 104);
            this.LabelNumberOfRounds.Name = "LabelNumberOfRounds";
            this.LabelNumberOfRounds.Size = new System.Drawing.Size(45, 48);
            this.LabelNumberOfRounds.TabIndex = 1;
            this.LabelNumberOfRounds.Text = "0";
            // 
            // LabelWInningP
            // 
            this.LabelWInningP.AutoSize = true;
            this.LabelWInningP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelWInningP.Location = new System.Drawing.Point(410, 173);
            this.LabelWInningP.Name = "LabelWInningP";
            this.LabelWInningP.Size = new System.Drawing.Size(45, 48);
            this.LabelWInningP.TabIndex = 3;
            this.LabelWInningP.Text = "0";
            // 
            // LabelForWinningP
            // 
            this.LabelForWinningP.AutoSize = true;
            this.LabelForWinningP.Location = new System.Drawing.Point(19, 173);
            this.LabelForWinningP.Name = "LabelForWinningP";
            this.LabelForWinningP.Size = new System.Drawing.Size(409, 46);
            this.LabelForWinningP.TabIndex = 2;
            this.LabelForWinningP.Text = "Winning Percentage:";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(27, 435);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(271, 77);
            this.ButtonReset.TabIndex = 4;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlay.Location = new System.Drawing.Point(90, 647);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(339, 218);
            this.ButtonPlay.TabIndex = 6;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // RockPaperScissors
            // 
            this.ClientSize = new System.Drawing.Size(1848, 1184);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RockPaperScissors";
            this.Text = "Rock Paper Scissors";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RadioButtonRock_CheckedChanged(object sender, EventArgs e)
        {

        }

        string[,] decisionTable = new string[3, 3] {
                                          { "Tie", "Loss", "Win" },
                                          { "Win", "Tie", "Loss" },
                                          { "Loss", "Win", "Tie" }
                                        };


        string[] rpsChoices = new string[] { "Rock", "Paper", "Scissors" };

        int numberOfRounds=0;
        int Wins, Losses, Ties;
        int WinningP;

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            int ai = GetAIChoice();
            int human = GetHumanChoice();

            string roundResult = decisionTable[human,ai];

            LabelResult.Text = roundResult;
            LabelAI.Text = rpsChoices[ai];
            numberOfRounds++;
            LabelNumberOfRounds.Text = numberOfRounds.ToString();



        }

        private int GetAIChoice()
        {
            Random r = new Random();
            return r.Next(0, 3);
        }

        private int GetHumanChoice()
        {
            int humanChoice = 0;

            if (RadioButtonRock.Checked)
            {
                humanChoice = 0;
            }
            else if (RadioButtonPaper.Checked)
            {
                humanChoice = 1;
            }
            else if (RadioButtonScissors.Checked)
            {
                humanChoice = 2;
            }
            return humanChoice;

        }
    }
}
