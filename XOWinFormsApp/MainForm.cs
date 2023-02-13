using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOWinFormsApp
{
    public partial class MainForm : Form
    {
        bool flag = true; // true = X, false = O
        public MainForm()
        {
            InitializeComponent();
        }

        private void a1button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if(flag==true)
            {
                clickedButton.Text = "X";
            }
            else
            {
                clickedButton.Text = "O";
            }
            clickedButton.Enabled = false;
            CheckWin();
            flag = !flag;
        }
        void CheckWin()
        {
            string winner = flag == true ? "X" : "O";

            //по горизонтали
            if(a1button.Text!="" && a1button.Text==a2button.Text && a3button.Text==a1button.Text)
            {
                MessageBox.Show("Выиграл "+ winner);
                IncreaseWinCount(winner);
                Restart();
                return;
            }
            if (b1button.Text != "" && b1button.Text == b2button.Text && b3button.Text == b1button.Text)
            {
                MessageBox.Show("Выиграл " + winner);
                IncreaseWinCount(winner);
                Restart();
                return;
            } 
            if (c1button.Text != "" && c1button.Text == c2button.Text && c3button.Text == c1button.Text)
            {
                MessageBox.Show("Выиграл " + winner);
                IncreaseWinCount(winner);
                Restart();
                return;
            }

            //по вертикали
            if(a1button.Text != "" && a1button.Text == b1button.Text && c1button.Text == a1button.Text)
            {
                MessageBox.Show("Выиграл " + winner);
                IncreaseWinCount(winner);
                Restart();
                return;
            }
            if (a2button.Text != "" && a2button.Text == b2button.Text && c2button.Text == a2button.Text)
            {
                MessageBox.Show("Выиграл " + winner);
                IncreaseWinCount(winner);
                Restart();
                return;
            }
            if (a3button.Text != "" && a3button.Text == b3button.Text && c3button.Text == a3button.Text)
            {
                MessageBox.Show("Выиграл " + winner);
                IncreaseWinCount(winner);
                Restart();
                return;
            }

            //  диагонали

            if (a1button.Text != "" && a1button.Text == b2button.Text && c3button.Text == a1button.Text)
            {
                MessageBox.Show("Выиграл " + winner);
                IncreaseWinCount(winner);
                Restart();
                return;
            }
            if (a3button.Text != "" && a3button.Text == b2button.Text && c1button.Text == a3button.Text)
            {
                MessageBox.Show("Выиграл " + winner);
                IncreaseWinCount(winner);
                Restart();
                return;
            }
            if(a1button.Enabled==false && a2button.Enabled==false && a3button.Enabled==false &&
                b1button.Enabled == false && b2button.Enabled == false && b3button.Enabled == false&&
                    c1button.Enabled == false && c2button.Enabled == false && c3button.Enabled == false)
            {
                MessageBox.Show("Ничья");
                winner = "d";
                IncreaseWinCount(winner);
                Restart();
                return;
            }
        }

        private void IncreaseWinCount(string result)
        {
            if (result=="d")
            {
                drawCountLabel.Text = (Convert.ToInt32(drawCountLabel.Text) + 1).ToString();
            }
            else
            if (result=="X")
            {
                xWinCountLabel.Text = (Convert.ToInt32(xWinCountLabel.Text) + 1).ToString();
            }
            else
            {
                oWinCountLabel.Text = (Convert.ToInt32(oWinCountLabel.Text) + 1).ToString();
            }
        }

        void Restart()
        {
            foreach (var control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "";
                    button.Enabled = true;
                }
            }
        }
        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
            //foreach (var control in Controls)
            //{
            //    if(control is Button)
            //    {
            //        Button button = (Button)control;
            //        button.Text = "";
            //        button.Enabled = true;
            //    }
            //}
        }

        private void скинутьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xWinCountLabel.Text = "0";
            oWinCountLabel.Text = "0";
            drawCountLabel.Text = "0";
        }

        private void a1button_MouseEnter(object sender, EventArgs e)
        {
            Button enteredButton = (Button)sender;
            if (flag == true)
            {
                enteredButton.Text = "X";
            }
            else
            {
                enteredButton.Text = "O";
            }

        }

        private void a1button_MouseLeave(object sender, EventArgs e)
        {
            Button leavedButton = (Button)sender;
            if(leavedButton.Enabled==true)
            {
                leavedButton.Text = "";
            }
        }
    }
}
