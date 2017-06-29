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
    public partial class Players_Insert : Form
    {
        DatabaseLoader D1;
        public Players_Insert()
        {
            InitializeComponent();
            D1 = new DatabaseLoader();
        }

        private void Save_BT_Click(object sender, EventArgs e)
        {

            string Cognome = Cognome_TB.Text;
            string Nome = Nome_TB.Text;
            string Email = Email_TB.Text;

            if (D1.InsertPlayer(Nome, Cognome, Email))
                labelRetVal.Text = "Insert OK";
            else labelRetVal.Text = "Failed Insert";
        }
    }
}
