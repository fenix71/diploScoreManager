namespace ClientInterface
{
    partial class PlayersList
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
            this.W_Players_LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // W_Players_LB
            // 
            this.W_Players_LB.FormattingEnabled = true;
            this.W_Players_LB.Location = new System.Drawing.Point(12, 12);
            this.W_Players_LB.Name = "W_Players_LB";
            this.W_Players_LB.Size = new System.Drawing.Size(173, 238);
            this.W_Players_LB.TabIndex = 0;
            // 
            // PlayersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.W_Players_LB);
            this.Name = "PlayersList";
            this.Text = "PlayersList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox W_Players_LB;
    }
}