namespace ClientInterface
{
    partial class Tournaments_Insert
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
            this.Tournament_LB = new System.Windows.Forms.ListBox();
            this.Save_BT = new System.Windows.Forms.Button();
            this.Label_ID = new System.Windows.Forms.Label();
            this.NameTournament_TB = new System.Windows.Forms.TextBox();
            this.DateTournament_DTP = new System.Windows.Forms.DateTimePicker();
            this.EDIT_BT = new System.Windows.Forms.Button();
            this.Rounds_numUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Rounds_numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Tournament_LB
            // 
            this.Tournament_LB.FormattingEnabled = true;
            this.Tournament_LB.Location = new System.Drawing.Point(12, 12);
            this.Tournament_LB.Name = "Tournament_LB";
            this.Tournament_LB.Size = new System.Drawing.Size(183, 485);
            this.Tournament_LB.TabIndex = 0;
            this.Tournament_LB.SelectedIndexChanged += new System.EventHandler(this.Tournament_LB_SelectedIndexChanged);
            // 
            // Save_BT
            // 
            this.Save_BT.Location = new System.Drawing.Point(240, 12);
            this.Save_BT.Name = "Save_BT";
            this.Save_BT.Size = new System.Drawing.Size(174, 23);
            this.Save_BT.TabIndex = 1;
            this.Save_BT.Text = "New Tournament";
            this.Save_BT.UseVisualStyleBackColor = true;
            this.Save_BT.Click += new System.EventHandler(this.Save_BT_Click);
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Location = new System.Drawing.Point(464, 17);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(18, 13);
            this.Label_ID.TabIndex = 2;
            this.Label_ID.Text = "ID";
            // 
            // NameTournament_TB
            // 
            this.NameTournament_TB.Location = new System.Drawing.Point(240, 61);
            this.NameTournament_TB.Name = "NameTournament_TB";
            this.NameTournament_TB.Size = new System.Drawing.Size(174, 20);
            this.NameTournament_TB.TabIndex = 3;
            // 
            // DateTournament_DTP
            // 
            this.DateTournament_DTP.Location = new System.Drawing.Point(231, 111);
            this.DateTournament_DTP.Name = "DateTournament_DTP";
            this.DateTournament_DTP.Size = new System.Drawing.Size(200, 20);
            this.DateTournament_DTP.TabIndex = 4;
            // 
            // EDIT_BT
            // 
            this.EDIT_BT.Location = new System.Drawing.Point(286, 164);
            this.EDIT_BT.Name = "EDIT_BT";
            this.EDIT_BT.Size = new System.Drawing.Size(75, 23);
            this.EDIT_BT.TabIndex = 5;
            this.EDIT_BT.Text = "Edit";
            this.EDIT_BT.UseVisualStyleBackColor = true;
            this.EDIT_BT.Click += new System.EventHandler(this.EDIT_BT_Click);
            // 
            // Rounds_numUD
            // 
            this.Rounds_numUD.Location = new System.Drawing.Point(311, 231);
            this.Rounds_numUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rounds_numUD.Name = "Rounds_numUD";
            this.Rounds_numUD.Size = new System.Drawing.Size(120, 20);
            this.Rounds_numUD.TabIndex = 6;
            this.Rounds_numUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of rounds";
            // 
            // Tournaments_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rounds_numUD);
            this.Controls.Add(this.EDIT_BT);
            this.Controls.Add(this.DateTournament_DTP);
            this.Controls.Add(this.NameTournament_TB);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.Save_BT);
            this.Controls.Add(this.Tournament_LB);
            this.Name = "Tournaments_Insert";
            this.Text = "Tournaments_Insert";
            ((System.ComponentModel.ISupportInitialize)(this.Rounds_numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Tournament_LB;
        private System.Windows.Forms.Button Save_BT;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.TextBox NameTournament_TB;
        private System.Windows.Forms.DateTimePicker DateTournament_DTP;
        private System.Windows.Forms.Button EDIT_BT;
        private System.Windows.Forms.NumericUpDown Rounds_numUD;
        private System.Windows.Forms.Label label1;
    }
}