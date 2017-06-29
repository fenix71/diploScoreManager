namespace ClientInterface
{
    partial class Players_Insert
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
            this.Nome_TB = new System.Windows.Forms.TextBox();
            this.Cognome_TB = new System.Windows.Forms.TextBox();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Save_BT = new System.Windows.Forms.Button();
            this.labelRetVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome_TB
            // 
            this.Nome_TB.Location = new System.Drawing.Point(90, 49);
            this.Nome_TB.Name = "Nome_TB";
            this.Nome_TB.Size = new System.Drawing.Size(100, 20);
            this.Nome_TB.TabIndex = 0;
            // 
            // Cognome_TB
            // 
            this.Cognome_TB.Location = new System.Drawing.Point(90, 84);
            this.Cognome_TB.Name = "Cognome_TB";
            this.Cognome_TB.Size = new System.Drawing.Size(100, 20);
            this.Cognome_TB.TabIndex = 1;
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(90, 138);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(100, 20);
            this.Email_TB.TabIndex = 2;
            // 
            // Save_BT
            // 
            this.Save_BT.Location = new System.Drawing.Point(90, 193);
            this.Save_BT.Name = "Save_BT";
            this.Save_BT.Size = new System.Drawing.Size(100, 23);
            this.Save_BT.TabIndex = 3;
            this.Save_BT.Text = "Save";
            this.Save_BT.UseVisualStyleBackColor = true;
            this.Save_BT.Click += new System.EventHandler(this.Save_BT_Click);
            // 
            // labelRetVal
            // 
            this.labelRetVal.AutoSize = true;
            this.labelRetVal.Location = new System.Drawing.Point(109, 239);
            this.labelRetVal.Name = "labelRetVal";
            this.labelRetVal.Size = new System.Drawing.Size(61, 13);
            this.labelRetVal.TabIndex = 4;
            this.labelRetVal.Text = "labelRetVal";
            // 
            // Players_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelRetVal);
            this.Controls.Add(this.Save_BT);
            this.Controls.Add(this.Email_TB);
            this.Controls.Add(this.Cognome_TB);
            this.Controls.Add(this.Nome_TB);
            this.Name = "Players_Insert";
            this.Text = "Players_Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome_TB;
        private System.Windows.Forms.TextBox Cognome_TB;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.Button Save_BT;
        private System.Windows.Forms.Label labelRetVal;
    }
}