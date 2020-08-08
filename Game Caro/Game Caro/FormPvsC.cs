using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_caro
{
    public partial class FormPvsC : Form
    {
        public static int turn;
        private bool checkReady;
        public bool ready = false;
        public FormPvsC()
        {
            InitializeComponent();
            checkReady = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkReady == true)
            {
                ready = true;
                Close();
            }
            else
            {
                MessageBox.Show("Please choose your turn", "Inform", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            turn = 2;
            checkReady = true;
            CaroChess.namePlayer1 = "You";
            CaroChess.namePlayer2 = "Computer";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            turn = 1;
            checkReady = true;
            CaroChess.namePlayer2 = "You";
            CaroChess.namePlayer1 = "Computer";
        }

    }
}
