namespace ClientInterface
{
    partial class Tournaments
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
            this.Tournament_CB = new System.Windows.Forms.ComboBox();
            this.Players_LB = new System.Windows.Forms.ListBox();
            this.Tournament_LB = new System.Windows.Forms.ListBox();
            this.MoveRight_BT = new System.Windows.Forms.Button();
            this.MoveLeft_BT = new System.Windows.Forms.Button();
            this.NumberOfPlayers_Lab = new System.Windows.Forms.Label();
            this.New_Tournament_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tournament_CB
            // 
            this.Tournament_CB.FormattingEnabled = true;
            this.Tournament_CB.Location = new System.Drawing.Point(399, 23);
            this.Tournament_CB.Name = "Tournament_CB";
            this.Tournament_CB.Size = new System.Drawing.Size(248, 21);
            this.Tournament_CB.TabIndex = 0;
            this.Tournament_CB.SelectedIndexChanged += new System.EventHandler(this.Tournament_CB_SelectedIndexChanged);
            this.Tournament_CB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tournament_CB_MouseDoubleClick);
            // 
            // Players_LB
            // 
            this.Players_LB.FormattingEnabled = true;
            this.Players_LB.Location = new System.Drawing.Point(12, 60);
            this.Players_LB.Name = "Players_LB";
            this.Players_LB.Size = new System.Drawing.Size(248, 433);
            this.Players_LB.TabIndex = 1;
            // 
            // Tournament_LB
            // 
            this.Tournament_LB.FormattingEnabled = true;
            this.Tournament_LB.Location = new System.Drawing.Point(399, 60);
            this.Tournament_LB.Name = "Tournament_LB";
            this.Tournament_LB.Size = new System.Drawing.Size(248, 433);
            this.Tournament_LB.TabIndex = 2;
            // 
            // MoveRight_BT
            // 
            this.MoveRight_BT.Location = new System.Drawing.Point(297, 187);
            this.MoveRight_BT.Name = "MoveRight_BT";
            this.MoveRight_BT.Size = new System.Drawing.Size(75, 23);
            this.MoveRight_BT.TabIndex = 3;
            this.MoveRight_BT.Text = ">>>";
            this.MoveRight_BT.UseVisualStyleBackColor = true;
            this.MoveRight_BT.Click += new System.EventHandler(this.MoveRight_BT_Click);
            // 
            // MoveLeft_BT
            // 
            this.MoveLeft_BT.Location = new System.Drawing.Point(297, 298);
            this.MoveLeft_BT.Name = "MoveLeft_BT";
            this.MoveLeft_BT.Size = new System.Drawing.Size(75, 23);
            this.MoveLeft_BT.TabIndex = 4;
            this.MoveLeft_BT.Text = "<<<";
            this.MoveLeft_BT.UseVisualStyleBackColor = true;
            this.MoveLeft_BT.Click += new System.EventHandler(this.MoveLeft_BT_Click);
            // 
            // NumberOfPlayers_Lab
            // 
            this.NumberOfPlayers_Lab.AutoSize = true;
            this.NumberOfPlayers_Lab.Location = new System.Drawing.Point(497, 508);
            this.NumberOfPlayers_Lab.Name = "NumberOfPlayers_Lab";
            this.NumberOfPlayers_Lab.Size = new System.Drawing.Size(15, 13);
            this.NumberOfPlayers_Lab.TabIndex = 5;
            this.NumberOfPlayers_Lab.Text = "N";
            // 
            // New_Tournament_BT
            // 
            this.New_Tournament_BT.Location = new System.Drawing.Point(268, 23);
            this.New_Tournament_BT.Name = "New_Tournament_BT";
            this.New_Tournament_BT.Size = new System.Drawing.Size(125, 23);
            this.New_Tournament_BT.TabIndex = 6;
            this.New_Tournament_BT.Text = "New Tournament";
            this.New_Tournament_BT.UseVisualStyleBackColor = true;
            this.New_Tournament_BT.Click += new System.EventHandler(this.New_Tournament_BT_Click);
            // 
            // Tournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 539);
            this.Controls.Add(this.New_Tournament_BT);
            this.Controls.Add(this.NumberOfPlayers_Lab);
            this.Controls.Add(this.MoveLeft_BT);
            this.Controls.Add(this.MoveRight_BT);
            this.Controls.Add(this.Tournament_LB);
            this.Controls.Add(this.Players_LB);
            this.Controls.Add(this.Tournament_CB);
            this.Name = "Tournaments";
            this.Text = "Tournaments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tournament_CB;
        private System.Windows.Forms.ListBox Players_LB;
        private System.Windows.Forms.ListBox Tournament_LB;
        private System.Windows.Forms.Button MoveRight_BT;
        private System.Windows.Forms.Button MoveLeft_BT;
        private System.Windows.Forms.Label NumberOfPlayers_Lab;
        private System.Windows.Forms.Button New_Tournament_BT;
    }
}