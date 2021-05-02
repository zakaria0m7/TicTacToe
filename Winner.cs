using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;  

namespace Our_Tic_Tac
{
    public partial class Winner : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();

        int winner;
        Game_Form forme;
        public Winner(Game_Form f,int win)
        {
            InitializeComponent();
            player.SoundLocation = "i_like.wav";
            player1.SoundLocation= "best.wav";
            player2.SoundLocation = "hawaii-five.wav";
            winner = win;
            forme = f;
        }

        private void Winner_Load(object sender, EventArgs e)
        {

            player.Play();

            switch (winner)
            {
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile("C:/Users/VEGA/Downloads/alex (1).gif");
                        label1.Text = "ALEX is The Winner";
                        label1.ForeColor = System.Drawing.Color.OrangeRed;
                    }

                    break;

                case 2:
                    {
                        pictureBox1.Image = Image.FromFile("C:/Users/VEGA/Downloads/marty222 (1).gif");
                        label1.Text = "MARTY is The Winner";
                        label1.ForeColor = System.Drawing.Color.OrangeRed;
                    }

                    break;
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile("C:/Users/VEGA/Downloads/MilIman (1).gif");
                        label1.Text = "MELMAN is The Winner";
                        label1.ForeColor = System.Drawing.Color.OrangeRed;
                    }

                    break;

                case 4:
                    {
                        pictureBox1.Image = Image.FromFile("C:/Users/VEGA/Downloads/Morty (1).gif");
                        label1.Text = "MORTY is The Winner";
                        label1.ForeColor = System.Drawing.Color.OrangeRed;
                    }

                    break;
                case 5:
                    {
                        pictureBox1.Image = Image.FromFile("C:/Users/VEGA/Downloads/Gloria (1).gif");
                        label1.Text = "GLORIA is The Winner";
                        label1.ForeColor = System.Drawing.Color.OrangeRed;
                    }
                    break;
                default:
                    break;
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Hide();
            player1.Play();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            Form_Select game = new Form_Select();
            game.Show();
            Hide();
            forme.Hide();
            player2.Play();
        }
    }
}
