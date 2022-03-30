using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodenamesGroupProjectWinForms
{
    public partial class MainRulesPage : Form
    {
        public MainRulesPage()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            
            BoardGame newBoardGame = new BoardGame();
            newBoardGame.Show();
            this.Hide();
        }

        private void lblRule3_Click(object sender, EventArgs e)
        {

        }
    }
}
