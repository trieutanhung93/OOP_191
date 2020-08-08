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
    public partial class FormPvsP : Form
    {
        public static bool turn = false;
        public bool ready = false;
        public FormPvsP()
        {
            InitializeComponent();
            CaroChess.namePlayer1 = "Player 1";
            CaroChess.namePlayer2 = "Player 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1.Text))
            {
                CaroChess.namePlayer1 = txt1.Text;
            }
            if (!string.IsNullOrEmpty(txt2.Text))
            {
                CaroChess.namePlayer2 = txt2.Text;
            }
            ready = true;
            turn = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
