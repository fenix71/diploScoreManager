using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using NLog;

namespace CoreDiploScore
{
    public  class DatabaseLoader
    {
        int Class_ActiveTournament = 0;
        string String_ActiveTournament = "";
        Logger MyLogger ;


        public DatabaseLoader()
        {
            MyLogger = LogManager.GetLogger("");
        }


        public string ActiveTournament_Name
        {
            get { return String_ActiveTournament; }
        }

        public int ActiveTournament
        {
            get { return Class_ActiveTournament; }
       }

        public  int GetRoundsForActiveTournament()
        {
            int NrOfRounds = 0;
            DipDbDataSet D1 = new DipDbDataSet();
            DipDbDataSetTableAdapters.tournamentsTableAdapter TTA = new DipDbDataSetTableAdapters.tournamentsTableAdapter();

            NrOfRounds =(int) TTA.GetActiveTournamentRounds();

            MyLogger.Debug("GetRoundsForActiveTournament NrOfRounds {0}", NrOfRounds.ToString());
            return NrOfRounds;
        }

       public bool InsertPlayer(string name, string surname, string email)
        {
            bool returnVal = false;
            try
            {
                DipDbDataSet D1 = new DipDbDataSet();

                DipDbDataSet.PlayersDataTable Dt1 = D1.Players;

                DipDbDataSetTableAdapters.PlayersTableAdapter DTA = new DipDbDataSetTableAdapters.PlayersTableAdapter();

                DTA.Fill(Dt1);

                DataRow MyDR = Dt1.NewRow();

                MyDR["Cognome"] = surname;
                MyDR["Nome"] = name;
                MyDR["Email"] = email;

                Dt1.Rows.Add(MyDR);

                DTA.Update(Dt1);

                D1.AcceptChanges();
                returnVal = true;
            }
            catch (Exception e)
            {

                MyLogger.Error("Errore in insert player", e);
                
            }
          


            return returnVal;

        }

        public  DataTable ReturnEmptyGame()
        {
            DataTable d1 = new DataTable();

            //aggiungo le colonne
            
            for (int i = 0; i < 7; i++)
            {
                d1.Columns.Add("0" + (i + 1).ToString(), typeof(Int32));
            }

            d1.Columns.Add("Pos" , typeof(Int32));
            d1.Columns.Add("Points", typeof(float));
            d1.Columns.Add("Personal Bonus", typeof(Int32));
           



            for (int i = 0; i < 7; i++)
            {
                DataRow MyDR = d1.NewRow();

                for (int k = 0; k < 7; k++)
                {
                    MyDR[k] = 0;
                }
                d1.Rows.Add(MyDR);

            }

            return d1;
            
        }

        //load the country list
        public string[] CountryList ()
        {
            string[] countries = { "Austria", "Germany", "Italy", "France", "UK", "Russia", "Turkey", "Total" };
            return countries;
        }



        public string[] TournamentPlayers;


        //wrapping for readability
          public string[] SingleTournamentPlayers()
          {

              //asking for tournament players
              return LoadPlayers(false);
          }
          public bool WritePlayersForRoundAndGame(string[] PlayerText, int Round_CB, int Game_CB)
          {
              bool retVal = false;

              CoreDiploScore.DipDbDataSet DataSet = new CoreDiploScore.DipDbDataSet();

              CoreDiploScore.DipDbDataSet.GamesDataTable Dt1 = DataSet.Games;

              CoreDiploScore.DipDbDataSetTableAdapters.GamesTableAdapter DTA = new DipDbDataSetTableAdapters.GamesTableAdapter();

              DTA.Fill(Dt1);
              DipDbDataSet.GamesRow myDR =   Dt1.NewGamesRow() ;
              int Counter = 1;//do not enter game id starting at the next position

              myDR[Counter] =Convert.ToInt32(Game_CB);
              Counter++;
              myDR[Counter] = Convert.ToInt32(Round_CB);
              Counter++;
              myDR[Counter] = Class_ActiveTournament;
              Counter++;

              for (int i = 0; i < CoreDiploScore.PublicClass.NUMBEROFPLAYERS; i++)
			{
			 // "Austria", "Germany", "Italy", "France", "UK", "Russia", "Turkey", "Total"
            string[] splitResult = PlayerText[i].Split(PublicClass.SeparatorChar);
            myDR[Counter+i] = Convert.ToInt32(splitResult[3]);
                                    
			}

              Dt1.Rows.Add(myDR);

              DTA.Update(DataSet.Games);

              return retVal;

          }

        public  string[] LoadPlayers(bool AllPlayers = true)
        {
            CoreDiploScore.DipDbDataSet DataSet = new CoreDiploScore.DipDbDataSet();

            CoreDiploScore.DipDbDataSet.PlayersDataTable Dt1 = DataSet.Players;

            CoreDiploScore.DipDbDataSetTableAdapters.PlayersTableAdapter DTA = new DipDbDataSetTableAdapters.PlayersTableAdapter();

            if (AllPlayers)
                DTA.Fill(Dt1);
            else DTA.FillPlayersByTournamentID(Dt1, Class_ActiveTournament);

            int numeroRighe = Dt1.Rows.Count;

            string[] Lista = new string[numeroRighe];


            for (int i = 0; i < numeroRighe; i++)
            {
                string outVal = Dt1.Rows[i].ItemArray[0].ToString();

                outVal = Dt1.Rows[i].ItemArray[3].ToString() + PublicClass.Separator + outVal;
                outVal = Dt1.Rows[i].ItemArray[2].ToString() + PublicClass.Separator + outVal;
                outVal = Dt1.Rows[i].ItemArray[1].ToString() + PublicClass.Separator + outVal;

                Lista[i] = outVal;
            }

            return Lista;
        }

        #region Tournaments

        private  DipDbDataSetTableAdapters.tournamentsTableAdapter GetTableAdapterForTournaments()
        {
            DipDbDataSet DataSet = new DipDbDataSet();
            
            DipDbDataSetTableAdapters.tournamentsTableAdapter DTA = new DipDbDataSetTableAdapters.tournamentsTableAdapter();

            return DTA;
        }

   

        public  void SetActiveTournament(string Tournament)
        {

            DipDbDataSetTableAdapters.tournamentsTableAdapter DTA = GetTableAdapterForTournaments();

            string[] PassedTournament = Tournament.Split(PublicClass.SeparatorChar);

            int PassedID =Convert.ToInt32(PassedTournament[0]);

            DTA.UpdateResetActiveTournaments();

            DTA.UpdateActiveTournament(PassedID);

            Class_ActiveTournament = PassedID;
            String_ActiveTournament = Tournament;
        }

        public  string[] LoadTournaments()
        {
            DipDbDataSetTableAdapters.tournamentsTableAdapter DTA = GetTableAdapterForTournaments();
            
            DipDbDataSet.tournamentsDataTable Dt1 = new DipDbDataSet.tournamentsDataTable();

            DTA.Fill(Dt1);
            int numeroRighe = Dt1.Rows.Count;

            string[] Lista = new string[numeroRighe];
            

            for (int i = 0; i < numeroRighe; i++)
            {
                string outVal = Dt1.Rows[i].ItemArray[0].ToString();
                outVal = outVal + PublicClass.Separator + Dt1.Rows[i].ItemArray[1].ToString();

                DateTime myDT = (DateTime)Dt1.Rows[i].ItemArray[2];


                outVal = outVal + PublicClass.Separator + myDT.ToShortDateString();

                outVal = outVal + PublicClass.Separator + Dt1.Rows[i].ItemArray[4].ToString();

                Lista[i] = outVal;

                if (Convert.ToBoolean(Dt1.Rows[i].ItemArray[3]) == true)
                { //update active tournament 
                    Class_ActiveTournament = Convert.ToInt32( Dt1.Rows[i].ItemArray[0]);
                    String_ActiveTournament = outVal;
                }

            }

            return Lista;
        }



        public  void SaveTournamentPlayers(string tournament, string[] Players)
        {
            DipDbDataSet DataSet = new DipDbDataSet();

            DipDbDataSet.Tournament_playerDataTable Dt1 = DataSet.Tournament_player;

            DipDbDataSetTableAdapters.Tournament_playerTableAdapter DTA = new DipDbDataSetTableAdapters.Tournament_playerTableAdapter();


            string[] T_TEMP_passed = tournament.Split(PublicClass.SeparatorChar);

            int tournamentID = Convert.ToInt32(T_TEMP_passed[0]);

            DTA.DeleteByTournamentID(tournamentID);
                                 

            int numeroRighe = Players.Count();

            for (int i = 0; i < numeroRighe; i++)
			{
			 string[] MyTemp = Players[i].Split(PublicClass.SeparatorChar);
 
               int playerID= Convert.ToInt32(MyTemp[3]);
                      
             DipDbDataSet.Tournament_playerRow myDR =   Dt1.NewTournament_playerRow() ; 

                myDR.PlayerID = playerID;
                myDR.TournamentID = tournamentID;

                Dt1.AddTournament_playerRow(myDR);

			}

            DTA.Update(Dt1);
  

        }

#endregion



    }
}
