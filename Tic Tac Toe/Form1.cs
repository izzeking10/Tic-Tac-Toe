using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public GameBoard gameBoard = new GameBoard();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                button.Text = gameBoard.userTurn;
            }
        }
    }
}
