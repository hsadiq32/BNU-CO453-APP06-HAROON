using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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
        DropShadow ds = new DropShadow();
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
        int playerWinsOverall = 0;
        int AIwinsOverall = 0;
        int draws;
        public string playerUserName;
        public double winRate;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\BNU-CO453-APP06-HAROON\RPS Game\RPS_Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public GameWindow()
        {
            InitializeComponent();
            //ScoreBoardBox.Sort(ScoreBoardBox["Win Rate"], ListSortDirection.Ascending);
            this.Shown += new EventHandler(Form1_Shown);
            this.Resize += new EventHandler(Form1_Resize);
            this.LocationChanged += new EventHandler(Form1_Resize);
            DefaultValues();
            AddDictionary();
        }
        private void E(string name, double winrate)
        {
            winrate = Convert.ToDouble(winrate.ToString("0.0"));
            bool nameConflict = conflictChecker(name, "Name", false);
            bool winRateConflict = conflictChecker(winrate.ToString(), "WinRate", true);
            if (nameConflict && winRateConflict)
            {
                MessageBox.Show("Data Already Saved");
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO dbo.ScoreBoard (Name,WinRate) VALUES (@name,@winrate)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@winrate", winrate);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            DisplayData();
        }
        private bool conflictChecker(string name, string column, bool integer)
        {
            DataTable dt = new DataTable();
            string sql;
            if (integer)
            {
                sql = "SELECT * FROM dbo.ScoreBoard WHERE " + column + " = " + name + "; ";
            }
            else
            {
                sql = "SELECT * FROM dbo.ScoreBoard WHERE " + column + " = '" + name + "'; ";
            }
            cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.ScoreBoard ORDER BY WinRate DESC;", con);
            adapt.Fill(dt);
            ScoreBoardBox.DataSource = dt;
            con.Close();
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            Rectangle rc = this.Bounds;
            rc.Inflate(10, 10);
            ds.Bounds = rc;
            ds.Show();
            this.BringToFront();
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            ds.Visible = (this.WindowState == FormWindowState.Normal);
            if (ds.Visible)
            {
                Rectangle rc = this.Bounds;
                rc.Inflate(10, 10);
                ds.Bounds = rc;
            }
            this.BringToFront();
        }

        public void UpdateTable()
        {
        }

        public void AddToScoreboard(string name, double winrate)
        {
            E(name, winrate);

        }



        public void ShowMenuBox()
        {
            MenuBox.Show();
            MenuBox_NewGameButton.Show();
            MenuBox_RoundsTextBox.Show();
            MenuBox_NameTextBox.Show();
            MenuBox_GoBackButton.Show();
            ScoreBoardBox.Show();
            ScoreBoardBox.Update();
            ResetButton.Hide();
            MenuButton.Hide();
        }
        public void HideMenuBox()
        {
            MenuBox.Hide();
            MenuBox_NewGameButton.Hide();
            MenuBox_RoundsTextBox.Hide();
            MenuBox_NameTextBox.Hide();
            MenuBox_GoBackButton.Hide();
            ScoreBoardBox.Hide();
            ResetButton.Show();
            MenuButton.Show();
        }

        public void ShowRematchBox()
        {
            RematchBox.Show();
            RematchBox_RematchButton.Show();
            RematchBox_MenuButton.Show();
            RematchBox_SaveScoreButton.Show();
            RematchBox_VerdictText.Show();
            RematchBox_VersusText.Show();
            RematchBox_OverallScoreText.Show();
            ScoreBoardBox.Show();
            ScoreBoardBox.Update();
            ResetButton.Hide();
            MenuButton.Hide();
        }
        public void HideRematchBox()
        {
            RematchBox.Hide();
            RematchBox_RematchButton.Hide();
            RematchBox_MenuButton.Hide();
            RematchBox_SaveScoreButton.Hide();
            RematchBox_VerdictText.Hide();
            RematchBox_VersusText.Hide();
            RematchBox_OverallScoreText.Hide();
            ScoreBoardBox.Hide();
            ResetButton.Show();
            MenuButton.Show();
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
            RoundText.Text = "ROUND 1" + "/" + MaxRound;
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
            winRate = (Convert.ToDouble(playerWins) / (Convert.ToDouble(AIwins) + Convert.ToDouble(playerWins) + Convert.ToDouble(draws))) * 100;
            WinsNumber.Text = Convert.ToString(playerWins);
            LossesNumber.Text = Convert.ToString(AIwins);
            DrawsNumber.Text = Convert.ToString(draws);
            WinRateNumber.Text = winRate.ToString("0.0") +"%";
            nextRound();
        }
        private string decisionEngine()
        {
            string verdict;
            if (playerWins > AIwins)
            {
                verdict = "You Win!";
                playerWinsOverall++;
            }
            else if (playerWins == AIwins)
            {

                verdict = "You Draw!";
            }
            else
            {
                verdict = "You Loose!";
                AIwinsOverall++;
            }
            return verdict;
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
                    RematchBox_VersusText.Text = playerName + " vs CPU";
                    RematchBox_VerdictText.Text = decisionEngine();
                    RematchBox_OverallScoreText.Text = playerWinsOverall + " - " + AIwinsOverall;
                    ShowRematchBox();
                }
                else
                {
                    RoundText.Text = "ROUND " + currentRound + "/" + MaxRound;
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
            // TODO: This line of code loads data into the 'rPS_DatabaseDataSet.ScoreBoard' table. You can move, or remove it, as needed.
            this.scoreBoardTableAdapter.HighToLow(this.rPS_DatabaseDataSet.ScoreBoard);
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

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DefaultValues();
            RefreshGameWindow();
        }

        private void RematchBox_VerdictText_Click(object sender, EventArgs e)
        {

        }

        private void RematchBox_Click(object sender, EventArgs e)
        {

        }

        private void RematchBox_RematchButton_Click(object sender, EventArgs e)
        {
            HideRematchBox();
            DefaultValues();
            RefreshGameWindow();

        }

        private void RematchBox_VersusText_Click(object sender, EventArgs e)
        {

        }

        private void RematchBox_OverallScoreText_Click(object sender, EventArgs e)
        {

        }

        private void RematchBox_SaveScoreButton_Click(object sender, EventArgs e)
        {
            AddToScoreboard(playerUserName, winRate);
            ScoreBoardBox.Update();
            UpdateTable();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void scoreBoardBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MenuBox_NewGameButton_Click(object sender, EventArgs e)
        {
            string errorMessage = null;
            playerUserName = null;
            playerUserName = MenuBox_NameTextBox.Text;
            if (String.IsNullOrEmpty(playerUserName))
            {
                errorMessage += "Name cannot be blank. ";
            }
            try
            {
                MaxRound = Convert.ToInt32(MenuBox_RoundsTextBox.Text);
                if(MaxRound > 100)
                {
                    errorMessage += "Round Number too large (max 100). ";
                }
                else if (MaxRound < 3)
                {
                    errorMessage += "Round Number too small (min 3). ";
                }
            }
            catch (Exception)
            {
                errorMessage += "Use numbers only for inputing Rounds. ";
            }
            if (String.IsNullOrEmpty(errorMessage))
            {
                DefaultValues();
                PlayerLabel.Text = playerUserName;
                RefreshGameWindow();
                HideMenuBox();
                HideRematchBox();
                playerWinsOverall = 0;
                AIwinsOverall = 0;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
            
        }

        private void MenuBox_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            ShowMenuBox();
        }

        private void RematchBox_MenuButton_Click(object sender, EventArgs e)
        {
            ShowMenuBox();
        }

        private void MenuBox_GoBackButton_Click(object sender, EventArgs e)
        {
            HideMenuBox();
        }

        private void sort_High_to_LowToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scoreBoardTableAdapter.Sort_High_to_Low(this.rPS_DatabaseDataSet.ScoreBoard);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void highToLowToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.scoreBoardTableAdapter.HighToLow(this.rPS_DatabaseDataSet.ScoreBoard);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void highToLowToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    public class DropShadow : Form
    {

        public DropShadow()
        {
            this.Opacity = 0.5;
            this.BackColor = Color.Gray;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
        }

        private const int WS_EX_TRANSPARENT = 0x20;
        private const int WS_EX_NOACTIVATE = 0x8000000;

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT | WS_EX_NOACTIVATE;
                return cp;
            }
        }
    }

}

