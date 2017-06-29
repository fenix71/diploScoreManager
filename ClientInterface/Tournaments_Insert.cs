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
    public partial class Tournaments_Insert : Form
    {
        DatabaseLoader D1;
        public Tournaments_Insert()
        {
            InitializeComponent();
            D1 = new DatabaseLoader();
            reload();
        }

        private void Save_BT_Click(object sender, EventArgs e)
        {
            if (EDIT_BT.Enabled == true)
            {
                Save_BT.Text = "Save";
                EDIT_BT.Enabled = false;
                Tournament_LB.SelectedIndex = -1;
                NameTournament_TB.Text = "";
                NameTournament_TB.Enabled = true;
                return;
            }

            WriteToDB();
        }


        private void WriteToDB(int idToSave = 0)
        {
            //TODO: spostare dentro databaseloader
            DipDbDataSet D1 = new DipDbDataSet();

            DipDbDataSet.tournamentsDataTable Dt1 = D1.tournaments;

            CoreDiploScore.DipDbDataSetTableAdapters.tournamentsTableAdapter DTA = new CoreDiploScore.DipDbDataSetTableAdapters.tournamentsTableAdapter();

            if (idToSave > 0)
            {
                DTA.UpdateTournamentByID(NameTournament_TB.Text, Convert.ToDateTime(DateTournament_DTP.Value.ToShortDateString()), idToSave);
                return;
            }



            DTA.Fill(Dt1);


            DipDbDataSet.tournamentsRow MyDR = Dt1.NewtournamentsRow();

            MyDR["NameTournament"] = NameTournament_TB.Text;
            MyDR["DateEvent"] = DateTournament_DTP.Value.ToShortDateString();
            MyDR["Active"] = 1;
            MyDR["Rounds"] = Rounds_numUD.Value;




            Dt1.Rows.Add(MyDR);

            DTA.Update(Dt1);

            D1.AcceptChanges();

            reload();

        }


        private void reload()
        {
            string[] tournaments = D1.LoadTournaments();

            Tournament_LB.DataSource = tournaments;
        }



        private void EDIT_BT_Click(object sender, EventArgs e)
        {
            WriteToDB(Convert.ToInt32(Label_ID.Text));
            reload();
        }


        private void Tournament_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Save_BT.Text = "New Tournament";
            // Save_BT.IsEnabled = false;
            EDIT_BT.Enabled = true;
            string tournamentName = "";
            try
            {
                tournamentName = Tournament_LB.SelectedValue.ToString();
            }
            catch (Exception)
            {
                //TODO handle exception
                return;

            }


            string[] splitted = tournamentName.Split(CoreDiploScore.PublicClass.SeparatorChar);

            Label_ID.Text = splitted[0];


            NameTournament_TB.Text = splitted[1];
            DateTournament_DTP.Value = Convert.ToDateTime(splitted[2]);
            Rounds_numUD.Value = Convert.ToInt32(splitted[3]);

            NameTournament_TB.Enabled = true;
        }
    }
}
