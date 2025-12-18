using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class juzuk1q : Form
    {
        bool xTurn = true;
        int moves = 0;
        int xScore = 0;
        int oScore = 0;

        public juzuk1q()
        {
            InitializeComponent();
            UpdateTurnLabel();
        }

        private void UpdateTurnLabel()
        {
            lblMove.Text = $"Текущий ход: {(xTurn ? "X" : "O")}";
            lblMove.ForeColor = xTurn ? Color.Blue : Color.Red;
        }


        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text != "")
                return;

            btn.Text = xTurn ? "X" : "O";
            btn.ForeColor = xTurn ? Color.Blue : Color.Red;
            btn.Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold);

            moves++;

            if (CheckWin())
            {
                if (xTurn)
                {
                    xScore++;
                    winX.Text = $"Счёт X: {xScore}";
                }
                else
                {
                    oScore++;
                    winO.Text = $"Счёт О: {oScore}";
                }

                MessageBox.Show($"Победил {(xTurn ? "X" : "O")}!");
                DisableField();
                return;
            }

            if (moves == 9)
            {
                MessageBox.Show("Ничья!");
                return;
            }

            xTurn = !xTurn;
            UpdateTurnLabel();
        }

        private bool CheckWin()
        {
            Button[,] b =
            {
            { btn1, btn2, btn3 },
            { btn4, btn5, btn6 },
            { btn7, btn8, btn9 }
        };

            for (int i = 0; i < 3; i++)
            {
                if (b[i, 0].Text != "" && b[i, 0].Text == b[i, 1].Text && b[i, 1].Text == b[i, 2].Text)
                    return true;

                if (b[0, i].Text != "" && b[0, i].Text == b[1, i].Text && b[1, i].Text == b[2, i].Text)
                    return true;
            }

            if (b[0, 0].Text != "" && b[0, 0].Text == b[1, 1].Text && b[1, 1].Text == b[2, 2].Text)
                return true;

            if (b[0, 2].Text != "" && b[0, 2].Text == b[1, 1].Text && b[1, 1].Text == b[2, 0].Text)
                return true;

            return false;
        }
        private void DisableField()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && c.Name.StartsWith("btn"))
                    c.Enabled = false;
            }
        }

        private void newGame_btn_Click(object sender, EventArgs e)
        {
            Button[] buttons =
            {
        btn1, btn2, btn3,
        btn4, btn5, btn6,
        btn7, btn8, btn9
    };

            foreach (Button btn in buttons)
            {
                btn.Text = "";
                btn.Enabled = true;
            }

            xTurn = true;
            moves = 0;
            UpdateTurnLabel();
        }


    }
}
