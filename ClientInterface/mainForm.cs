using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInterface
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void PlayersBT_Click(object sender, EventArgs e)
        {
            PlayersList Pl = new PlayersList();
            Pl.Show();
        }

        private void GamesBt_Click(object sender, EventArgs e)
        {
            GameWindow g1 = new GameWindow();
            g1.Show();
        }

        private void TournamentsBt_Click(object sender, EventArgs e)
        {
            Tournaments Pl = new Tournaments();
            Pl.Show();
        }

        private void NewPlayerBT_Click(object sender, EventArgs e)
        {
            Players_Insert Pl = new Players_Insert();
            Pl.Show();
        }

        private void RoundBt_Click(object sender, EventArgs e)
        {

        }

        private void ScoreBt_Click(object sender, EventArgs e)
        {

        }
    }
}
