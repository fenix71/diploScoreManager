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
    public partial class PlayersList : Form
    {
        DatabaseLoader D1;
        public PlayersList()
        {
            InitializeComponent();
            D1 = new DatabaseLoader();
            W_Players_LB.DataSource = D1.LoadPlayers();
        }
    }
}
