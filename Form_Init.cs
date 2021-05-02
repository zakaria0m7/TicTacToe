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
    public partial class Form_Init : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form_Init()
        {
            InitializeComponent();
            player.SoundLocation = "hawaii-five.wav";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_Select f2 = new Form_Select();
             f2.Show();
             Hide();
        }

        private void Form0_Load(object sender, EventArgs e)
        { 
            player.Play();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
