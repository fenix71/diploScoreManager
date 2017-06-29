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
using System.Collections;

namespace ClientInterface
{
    public partial class Tournaments : Form
    {
        DatabaseLoader D1;
        public Tournaments()
        {
            InitializeComponent();
            D1 = new DatabaseLoader();
            ReLoad();
        }
        private void ReLoad()
        {

            //    string[] tournaments = DatabaseLoader.LoadTournaments();
            //Tournament_CB.BindingContext

            string[] Tournaments = D1.LoadTournaments();
                Tournament_CB.DataSource = Tournaments;
          
              //  Tournament_CB.DataSource = tournaments.Clone();

              //I'll put the active tournament as active in the list
         //     Tournament_CB.SelectedText = DatabaseLoader.ActiveTournament_Name;
                Tournament_CB.SelectedIndex = Tournament_CB.FindString(D1.ActiveTournament_Name);

                string[] LoadedPlayers = D1.LoadPlayers();


            //loading players for the active tournament
                string[] ActiveTournamentPlayers = D1.SingleTournamentPlayers();


            int numOfTournamentPlayers = ActiveTournamentPlayers.Count();
            int numOfPlayers = LoadedPlayers.Count();
            ArrayList NotSubscribedPlayers = new ArrayList();

            //REFACTOR ? move in database loader? can be improved
            for (int i = 0; i < numOfPlayers; i++)
            {
                bool trovato = false;
                for (int k = 0; k < numOfTournamentPlayers; k++)
                {

                    if (LoadedPlayers[i] == ActiveTournamentPlayers[k])
                    {
                        trovato = true;
                        break;
                    }

                }
                if (!trovato)
                    NotSubscribedPlayers.Add(LoadedPlayers[i]);

            }

            //filling the listBox
            string[] LeftList = (string[])NotSubscribedPlayers.ToArray(typeof(string));

            Players_LB.DataSource = LeftList.Clone();



            Tournament_LB.DataSource = ActiveTournamentPlayers.Clone();


            int subScribedPlayers = Tournament_LB.Items.Count;

            NumberOfPlayers_Lab.Text = subScribedPlayers.ToString();

        }



        private void MoveRight_BT_Click(object sender, EventArgs e)
        {
            HandlePlayers();
           
        }

        private void MoveLeft_BT_Click(object sender, EventArgs e)
        {
            HandlePlayers(2);

        }


        private void Tournament_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string SelectedTournament = Tournament_CB.SelectedValue.ToString();

                D1.SetActiveTournament(SelectedTournament);

                ReLoad();
            }
            catch (Exception e1)
            {

                //TO do log it and handle it
            }


            //load players 

        }

        private void Tournament_CB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Tournaments_Insert Pl = new Tournaments_Insert();
            Pl.Show();
            ReLoad();
        }

        //handle the moving of the selected players
        //1 = from left to right
        //2 =from right to left 

        private void HandlePlayers(int direction = 1)
        {
            if (Tournament_CB.SelectedIndex == -1)
            {
                MessageBox.Show("You have to choose a tournament, or create one doubleclicking on ComboBox", "Confirmation");
                return;
            }


            ArrayList tournamentPlayers = new ArrayList();
            tournamentPlayers.AddRange((string[])Tournament_LB.DataSource); ;

            ArrayList AllPlayers = new ArrayList();

            AllPlayers.AddRange((string[])Players_LB.DataSource);
            int numOf;
            object[] objCollection;

            switch (direction)
            {
                case 1:
                    if (Players_LB.SelectedItems.Count > 0)
                    {
                        numOf = Players_LB.SelectedItems.Count;
                        objCollection = new object[numOf];

                        Players_LB.SelectedItems.CopyTo(objCollection, 0);

                        for (int i = 0; i < numOf; i++)
                        {
                            if (!Tournament_LB.Items.Contains(objCollection[i]))
                            {
                                tournamentPlayers.Add(objCollection[i]);
                                AllPlayers.Remove(objCollection[i]);

                            }
                        }

                    }
                    break;

                case 2:
                    if (Tournament_LB.SelectedItems.Count > 0)
                    {
                        numOf = Tournament_LB.SelectedItems.Count;
                        objCollection = new object[numOf];

                        Tournament_LB.SelectedItems.CopyTo(objCollection, 0);

                        for (int i = 0; i < numOf; i++)
                        {
                            if (!Players_LB.Items.Contains(objCollection[i]))
                            {
                                tournamentPlayers.Remove(objCollection[i]);
                                AllPlayers.Add(objCollection[i]);

                            }
                        }

                    }
                    break;

                default:
                    //todo handle an error
                    break;
            }


            Players_LB.DataSource = AllPlayers;
            Tournament_LB.DataSource = tournamentPlayers;
                        

            int subScribedPlayers = Tournament_LB.Items.Count;


            string[] Players = new string[subScribedPlayers];

            for (int i = 0; i < subScribedPlayers; i++)
            {
                Players[i] = Tournament_LB.Items[i].ToString();
            }

            //SaveTournamentPlayers
            D1.SaveTournamentPlayers(Tournament_CB.SelectedValue.ToString(), Players);

            ReLoad();

        }
  

   

        private void New_Tournament_BT_Click(object sender, EventArgs e)
        {
            Tournaments_Insert Pl = new Tournaments_Insert();
            Pl.Show();
            ReLoad();
        }
    }
}
