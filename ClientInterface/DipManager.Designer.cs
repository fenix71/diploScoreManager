namespace ClientInterface
{
    partial class DipManager
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DipManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTournamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlayerGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Round = new System.Windows.Forms.ToolStripDropDownButton();
            this.startANewRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosePlayerForRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.bestCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.chooseScoreTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewScoreTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel4,
            this.Round,
            this.toolStripLabel3,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(529, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Scoring";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TournamentToolStripMenuItem,
            this.closeTournamenToolStripMenuItem,
            this.printResultsToolStripMenuItem});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "File";
            // 
            // TournamentToolStripMenuItem
            // 
            this.TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem";
            this.TournamentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.TournamentToolStripMenuItem.Text = "Tournament";
            this.TournamentToolStripMenuItem.Click += new System.EventHandler(this.openTournamentToolStripMenuItem_Click);
            // 
            // closeTournamenToolStripMenuItem
            // 
            this.closeTournamenToolStripMenuItem.Name = "closeTournamenToolStripMenuItem";
            this.closeTournamenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.closeTournamenToolStripMenuItem.Text = "Close Tournament";
            // 
            // printResultsToolStripMenuItem
            // 
            this.printResultsToolStripMenuItem.Name = "printResultsToolStripMenuItem";
            this.printResultsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.printResultsToolStripMenuItem.Text = "Print Results";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.removePlayerToolStripMenuItem,
            this.createPlayerGroupsToolStripMenuItem});
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel4.Text = "Players";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addPlayerToolStripMenuItem.Text = "Add player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removePlayerToolStripMenuItem.Text = "Remove player";
            // 
            // createPlayerGroupsToolStripMenuItem
            // 
            this.createPlayerGroupsToolStripMenuItem.Name = "createPlayerGroupsToolStripMenuItem";
            this.createPlayerGroupsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createPlayerGroupsToolStripMenuItem.Text = "Create player Groups";
            // 
            // Round
            // 
            this.Round.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Round.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startANewRoundToolStripMenuItem,
            this.choosePlayerForRoundToolStripMenuItem});
            this.Round.Image = ((System.Drawing.Image)(resources.GetObject("Round.Image")));
            this.Round.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(55, 22);
            this.Round.Text = "Round";
            // 
            // startANewRoundToolStripMenuItem
            // 
            this.startANewRoundToolStripMenuItem.Name = "startANewRoundToolStripMenuItem";
            this.startANewRoundToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.startANewRoundToolStripMenuItem.Text = "Start a new round";
            this.startANewRoundToolStripMenuItem.Click += new System.EventHandler(this.startANewRoundToolStripMenuItem_Click);
            // 
            // choosePlayerForRoundToolStripMenuItem
            // 
            this.choosePlayerForRoundToolStripMenuItem.Name = "choosePlayerForRoundToolStripMenuItem";
            this.choosePlayerForRoundToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.choosePlayerForRoundToolStripMenuItem.Text = "Choose players for round";
            this.choosePlayerForRoundToolStripMenuItem.Click += new System.EventHandler(this.choosePlayerForRoundToolStripMenuItem_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestCountryToolStripMenuItem,
            this.tableResultsToolStripMenuItem,
            this.rankingToolStripMenuItem});
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel3.Text = "Results";
            // 
            // bestCountryToolStripMenuItem
            // 
            this.bestCountryToolStripMenuItem.Name = "bestCountryToolStripMenuItem";
            this.bestCountryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bestCountryToolStripMenuItem.Text = "Best Country";
            // 
            // tableResultsToolStripMenuItem
            // 
            this.tableResultsToolStripMenuItem.Name = "tableResultsToolStripMenuItem";
            this.tableResultsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tableResultsToolStripMenuItem.Text = "Table results";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.rankingToolStripMenuItem.Text = "Ranking";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseScoreTypeToolStripMenuItem,
            this.createNewScoreTypeToolStripMenuItem});
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabel2.Text = "Scoring System";
            // 
            // chooseScoreTypeToolStripMenuItem
            // 
            this.chooseScoreTypeToolStripMenuItem.Name = "chooseScoreTypeToolStripMenuItem";
            this.chooseScoreTypeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.chooseScoreTypeToolStripMenuItem.Text = "Choose Score Type";
            // 
            // createNewScoreTypeToolStripMenuItem
            // 
            this.createNewScoreTypeToolStripMenuItem.Name = "createNewScoreTypeToolStripMenuItem";
            this.createNewScoreTypeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.createNewScoreTypeToolStripMenuItem.Text = "Create New Score Type";
            this.createNewScoreTypeToolStripMenuItem.Click += new System.EventHandler(this.createNewScoreTypeToolStripMenuItem_Click);
            // 
            // DipManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 386);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DipManager";
            this.Text = "Dip Manager v 0.1 -07-May-2015";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem TournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem chooseScoreTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewScoreTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTournamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem bestCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel4;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlayerGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Round;
        private System.Windows.Forms.ToolStripMenuItem choosePlayerForRoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startANewRoundToolStripMenuItem;
    }
}

