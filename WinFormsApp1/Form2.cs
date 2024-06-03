using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private bool vann;
        public Form2()
        {
            InitializeComponent();
        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void Dator_Click(object sender, EventArgs e)
        {

        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            PlayerText.Text = RandomNumber(14).ToString();
            DatorText.Text = RandomNumber(14).ToString();

            btnDeal.Enabled = false;

            if (PlayerText.Text == "0")
            {
                PlayerText.Text = RandomNumber(14).ToString();
            }

            if (DatorText.Text == "0")
            {
                DatorText.Text = RandomNumber(14).ToString();
            }
            if (vann == true)
            {
                btnHit.Enabled = false;
            }
        }

        private int RandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(1, max + 1);
        }

        private void DatorScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            PlayerText.Text = (int.Parse(PlayerText.Text) + RandomNumber(14)).ToString();

            int dealerScore = int.Parse(DatorText.Text);

            if (dealerScore < 18)
            {
                DatorText.Text = (dealerScore + RandomNumber(14)).ToString();
                dealerScore = int.Parse(DatorText.Text);
            }

            int playerScore = int.Parse(PlayerText.Text);

            if (playerScore >= 21 || dealerScore >= 21)
            {
                CheckWinner();
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            int playerScore = int.Parse(PlayerText.Text);
            int dealerScore = int.Parse(DatorText.Text);

            while (dealerScore < 18)
            {
                dealerScore += RandomNumber(14);
                DatorText.Text = dealerScore.ToString();
            }

            if (dealerScore < playerScore)
            {
                dealerScore += RandomNumber(14);
                DatorText.Text = dealerScore.ToString();
            }

            if (playerScore >= 21 || dealerScore >= 21)
            {
                CheckWinner();
            }
        }

        private void CheckWinner()
        {
            int playerScore = int.Parse(PlayerText.Text);
            int dealerScore = int.Parse(DatorText.Text);
            btnStand.Enabled = false;
            btnHit.Enabled = false;
            btnDeal.Enabled = false;

            if (playerScore > 21)
            {
                MessageBox.Show("Player Busts! Dealer Wins!");
            }
            else if (dealerScore > 21)
            {
                MessageBox.Show("Dealer Busts! Player Wins!");
            }
            else
            {
                if (playerScore > dealerScore)
                {
                    MessageBox.Show("Player Wins!");
                }
                else if (dealerScore > playerScore)
                {
                    MessageBox.Show("Dealer Wins!");
                }
                else
                {
                    MessageBox.Show("Dealer Wins!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PlayerText.Text = "";
            DatorText.Text = "";

            btnDeal.Enabled = true;
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            vann = false;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
