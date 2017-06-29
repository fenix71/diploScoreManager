namespace ClientInterface
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
            this.Dg_Game = new System.Windows.Forms.DataGridView();
            this.Save_BT = new System.Windows.Forms.Button();
            this.Calculate_BT = new System.Windows.Forms.Button();
            this.Edit_BT = new System.Windows.Forms.Button();
            this.Player1_CB = new System.Windows.Forms.ComboBox();
            this.Player2_CB = new System.Windows.Forms.ComboBox();
            this.Player3_CB = new System.Windows.Forms.ComboBox();
            this.Player4_CB = new System.Windows.Forms.ComboBox();
            this.Player5_CB = new System.Windows.Forms.ComboBox();
            this.Player6_CB = new System.Windows.Forms.ComboBox();
            this.Player7_CB = new System.Windows.Forms.ComboBox();
            this.Round_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Game_CB = new System.Windows.Forms.ComboBox();
            this.Add_Game_BT = new System.Windows.Forms.Button();
            this.Remove_Game_BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Game)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg_Game
            // 
            this.Dg_Game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Game.Location = new System.Drawing.Point(12, 49);
            this.Dg_Game.Name = "Dg_Game";
            this.Dg_Game.Size = new System.Drawing.Size(564, 284);
            this.Dg_Game.TabIndex = 0;
            this.Dg_Game.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dg_Game_CellFormatting);
            this.Dg_Game.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Game_CellMouseLeave);
            // 
            // Save_BT
            // 
            this.Save_BT.Location = new System.Drawing.Point(501, 353);
            this.Save_BT.Name = "Save_BT";
            this.Save_BT.Size = new System.Drawing.Size(75, 23);
            this.Save_BT.TabIndex = 1;
            this.Save_BT.Text = "Save";
            this.Save_BT.UseVisualStyleBackColor = true;
            this.Save_BT.Click += new System.EventHandler(this.Save_BT_Click);
            // 
            // Calculate_BT
            // 
            this.Calculate_BT.Location = new System.Drawing.Point(194, 353);
            this.Calculate_BT.Name = "Calculate_BT";
            this.Calculate_BT.Size = new System.Drawing.Size(75, 23);
            this.Calculate_BT.TabIndex = 2;
            this.Calculate_BT.Text = "Calculate";
            this.Calculate_BT.UseVisualStyleBackColor = true;
            this.Calculate_BT.Click += new System.EventHandler(this.Calculate_BT_Click);
            // 
            // Edit_BT
            // 
            this.Edit_BT.Location = new System.Drawing.Point(33, 353);
            this.Edit_BT.Name = "Edit_BT";
            this.Edit_BT.Size = new System.Drawing.Size(75, 23);
            this.Edit_BT.TabIndex = 3;
            this.Edit_BT.Text = "Edit";
            this.Edit_BT.UseVisualStyleBackColor = true;
            // 
            // Player1_CB
            // 
            this.Player1_CB.FormattingEnabled = true;
            this.Player1_CB.Location = new System.Drawing.Point(582, 82);
            this.Player1_CB.Name = "Player1_CB";
            this.Player1_CB.Size = new System.Drawing.Size(241, 21);
            this.Player1_CB.TabIndex = 4;
            // 
            // Player2_CB
            // 
            this.Player2_CB.FormattingEnabled = true;
            this.Player2_CB.Location = new System.Drawing.Point(582, 105);
            this.Player2_CB.Name = "Player2_CB";
            this.Player2_CB.Size = new System.Drawing.Size(241, 21);
            this.Player2_CB.TabIndex = 5;
            // 
            // Player3_CB
            // 
            this.Player3_CB.FormattingEnabled = true;
            this.Player3_CB.Location = new System.Drawing.Point(582, 127);
            this.Player3_CB.Name = "Player3_CB";
            this.Player3_CB.Size = new System.Drawing.Size(241, 21);
            this.Player3_CB.TabIndex = 6;
            this.Player3_CB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Player4_CB
            // 
            this.Player4_CB.FormattingEnabled = true;
            this.Player4_CB.Location = new System.Drawing.Point(582, 148);
            this.Player4_CB.Name = "Player4_CB";
            this.Player4_CB.Size = new System.Drawing.Size(241, 21);
            this.Player4_CB.TabIndex = 7;
            // 
            // Player5_CB
            // 
            this.Player5_CB.FormattingEnabled = true;
            this.Player5_CB.Location = new System.Drawing.Point(582, 171);
            this.Player5_CB.Name = "Player5_CB";
            this.Player5_CB.Size = new System.Drawing.Size(241, 21);
            this.Player5_CB.TabIndex = 8;
            // 
            // Player6_CB
            // 
            this.Player6_CB.FormattingEnabled = true;
            this.Player6_CB.Location = new System.Drawing.Point(582, 196);
            this.Player6_CB.Name = "Player6_CB";
            this.Player6_CB.Size = new System.Drawing.Size(241, 21);
            this.Player6_CB.TabIndex = 9;
            // 
            // Player7_CB
            // 
            this.Player7_CB.FormattingEnabled = true;
            this.Player7_CB.Location = new System.Drawing.Point(582, 221);
            this.Player7_CB.Name = "Player7_CB";
            this.Player7_CB.Size = new System.Drawing.Size(241, 21);
            this.Player7_CB.TabIndex = 10;
            // 
            // Round_CB
            // 
            this.Round_CB.FormattingEnabled = true;
            this.Round_CB.Location = new System.Drawing.Point(12, 12);
            this.Round_CB.Name = "Round_CB";
            this.Round_CB.Size = new System.Drawing.Size(121, 21);
            this.Round_CB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Round";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Game";
            // 
            // Game_CB
            // 
            this.Game_CB.FormattingEnabled = true;
            this.Game_CB.Location = new System.Drawing.Point(305, 12);
            this.Game_CB.Name = "Game_CB";
            this.Game_CB.Size = new System.Drawing.Size(121, 21);
            this.Game_CB.TabIndex = 14;
            // 
            // Add_Game_BT
            // 
            this.Add_Game_BT.Location = new System.Drawing.Point(501, 10);
            this.Add_Game_BT.Name = "Add_Game_BT";
            this.Add_Game_BT.Size = new System.Drawing.Size(75, 23);
            this.Add_Game_BT.TabIndex = 15;
            this.Add_Game_BT.Text = "Add_Game";
            this.Add_Game_BT.UseVisualStyleBackColor = true;
            this.Add_Game_BT.Click += new System.EventHandler(this.Add_Game_BT_Click);
            // 
            // Remove_Game_BT
            // 
            this.Remove_Game_BT.Location = new System.Drawing.Point(594, 10);
            this.Remove_Game_BT.Name = "Remove_Game_BT";
            this.Remove_Game_BT.Size = new System.Drawing.Size(90, 23);
            this.Remove_Game_BT.TabIndex = 16;
            this.Remove_Game_BT.Text = "Remove_Game";
            this.Remove_Game_BT.UseVisualStyleBackColor = true;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 441);
            this.Controls.Add(this.Remove_Game_BT);
            this.Controls.Add(this.Add_Game_BT);
            this.Controls.Add(this.Game_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Round_CB);
            this.Controls.Add(this.Player7_CB);
            this.Controls.Add(this.Player6_CB);
            this.Controls.Add(this.Player5_CB);
            this.Controls.Add(this.Player4_CB);
            this.Controls.Add(this.Player3_CB);
            this.Controls.Add(this.Player2_CB);
            this.Controls.Add(this.Player1_CB);
            this.Controls.Add(this.Edit_BT);
            this.Controls.Add(this.Calculate_BT);
            this.Controls.Add(this.Save_BT);
            this.Controls.Add(this.Dg_Game);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_Game;
        private System.Windows.Forms.Button Save_BT;
        private System.Windows.Forms.Button Calculate_BT;
        private System.Windows.Forms.Button Edit_BT;
        private System.Windows.Forms.ComboBox Player1_CB;
        private System.Windows.Forms.ComboBox Player2_CB;
        private System.Windows.Forms.ComboBox Player3_CB;
        private System.Windows.Forms.ComboBox Player4_CB;
        private System.Windows.Forms.ComboBox Player5_CB;
        private System.Windows.Forms.ComboBox Player6_CB;
        private System.Windows.Forms.ComboBox Player7_CB;
        private System.Windows.Forms.ComboBox Round_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Game_CB;
        private System.Windows.Forms.Button Add_Game_BT;
        private System.Windows.Forms.Button Remove_Game_BT;
    }
}