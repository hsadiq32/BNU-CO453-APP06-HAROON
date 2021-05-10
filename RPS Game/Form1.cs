using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS_Game
{
    public partial class GameWindow : Form
    {
        //declaring the variables for this game
        IDictionary<string, string> choiceParser = new Dictionary<string, string>();
        public int rounds = 3; // 3 rounds per game
        public int timePerRound = 6; // 5 seconds per rounds
        //enemy choice options stored inside an array for easy access
        string[] AIchoice = { "rock", "paper", "scissors", "rock", "scissors", "paper" };
        public int randomNumber;
        string command;
        Random rnd = new Random();
        string playerChoice;
        int playerWins = 0;
        int AIwins = 0;
        int draws = 0;

        public void AddDictionary()
        {
            choiceParser.Add("rock", "scissors");
            choiceParser.Add("paper", "rock");
            choiceParser.Add("scissors", "paper");
            choiceParser.Add("none", "none");
        }
        private void checkGame()
        {
            if (choiceParser[playerChoice].Equals(command))
            {
                //Player Win
                playerWins++;
                rounds--;
                VerdictText.Text = "You Win!";
                nextRound();
            }
            else if (choiceParser[command].Equals(playerChoice))
            {
                //Bot Win
                AIwins++;
                rounds--;
                VerdictText.Text = "You Lost!";
                nextRound();
            }
            else if (playerChoice.Equals(command))
            {
                //Draw
                draws++;
                rounds--;
                VerdictText.Text = "You Draw!";
                nextRound();
                
            }
            else
            {
                MessageBox.Show("Make a choice");
                nextRound();
            }
            WinsNumber.Text = Convert.ToString(playerWins);
            LossesNumber.Text = Convert.ToString(AIwins);
            DrawsNumber.Text = Convert.ToString(draws);
            double overall = (Convert.ToDouble(playerWins) / (Convert.ToDouble(AIwins) + Convert.ToDouble(playerWins))) * 100;
            WinRateNumber.Text = Convert.ToString(overall) +"%";
        }
        private void decisionEngine()
        {
            if (playerWins > AIwins)
            {
               
                VerdictText.Text = "You Win!";
            }
            else
            {
                VerdictText.Text = "Bot Wins!";
            }
        }

        private void nextRound()
        {
            playerChoice = "none";
            PlayerPictureBox.Image = Properties.Resources.qq;
            BotPictureBox.Image = Properties.Resources.qq;


        }

        // end of declaring variables
        public GameWindow()
        {

            InitializeComponent();
            AddDictionary();
            HelpLabel.Show();
            // set this.FormBorderStyle to None here if needed
            // if set to none, make sure you have a way to close the form!
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void PlayerPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timePerRound--; // reduce the time by 1
            CountdownText.Text = Convert.ToString(timePerRound); // show the time on the screen
            Thread.Sleep(1000);
            if (timePerRound < 1) // if the time is less then one second 
            {

                timer1.Enabled = false; // we disable the timer if less then one second left 

                timePerRound = 6; // set the timer back to 6 seconds 
                randomNumber = rnd.Next(0, 5); // randomize the number again 
                command = AIchoice[randomNumber];
                // we set up the AI choice according to the random number 

                // the switch statement below will show the AI choice and change the picture box images 

                switch (command)

                {

                    case "rock":
                        BotPictureBox.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        BotPictureBox.Image = Properties.Resources.paper;
                        break;

                    case "scissors":
                        BotPictureBox.Image = Properties.Resources.scissors;
                        break;

                    default:
                        break;

                }

                HelpLabel.Hide();
                VerdictText.Show();
                Thread.Sleep(2000);
                HelpLabel.Show();
                VerdictText.Hide();
                // if we have more rounds to the play then we run the check game function 

                if (rounds > 1)
                {
                    checkGame();
                }
                // if we dont have any more rounds to play then we go to the final decision engine
                else
                {
                    decisionEngine();
                }
            }
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            PlayerPictureBox.Image = Properties.Resources.rock;
            timer1.Enabled = true;
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            PlayerPictureBox.Image = Properties.Resources.paper;
            timer1.Enabled = true;
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            PlayerPictureBox.Image = Properties.Resources.scissors;
            timer1.Enabled = true;
        }

        private void label1_Click_6(object sender, EventArgs e)
        {

        }
    }

}

