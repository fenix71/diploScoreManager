namespace ClientInterface
{
    partial class mainForm
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
            this.PlayersBT = new System.Windows.Forms.Button();
            this.NewPlayerBT = new System.Windows.Forms.Button();
            this.GamesBt = new System.Windows.Forms.Button();
            this.RoundBt = new System.Windows.Forms.Button();
            this.ScoreBt = new System.Windows.Forms.Button();
            this.TournamentsBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayersBT
            // 
            this.PlayersBT.Location = new System.Drawing.Point(70, 41);
            this.PlayersBT.Name = "PlayersBT";
            this.PlayersBT.Size = new System.Drawing.Size(75, 23);
            this.PlayersBT.TabIndex = 0;
            this.PlayersBT.Text = "Players";
            this.PlayersBT.UseVisualStyleBackColor = true;
            this.PlayersBT.Click += new System.EventHandler(this.PlayersBT_Click);
            // 
            // NewPlayerBT
            // 
            this.NewPlayerBT.Location = new System.Drawing.Point(216, 41);
            this.NewPlayerBT.Name = "NewPlayerBT";
            this.NewPlayerBT.Size = new System.Drawing.Size(75, 23);
            this.NewPlayerBT.TabIndex = 1;
            this.NewPlayerBT.Text = "New Player";
            this.NewPlayerBT.UseVisualStyleBackColor = true;
            this.NewPlayerBT.Click += new System.EventHandler(this.NewPlayerBT_Click);
            // 
            // GamesBt
            // 
            this.GamesBt.Location = new System.Drawing.Point(70, 105);
            this.GamesBt.Name = "GamesBt";
            this.GamesBt.Size = new System.Drawing.Size(75, 23);
            this.GamesBt.TabIndex = 2;
            this.GamesBt.Text = "Games";
            this.GamesBt.UseVisualStyleBackColor = true;
            this.GamesBt.Click += new System.EventHandler(this.GamesBt_Click);
            // 
            // RoundBt
            // 
            this.RoundBt.Location = new System.Drawing.Point(216, 105);
            this.RoundBt.Name = "RoundBt";
            this.RoundBt.Size = new System.Drawing.Size(75, 23);
            this.RoundBt.TabIndex = 3;
            this.RoundBt.Text = "Round";
            this.RoundBt.UseVisualStyleBackColor = true;
            this.RoundBt.Click += new System.EventHandler(this.RoundBt_Click);
            // 
            // ScoreBt
            // 
            this.ScoreBt.Location = new System.Drawing.Point(70, 171);
            this.ScoreBt.Name = "ScoreBt";
            this.ScoreBt.Size = new System.Drawing.Size(75, 23);
            this.ScoreBt.TabIndex = 4;
            this.ScoreBt.Text = "Score";
            this.ScoreBt.UseVisualStyleBackColor = true;
            this.ScoreBt.Click += new System.EventHandler(this.ScoreBt_Click);
            // 
            // TournamentsBt
            // 
            this.TournamentsBt.Location = new System.Drawing.Point(216, 171);
            this.TournamentsBt.Name = "TournamentsBt";
            this.TournamentsBt.Size = new System.Drawing.Size(75, 23);
            this.TournamentsBt.TabIndex = 5;
            this.TournamentsBt.Text = "Tournaments";
            this.TournamentsBt.UseVisualStyleBackColor = true;
            this.TournamentsBt.Click += new System.EventHandler(this.TournamentsBt_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 379);
            this.Controls.Add(this.TournamentsBt);
            this.Controls.Add(this.ScoreBt);
            this.Controls.Add(this.RoundBt);
            this.Controls.Add(this.GamesBt);
            this.Controls.Add(this.NewPlayerBT);
            this.Controls.Add(this.PlayersBT);
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayersBT;
        private System.Windows.Forms.Button NewPlayerBT;
        private System.Windows.Forms.Button GamesBt;
        private System.Windows.Forms.Button RoundBt;
        private System.Windows.Forms.Button ScoreBt;
        private System.Windows.Forms.Button TournamentsBt;
    }
}

