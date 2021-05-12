
namespace RPS_Game
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.BotPictureBox = new System.Windows.Forms.PictureBox();
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.WinsNumber = new System.Windows.Forms.Label();
            this.LossesNumber = new System.Windows.Forms.Label();
            this.DrawsNumber = new System.Windows.Forms.Label();
            this.WinRateNumber = new System.Windows.Forms.Label();
            this.RoundText = new System.Windows.Forms.Label();
            this.VerdictText = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.BotLabel = new System.Windows.Forms.Label();
            this.StatsLabel = new System.Windows.Forms.Label();
            this.ChoicesLabel = new System.Windows.Forms.Label();
            this.RematchBox = new System.Windows.Forms.PictureBox();
            this.RematchBox_VerdictText = new System.Windows.Forms.Label();
            this.RematchBox_RematchButton = new System.Windows.Forms.Button();
            this.RematchBox_MenuButton = new System.Windows.Forms.Button();
            this.RematchBox_SaveScoreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RematchBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ExitButton.Location = new System.Drawing.Point(645, 20);
            this.ExitButton.MaximumSize = new System.Drawing.Size(54, 17);
            this.ExitButton.MinimumSize = new System.Drawing.Size(54, 17);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(54, 17);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetButton.BackgroundImage")));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(64)))), ((int)(((byte)(8)))));
            this.ResetButton.Location = new System.Drawing.Point(586, 20);
            this.ResetButton.MaximumSize = new System.Drawing.Size(54, 17);
            this.ResetButton.MinimumSize = new System.Drawing.Size(54, 17);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(54, 17);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayerPictureBox.ErrorImage = null;
            this.PlayerPictureBox.Image = global::RPS_Game.Properties.Resources.qq;
            this.PlayerPictureBox.InitialImage = null;
            this.PlayerPictureBox.Location = new System.Drawing.Point(44, 103);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(202, 202);
            this.PlayerPictureBox.TabIndex = 2;
            this.PlayerPictureBox.TabStop = false;
            this.PlayerPictureBox.Click += new System.EventHandler(this.PlayerPictureBox_Click);
            // 
            // BotPictureBox
            // 
            this.BotPictureBox.ErrorImage = null;
            this.BotPictureBox.Image = global::RPS_Game.Properties.Resources.qq;
            this.BotPictureBox.InitialImage = null;
            this.BotPictureBox.Location = new System.Drawing.Point(473, 103);
            this.BotPictureBox.MinimumSize = new System.Drawing.Size(202, 202);
            this.BotPictureBox.Name = "BotPictureBox";
            this.BotPictureBox.Size = new System.Drawing.Size(202, 202);
            this.BotPictureBox.TabIndex = 3;
            this.BotPictureBox.TabStop = false;
            // 
            // RockButton
            // 
            this.RockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RockButton.BackgroundImage")));
            this.RockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.RockButton.Location = new System.Drawing.Point(44, 363);
            this.RockButton.MaximumSize = new System.Drawing.Size(144, 46);
            this.RockButton.MinimumSize = new System.Drawing.Size(144, 46);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(144, 46);
            this.RockButton.TabIndex = 4;
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaperButton.BackgroundImage")));
            this.PaperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaperButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.PaperButton.Location = new System.Drawing.Point(44, 421);
            this.PaperButton.MaximumSize = new System.Drawing.Size(144, 46);
            this.PaperButton.MinimumSize = new System.Drawing.Size(144, 46);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(144, 46);
            this.PaperButton.TabIndex = 5;
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScissorsButton.BackgroundImage")));
            this.ScissorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScissorsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.ScissorsButton.Location = new System.Drawing.Point(44, 478);
            this.ScissorsButton.MaximumSize = new System.Drawing.Size(144, 46);
            this.ScissorsButton.MinimumSize = new System.Drawing.Size(144, 46);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(144, 46);
            this.ScissorsButton.TabIndex = 6;
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // WinsNumber
            // 
            this.WinsNumber.BackColor = System.Drawing.Color.Transparent;
            this.WinsNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinsNumber.ForeColor = System.Drawing.Color.White;
            this.WinsNumber.Location = new System.Drawing.Point(602, 374);
            this.WinsNumber.Name = "WinsNumber";
            this.WinsNumber.Size = new System.Drawing.Size(65, 16);
            this.WinsNumber.TabIndex = 7;
            this.WinsNumber.Text = "0";
            this.WinsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WinsNumber.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // LossesNumber
            // 
            this.LossesNumber.BackColor = System.Drawing.Color.Transparent;
            this.LossesNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossesNumber.ForeColor = System.Drawing.Color.White;
            this.LossesNumber.Location = new System.Drawing.Point(602, 414);
            this.LossesNumber.Name = "LossesNumber";
            this.LossesNumber.Size = new System.Drawing.Size(65, 16);
            this.LossesNumber.TabIndex = 8;
            this.LossesNumber.Text = "0";
            this.LossesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DrawsNumber
            // 
            this.DrawsNumber.BackColor = System.Drawing.Color.Transparent;
            this.DrawsNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawsNumber.ForeColor = System.Drawing.Color.White;
            this.DrawsNumber.Location = new System.Drawing.Point(602, 455);
            this.DrawsNumber.Name = "DrawsNumber";
            this.DrawsNumber.Size = new System.Drawing.Size(65, 16);
            this.DrawsNumber.TabIndex = 9;
            this.DrawsNumber.Text = "0";
            this.DrawsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WinRateNumber
            // 
            this.WinRateNumber.BackColor = System.Drawing.Color.Transparent;
            this.WinRateNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinRateNumber.ForeColor = System.Drawing.Color.White;
            this.WinRateNumber.Location = new System.Drawing.Point(602, 496);
            this.WinRateNumber.Name = "WinRateNumber";
            this.WinRateNumber.Size = new System.Drawing.Size(65, 16);
            this.WinRateNumber.TabIndex = 10;
            this.WinRateNumber.Text = "0";
            this.WinRateNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RoundText
            // 
            this.RoundText.AutoSize = true;
            this.RoundText.BackColor = System.Drawing.Color.Transparent;
            this.RoundText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundText.ForeColor = System.Drawing.Color.White;
            this.RoundText.Location = new System.Drawing.Point(264, 271);
            this.RoundText.MinimumSize = new System.Drawing.Size(192, 40);
            this.RoundText.Name = "RoundText";
            this.RoundText.Size = new System.Drawing.Size(192, 40);
            this.RoundText.TabIndex = 11;
            this.RoundText.Text = "ROUND 1";
            this.RoundText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RoundText.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // VerdictText
            // 
            this.VerdictText.AutoSize = true;
            this.VerdictText.BackColor = System.Drawing.Color.Transparent;
            this.VerdictText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerdictText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(64)))), ((int)(((byte)(8)))));
            this.VerdictText.Location = new System.Drawing.Point(261, 105);
            this.VerdictText.MinimumSize = new System.Drawing.Size(197, 158);
            this.VerdictText.Name = "VerdictText";
            this.VerdictText.Size = new System.Drawing.Size(197, 158);
            this.VerdictText.TabIndex = 13;
            this.VerdictText.Text = "Welcome!";
            this.VerdictText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VerdictText.Click += new System.EventHandler(this.label1_Click_5);
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoButton.BackgroundImage")));
            this.GoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(64)))), ((int)(((byte)(8)))));
            this.GoButton.Location = new System.Drawing.Point(200, 363);
            this.GoButton.MaximumSize = new System.Drawing.Size(46, 161);
            this.GoButton.MinimumSize = new System.Drawing.Size(46, 161);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(46, 161);
            this.GoButton.TabIndex = 15;
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuButton.BackgroundImage")));
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(64)))), ((int)(((byte)(8)))));
            this.MenuButton.Location = new System.Drawing.Point(526, 20);
            this.MenuButton.MaximumSize = new System.Drawing.Size(54, 17);
            this.MenuButton.MinimumSize = new System.Drawing.Size(54, 17);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(54, 17);
            this.MenuButton.TabIndex = 16;
            this.MenuButton.UseVisualStyleBackColor = true;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.PlayerLabel.Location = new System.Drawing.Point(29, 63);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(100, 21);
            this.PlayerLabel.TabIndex = 19;
            this.PlayerLabel.Text = "PLAYER";
            this.PlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BotLabel
            // 
            this.BotLabel.BackColor = System.Drawing.Color.Transparent;
            this.BotLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.BotLabel.Location = new System.Drawing.Point(592, 63);
            this.BotLabel.Name = "BotLabel";
            this.BotLabel.Size = new System.Drawing.Size(100, 21);
            this.BotLabel.TabIndex = 20;
            this.BotLabel.Text = "CPU";
            this.BotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatsLabel
            // 
            this.StatsLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.StatsLabel.Location = new System.Drawing.Point(592, 323);
            this.StatsLabel.Name = "StatsLabel";
            this.StatsLabel.Size = new System.Drawing.Size(100, 21);
            this.StatsLabel.TabIndex = 22;
            this.StatsLabel.Text = "STATS";
            this.StatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChoicesLabel
            // 
            this.ChoicesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChoicesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.ChoicesLabel.Location = new System.Drawing.Point(29, 323);
            this.ChoicesLabel.Name = "ChoicesLabel";
            this.ChoicesLabel.Size = new System.Drawing.Size(100, 21);
            this.ChoicesLabel.TabIndex = 21;
            this.ChoicesLabel.Text = "CHOICES";
            this.ChoicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RematchBox
            // 
            this.RematchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RematchBox.ErrorImage = null;
            this.RematchBox.Image = ((System.Drawing.Image)(resources.GetObject("RematchBox.Image")));
            this.RematchBox.InitialImage = null;
            this.RematchBox.Location = new System.Drawing.Point(0, 1);
            this.RematchBox.Name = "RematchBox";
            this.RematchBox.Size = new System.Drawing.Size(720, 568);
            this.RematchBox.TabIndex = 23;
            this.RematchBox.TabStop = false;
            this.RematchBox.Visible = false;
            // 
            // RematchBox_VerdictText
            // 
            this.RematchBox_VerdictText.AutoSize = true;
            this.RematchBox_VerdictText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.RematchBox_VerdictText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RematchBox_VerdictText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.RematchBox_VerdictText.Location = new System.Drawing.Point(23, 138);
            this.RematchBox_VerdictText.MinimumSize = new System.Drawing.Size(365, 100);
            this.RematchBox_VerdictText.Name = "RematchBox_VerdictText";
            this.RematchBox_VerdictText.Size = new System.Drawing.Size(365, 100);
            this.RematchBox_VerdictText.TabIndex = 24;
            this.RematchBox_VerdictText.Text = "You Lost!";
            this.RematchBox_VerdictText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RematchBox_VerdictText.Visible = false;
            this.RematchBox_VerdictText.Click += new System.EventHandler(this.RematchBox_VerdictText_Click);
            // 
            // RematchBox_RematchButton
            // 
            this.RematchBox_RematchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RematchBox_RematchButton.BackgroundImage")));
            this.RematchBox_RematchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RematchBox_RematchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RematchBox_RematchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.RematchBox_RematchButton.Location = new System.Drawing.Point(130, 327);
            this.RematchBox_RematchButton.Name = "RematchBox_RematchButton";
            this.RematchBox_RematchButton.Size = new System.Drawing.Size(144, 46);
            this.RematchBox_RematchButton.TabIndex = 25;
            this.RematchBox_RematchButton.UseVisualStyleBackColor = true;
            this.RematchBox_RematchButton.Visible = false;
            // 
            // RematchBox_MenuButton
            // 
            this.RematchBox_MenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RematchBox_MenuButton.BackgroundImage")));
            this.RematchBox_MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RematchBox_MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RematchBox_MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.RematchBox_MenuButton.Location = new System.Drawing.Point(130, 385);
            this.RematchBox_MenuButton.Name = "RematchBox_MenuButton";
            this.RematchBox_MenuButton.Size = new System.Drawing.Size(144, 46);
            this.RematchBox_MenuButton.TabIndex = 26;
            this.RematchBox_MenuButton.UseVisualStyleBackColor = true;
            this.RematchBox_MenuButton.Visible = false;
            // 
            // RematchBox_SaveScoreButton
            // 
            this.RematchBox_SaveScoreButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RematchBox_SaveScoreButton.BackgroundImage")));
            this.RematchBox_SaveScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RematchBox_SaveScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RematchBox_SaveScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(64)))), ((int)(((byte)(8)))));
            this.RematchBox_SaveScoreButton.Location = new System.Drawing.Point(130, 443);
            this.RematchBox_SaveScoreButton.Name = "RematchBox_SaveScoreButton";
            this.RematchBox_SaveScoreButton.Size = new System.Drawing.Size(144, 46);
            this.RematchBox_SaveScoreButton.TabIndex = 27;
            this.RematchBox_SaveScoreButton.UseVisualStyleBackColor = true;
            this.RematchBox_SaveScoreButton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(23, 252);
            this.label1.MinimumSize = new System.Drawing.Size(365, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "YOU VS BOT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 209);
            this.label2.MinimumSize = new System.Drawing.Size(365, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 40);
            this.label2.TabIndex = 29;
            this.label2.Text = "0-1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RematchBox_SaveScoreButton);
            this.Controls.Add(this.RematchBox_MenuButton);
            this.Controls.Add(this.RematchBox_RematchButton);
            this.Controls.Add(this.RematchBox_VerdictText);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RematchBox);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StatsLabel);
            this.Controls.Add(this.ChoicesLabel);
            this.Controls.Add(this.BotLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.VerdictText);
            this.Controls.Add(this.RoundText);
            this.Controls.Add(this.WinRateNumber);
            this.Controls.Add(this.DrawsNumber);
            this.Controls.Add(this.LossesNumber);
            this.Controls.Add(this.WinsNumber);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.BotPictureBox);
            this.Controls.Add(this.PlayerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 570);
            this.MinimumSize = new System.Drawing.Size(720, 570);
            this.Name = "GameWindow";
            this.Text = "RPS Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RematchBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.PictureBox PlayerPictureBox;
        private System.Windows.Forms.PictureBox BotPictureBox;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Label WinsNumber;
        private System.Windows.Forms.Label LossesNumber;
        private System.Windows.Forms.Label DrawsNumber;
        private System.Windows.Forms.Label WinRateNumber;
        private System.Windows.Forms.Label RoundText;
        private System.Windows.Forms.Label VerdictText;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label BotLabel;
        private System.Windows.Forms.Label StatsLabel;
        private System.Windows.Forms.Label ChoicesLabel;
        private System.Windows.Forms.PictureBox RematchBox;
        private System.Windows.Forms.Label RematchBox_VerdictText;
        private System.Windows.Forms.Button RematchBox_RematchButton;
        private System.Windows.Forms.Button RematchBox_MenuButton;
        private System.Windows.Forms.Button RematchBox_SaveScoreButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

