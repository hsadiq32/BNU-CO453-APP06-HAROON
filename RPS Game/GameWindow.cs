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
        Random rnd = new Random();
        IDictionary<string, string> choiceParser = new Dictionary<string, string>();
        public int currentRound;
        public int MaxRound = 5;
        string[] AIchoice = { "rock", "paper", "scissors", "rock", "scissors", "paper" };
        public int randomNumber;
        public string command;
        public string playerName;
        string playerChoice;
        int playerWins;
        int AIwins;
        int draws;

        public GameWindow(string playerName, int botMode)
        {

            InitializeComponent();
            DefaultValues();
            AddDictionary();
            PlayerLabel.Text = playerName.ToUpper();
            // set this.FormBorderStyle to None here if needed
            // if set to none, make sure you have a way to close the form!
        }

        public void DefaultValues()
        {
            playerChoice = "none";
            playerWins = 0;
            AIwins = 0;
            draws = 0;
            currentRound = 1;
            VerdictText.Text = "";
            DrawsNumber.Text = Convert.ToString(draws);
            WinsNumber.Text = Convert.ToString(playerWins);
            LossesNumber.Text = Convert.ToString(AIwins);
            WinRateNumber.Text = "0";
            RoundText.Text = "ROUND 1";
        }
        private void RefreshGameWindow()
        {
            PlayerPictureBox.Image = Properties.Resources.qq;
            BotPictureBox.Image = Properties.Resources.qq;
            VerdictText.Update();
            DrawsNumber.Update();
            WinsNumber.Update();
            LossesNumber.Update();
            WinRateNumber.Update();
            RoundText.Update();
        }

        public void AddDictionary()
        {
            choiceParser.Add("rock", "scissors");
            choiceParser.Add("paper", "rock");
            choiceParser.Add("scissors", "paper");
            choiceParser.Add("none", "none");
        }
        private void CheckGame()
        {
            if (choiceParser[playerChoice].Equals(command))
            {
                //Player Win
                playerWins++;
                currentRound++;
                VerdictText.Text = "You Win!";
            }
            else if (choiceParser[command].Equals(playerChoice))
            {
                //Bot Win
                AIwins++;
                currentRound++;
                VerdictText.Text = "You Lost!";
            }
            else if (playerChoice.Equals(command))
            {
                //Draw
                draws++;
                currentRound++;
                VerdictText.Text = "You Draw!";
                
            }
            else
            {
                MessageBox.Show("Make a choice");
            }
            double winRate = (Convert.ToDouble(playerWins) / (Convert.ToDouble(AIwins) + Convert.ToDouble(playerWins) + Convert.ToDouble(draws))) * 100;
            WinsNumber.Text = Convert.ToString(playerWins);
            LossesNumber.Text = Convert.ToString(AIwins);
            DrawsNumber.Text = Convert.ToString(draws);
            WinRateNumber.Text = winRate.ToString("0.0") +"%";
            nextRound();
        }
        private void decisionEngine()
        {
            if (playerWins > AIwins)
            {
               
                VerdictText.Text = "You Win!";
            }
            else if (playerWins == AIwins)
            {

                VerdictText.Text = "You Draw!";
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
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void RockButton_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            PlayerPictureBox.Image = Properties.Resources.rock;
            //timer1.Enabled = true;
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            PlayerPictureBox.Image = Properties.Resources.paper;
            //timer1.Enabled = true;
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            PlayerPictureBox.Image = Properties.Resources.scissors;
            //timer1.Enabled = true;
        }

        private void label1_Click_6(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
             if(!playerChoice.Equals("none"))
            {
                randomNumber = rnd.Next(0, 5); // randomize the number again 
                command = AIchoice[randomNumber];

                object Thumbnail = Properties.Resources.ResourceManager.GetObject(command); //Return an object from the image chan1.png in the project
                BotPictureBox.Image = (Image)Thumbnail; //Set the Image property of channelPic to the returned object as Image
                BotPictureBox.Update();

                CheckGame();
                VerdictText.Update();
                Thread.Sleep(1500);
                VerdictText.Text = "";
                VerdictText.Update();
                if (MaxRound < currentRound)
                {
                    // INITAILISE RESTART
                    MessageBox.Show("Make a choice");
                }
                else
                {
                    RoundText.Text = "ROUND " + currentRound;
                    RoundText.Update();
                }
                playerChoice = "none";
            }
            else
            {

            }
        }

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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DefaultValues();
            RefreshGameWindow();
        }

        private void label1_Click_7(object sender, EventArgs e)
        {

        }

        private void label1_Click_8(object sender, EventArgs e)
        {

        }

        private void RematchBox_VerdictText_Click(object sender, EventArgs e)
        {

        }
    }

}

