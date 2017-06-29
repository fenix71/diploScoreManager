using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreDiploScore;

namespace ClientInterface
{
    public partial class GameWindow : Form
    {
        string[] Countries;
        DatabaseLoader D1;
        public GameWindow()
        {
            InitializeComponent();
            D1 = new DatabaseLoader();

            //only to have the active tournament
            D1.LoadTournaments();
            //loading rounds per active tournament
            int NrofRounds = D1.GetRoundsForActiveTournament();

            for (int i = 0; i < NrofRounds; i++)
            {
                Round_CB.Items.Add(i+1);
            }
            //Selecting first round
            Round_CB.SelectedIndex = 0;
                       

        }


        private void Dg_Game_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;

            if (null != gridView)
            {

                gridView.Rows[e.RowIndex].HeaderCell.Value = Countries[e.RowIndex];
                //Todo width of rows
                gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;

            }
        }

        private void Dg_Game_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Game_BT_Click(object sender, EventArgs e)
        {
            Countries = D1.CountryList();

            Dg_Game.DataSource = D1.ReturnEmptyGame();


            int nCol = Dg_Game.Columns.Count;

            for (int i = 0; i < nCol - 1; i++)
            {
                Dg_Game.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; ;
            }

            //load players 
            string[] Players = D1.SingleTournamentPlayers();

            //loading players combobox
            for (int i = 0; i < CoreDiploScore.PublicClass.NUMBEROFPLAYERS; i++)
            {
                string ControlName = String.Format("Player{0}_CB", (i + 1).ToString());
                ComboBox myControl1 = (ComboBox)this.Controls.Find(ControlName, true).FirstOrDefault();
                myControl1.Items.AddRange(Players);
            }

            int NrOfItems=  Game_CB.Items.Count;
            string[] listGames = new string[NrOfItems];
 
            for (int i = 0; i < NrOfItems; i++)
			{
                listGames[i] = Game_CB.Items[i].ToString();
			}
            int maxGame;
            
            if (NrOfItems != 0)
            {
                maxGame = Convert.ToInt32(listGames[NrOfItems - 1]);
            }
            else maxGame = 0;

            Game_CB.Items.Add(maxGame + 1);
            Game_CB.SelectedIndex = Game_CB.Items.Count -1;

     
        }

        private void Save_BT_Click(object sender, EventArgs e)
        {
            string[] PlayerText = new string[CoreDiploScore.PublicClass.NUMBEROFPLAYERS];
            //Getting in all the players 
            for (int i = 0; i < CoreDiploScore.PublicClass.NUMBEROFPLAYERS; i++)
            {
                string ControlName = String.Format("Player{0}_CB", (i + 1).ToString());
                ComboBox myControl1 = (ComboBox)this.Controls.Find(ControlName, true).FirstOrDefault();
               PlayerText[i]= myControl1.SelectedItem.ToString();
            }

            D1.WritePlayersForRoundAndGame(PlayerText,
               Convert.ToInt32(Round_CB.SelectedItem.ToString()), Convert.ToInt32(Game_CB.SelectedItem.ToString()));

        }

        private void Calculate_BT_Click(object sender, EventArgs e)
        {

        }
    }
}
