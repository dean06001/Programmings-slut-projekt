using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        string who = "o";
        short moment = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = "o";
            moment = 0;
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.White;
            button2.Enabled = true; button2.Text = ""; button2.BackColor = Color.White;
            button3.Enabled = true; button3.Text = ""; button3.BackColor = Color.White;
            button4.Enabled = true; button4.Text = ""; button4.BackColor = Color.White;
            button5.Enabled = true; button5.Text = ""; button5.BackColor = Color.White;
            button6.Enabled = true; button6.Text = ""; button6.BackColor = Color.White;
            button7.Enabled = true; button7.Text = ""; button7.BackColor = Color.White;
            button8.Enabled = true; button8.Text = ""; button8.BackColor = Color.White;
            button9.Enabled = true; button9.Text = ""; button9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.Orange;
            if (who == "o")
            {
                bt.Text = "o";
                if ((b1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") ||
                    (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "") ||
                    (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "") ||
                    (b1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "") ||
                    (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "") ||
                    (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "") ||
                    (b1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "") ||
                    (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != ""))
                {
                    MessageBox.Show(($"The Winner is {who.ToString().ToUpper()}!!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (moment == 8)
                {
                    MessageBox.Show("Draw !!!");
                }
                who = "x";
            }
            else if (who == "x")
            {
                bt.Text = "x";
                if ((b1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") ||
                    (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "") ||
                    (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "") ||
                    (b1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "") ||
                    (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "") ||
                    (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "") ||
                    (b1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "") ||
                    (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != ""))
                {
                    MessageBox.Show(($"The Winner is {who.ToString().ToUpper()}!!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (moment == 8)
                {
                    MessageBox.Show("Draw !!!");
                }
                who = "o";
            }
            moment++;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
