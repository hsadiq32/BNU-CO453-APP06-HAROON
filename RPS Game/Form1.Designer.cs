
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
            this.components = new System.ComponentModel.Container();
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
            this.CountdownText = new System.Windows.Forms.Label();
            this.VerdictText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HelpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotPictureBox)).BeginInit();
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
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.ResetButton.Location = new System.Drawing.Point(586, 20);
            this.ResetButton.MaximumSize = new System.Drawing.Size(54, 17);
            this.ResetButton.MinimumSize = new System.Drawing.Size(54, 17);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(54, 17);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.ErrorImage = null;
            this.PlayerPictureBox.Image = global::RPS_Game.Properties.Resources.qq;
            this.PlayerPictureBox.InitialImage = null;
            this.PlayerPictureBox.Location = new System.Drawing.Point(48, 104);
            this.PlayerPictureBox.MaximumSize = new System.Drawing.Size(194, 194);
            this.PlayerPictureBox.MinimumSize = new System.Drawing.Size(194, 194);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(194, 194);
            this.PlayerPictureBox.TabIndex = 2;
            this.PlayerPictureBox.TabStop = false;
            this.PlayerPictureBox.Click += new System.EventHandler(this.PlayerPictureBox_Click);
            // 
            // BotPictureBox
            // 
            this.BotPictureBox.ErrorImage = null;
            this.BotPictureBox.Image = global::RPS_Game.Properties.Resources.qq;
            this.BotPictureBox.InitialImage = null;
            this.BotPictureBox.Location = new System.Drawing.Point(477, 104);
            this.BotPictureBox.MaximumSize = new System.Drawing.Size(194, 194);
            this.BotPictureBox.MinimumSize = new System.Drawing.Size(194, 194);
            this.BotPictureBox.Name = "BotPictureBox";
            this.BotPictureBox.Size = new System.Drawing.Size(194, 194);
            this.BotPictureBox.TabIndex = 3;
            this.BotPictureBox.TabStop = false;
            // 
            // RockButton
            // 
            this.RockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RockButton.BackgroundImage")));
            this.RockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.RockButton.Location = new System.Drawing.Point(28, 383);
            this.RockButton.MaximumSize = new System.Drawing.Size(207, 41);
            this.RockButton.MinimumSize = new System.Drawing.Size(207, 41);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(207, 41);
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
            this.PaperButton.Location = new System.Drawing.Point(28, 438);
            this.PaperButton.MaximumSize = new System.Drawing.Size(207, 41);
            this.PaperButton.MinimumSize = new System.Drawing.Size(207, 41);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(207, 41);
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
            this.ScissorsButton.Location = new System.Drawing.Point(28, 493);
            this.ScissorsButton.MaximumSize = new System.Drawing.Size(207, 41);
            this.ScissorsButton.MinimumSize = new System.Drawing.Size(207, 41);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(207, 41);
            this.ScissorsButton.TabIndex = 6;
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // WinsNumber
            // 
            this.WinsNumber.AutoSize = true;
            this.WinsNumber.BackColor = System.Drawing.Color.Transparent;
            this.WinsNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinsNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.WinsNumber.Location = new System.Drawing.Point(360, 396);
            this.WinsNumber.Name = "WinsNumber";
            this.WinsNumber.Size = new System.Drawing.Size(15, 17);
            this.WinsNumber.TabIndex = 7;
            this.WinsNumber.Text = "0";
            this.WinsNumber.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // LossesNumber
            // 
            this.LossesNumber.AutoSize = true;
            this.LossesNumber.BackColor = System.Drawing.Color.Transparent;
            this.LossesNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossesNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.LossesNumber.Location = new System.Drawing.Point(360, 429);
            this.LossesNumber.Name = "LossesNumber";
            this.LossesNumber.Size = new System.Drawing.Size(15, 17);
            this.LossesNumber.TabIndex = 8;
            this.LossesNumber.Text = "0";
            // 
            // DrawsNumber
            // 
            this.DrawsNumber.AutoSize = true;
            this.DrawsNumber.BackColor = System.Drawing.Color.Transparent;
            this.DrawsNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawsNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.DrawsNumber.Location = new System.Drawing.Point(360, 463);
            this.DrawsNumber.Name = "DrawsNumber";
            this.DrawsNumber.Size = new System.Drawing.Size(15, 17);
            this.DrawsNumber.TabIndex = 9;
            this.DrawsNumber.Text = "0";
            // 
            // WinRateNumber
            // 
            this.WinRateNumber.AutoSize = true;
            this.WinRateNumber.BackColor = System.Drawing.Color.Transparent;
            this.WinRateNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinRateNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.WinRateNumber.Location = new System.Drawing.Point(360, 496);
            this.WinRateNumber.Name = "WinRateNumber";
            this.WinRateNumber.Size = new System.Drawing.Size(15, 17);
            this.WinRateNumber.TabIndex = 10;
            this.WinRateNumber.Text = "0";
            // 
            // RoundText
            // 
            this.RoundText.AutoSize = true;
            this.RoundText.BackColor = System.Drawing.Color.Transparent;
            this.RoundText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.RoundText.Location = new System.Drawing.Point(244, 221);
            this.RoundText.MinimumSize = new System.Drawing.Size(231, 40);
            this.RoundText.Name = "RoundText";
            this.RoundText.Size = new System.Drawing.Size(231, 40);
            this.RoundText.TabIndex = 11;
            this.RoundText.Text = "ROUND 1";
            this.RoundText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RoundText.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // CountdownText
            // 
            this.CountdownText.AutoSize = true;
            this.CountdownText.BackColor = System.Drawing.Color.Transparent;
            this.CountdownText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.CountdownText.Location = new System.Drawing.Point(244, 185);
            this.CountdownText.MinimumSize = new System.Drawing.Size(231, 40);
            this.CountdownText.Name = "CountdownText";
            this.CountdownText.Size = new System.Drawing.Size(231, 40);
            this.CountdownText.TabIndex = 12;
            this.CountdownText.Text = "5";
            this.CountdownText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountdownText.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // VerdictText
            // 
            this.VerdictText.AutoSize = true;
            this.VerdictText.BackColor = System.Drawing.Color.Transparent;
            this.VerdictText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerdictText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(141)))), ((int)(((byte)(6)))));
            this.VerdictText.Location = new System.Drawing.Point(244, 145);
            this.VerdictText.MinimumSize = new System.Drawing.Size(231, 40);
            this.VerdictText.Name = "VerdictText";
            this.VerdictText.Size = new System.Drawing.Size(231, 40);
            this.VerdictText.TabIndex = 13;
            this.VerdictText.Text = "hgnvghjcv";
            this.VerdictText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VerdictText.Click += new System.EventHandler(this.label1_Click_5);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.BackColor = System.Drawing.Color.Transparent;
            this.HelpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.HelpLabel.Location = new System.Drawing.Point(245, 141);
            this.HelpLabel.MinimumSize = new System.Drawing.Size(231, 40);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(231, 42);
            this.HelpLabel.TabIndex = 14;
            this.HelpLabel.Text = "Press a choice to \r\nstart the round";
            this.HelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HelpLabel.Click += new System.EventHandler(this.label1_Click_6);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 570);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.VerdictText);
            this.Controls.Add(this.CountdownText);
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
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 570);
            this.MinimumSize = new System.Drawing.Size(720, 570);
            this.Name = "GameWindow";
            this.Text = "RPS Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotPictureBox)).EndInit();
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
        private System.Windows.Forms.Label CountdownText;
        private System.Windows.Forms.Label VerdictText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label HelpLabel;
    }
}

