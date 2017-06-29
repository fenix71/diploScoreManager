using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientInterface
{
    public partial class DipManager : Form
    {
        public DipManager()
        {
            InitializeComponent();
        }

        private void openTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tournaments Pl = new Tournaments();
            Pl.Show();
        }

     
        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Players_Insert Pl = new Players_Insert();
            Pl.Show();
        }

        private void createNewScoreTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void choosePlayerForRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tournaments Pl = new Tournaments();
            Pl.Show();
        }

        private void startANewRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        }
    }

