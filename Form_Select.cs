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
    

    public partial class Form_Select : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private Cellule cadre1,cadre2,cadre3,cadre4,cadre5,cadre6,cadre7;
        private int p1choix = 0, p2choix = 0;
        private bool change =true;
        private int radioValue = 3;
        private bool valide = false;
        private bool check = false;
        
        
       
        

        public Form_Select()
        {
            InitializeComponent();
            player.SoundLocation = "hawaii-five.wav";

            Point p = new Point(100, 100);
            cadre1 = new Cellule(121,237,106,90);
            cadre2 = new Cellule(232, 237, 106, 90);
            cadre3 = new Cellule(343, 237, 106, 90);
            cadre4 = new Cellule(454, 237, 106, 90);
            cadre5 = new Cellule(565, 237, 106, 90);
            cadre6 = new Cellule(208, 430, 106, 90);
            cadre7 = new Cellule(485, 430, 106, 90);
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            //player.Play();
        }

        

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioValue = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioValue = 5;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioValue = 7;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (change)
            {
                p1choix = 1;
                Refresh();
                Graphics g = CreateGraphics();

                cadre1.desiner(ref g, Color.Red, 3);
                pictureBox6.BackgroundImage = pictureBox1.BackgroundImage;
                cadre6.desiner(ref g, Color.Red, 3);
                check = true;
            }
            else
            {
                p2choix = 1;
                Refresh();
                Graphics g = CreateGraphics();

                cadre1.desiner(ref g, Color.Yellow, 3);
                pictureBox7.BackgroundImage = pictureBox1.BackgroundImage;
                cadre7.desiner(ref g, Color.Yellow, 3);
                valide = true;
                check = false;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (change)
            {
                p1choix = 2;
                Refresh();
                Graphics g = CreateGraphics();

                cadre2.desiner(ref g, Color.Red, 3);
                pictureBox6.BackgroundImage = pictureBox2.BackgroundImage;
                cadre6.desiner(ref g, Color.Red, 3);
                check = true;
            }
            else
            {
                p2choix = 2;
                Refresh();
                Graphics g = CreateGraphics();

                cadre2.desiner(ref g, Color.Yellow, 3);
                pictureBox7.BackgroundImage = pictureBox2.BackgroundImage;
                cadre7.desiner(ref g, Color.Yellow, 3);
                valide = true;
                check = false;
            }
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (change)
            {
                p1choix = 3;
                Refresh();
                Graphics g = CreateGraphics();

                cadre3.desiner(ref g, Color.Red, 3);
                pictureBox6.BackgroundImage = pictureBox3.BackgroundImage;
                cadre6.desiner(ref g, Color.Red, 3);
                check = true;
            }
            else
            {
                p2choix = 3;
                Refresh();
                Graphics g = CreateGraphics();

                cadre3.desiner(ref g, Color.Yellow, 3);
                pictureBox7.BackgroundImage = pictureBox3.BackgroundImage;
                cadre7.desiner(ref g, Color.Yellow, 3);
                valide = true;
                check = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (change)
            {
                p1choix = 4;
                Refresh();
                Graphics g = CreateGraphics();

                cadre4.desiner(ref g, Color.Red, 3);
                pictureBox6.BackgroundImage = pictureBox4.BackgroundImage;
                cadre6.desiner(ref g, Color.Red, 3);
                check = true;
            }
            else
            {
                p2choix = 4;
                Refresh();
                Graphics g = CreateGraphics();

                cadre4.desiner(ref g, Color.Yellow, 3);
                pictureBox7.BackgroundImage = pictureBox4.BackgroundImage;
                cadre7.desiner(ref g, Color.Yellow, 3);
                valide = true;
                check = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (change)
            {
                p1choix = 5;
                Refresh();
                Graphics g = CreateGraphics();
                cadre5.desiner(ref g, Color.Red, 3);
                pictureBox6.BackgroundImage = pictureBox5.BackgroundImage;
                cadre6.desiner(ref g, Color.Red, 3);
                check = true;
            }
            else
            {
                p2choix = 5;
                Refresh();
                Graphics g = CreateGraphics();

                cadre5.desiner(ref g, Color.Yellow, 3);
                pictureBox7.BackgroundImage = pictureBox5.BackgroundImage;
                cadre7.desiner(ref g, Color.Yellow, 3);
                valide = true;
                check = false;
            }
        }


        
        private void button_WOC1_Click(object sender, EventArgs e)
        {

            if(!check)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string messageA = "Player 1 Must Pick His Avatar !!";
                MessageBox.Show(messageA,"Pick Erreur", buttons);
            }
            else { 

                label1.Text="Player 2 Pick Turn";
                switch (p1choix)
                {
                    case 1:
                        {
                            pictureBox6.BackgroundImage = pictureBox1.BackgroundImage;
                            pictureBox1.Enabled = false;
                        }

                        break;

                    case 2:
                        {
                            pictureBox6.BackgroundImage = pictureBox2.BackgroundImage;
                            pictureBox2.Enabled = false;
                        }

                        break;
                    case 3:
                        {
                            pictureBox6.BackgroundImage = pictureBox3.BackgroundImage;
                            pictureBox3.Enabled = false;
                        }

                        break;

                    case 4:
                        {
                            pictureBox6.BackgroundImage = pictureBox4.BackgroundImage;
                            pictureBox4.Enabled = false;
                        }

                        break;
                    case 5:
                        {
                            pictureBox6.BackgroundImage = pictureBox5.BackgroundImage;
                            pictureBox5.Enabled = false;
                        }
                        break;
                    default:
                        break;
                               
            }
            change = false;
            button_WOC1.Hide();
            button_WOC2.Show();
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if (check)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string messageA = "Player 2 Must Pick His Avatar !!";
                MessageBox.Show(messageA, "Pick Erreur", buttons);
            }
            else
                if (valide)
            {
                Game_Form f2 = new Game_Form(radioValue,p1choix,p2choix);

                f2.Show();
                Hide();
            }

        }


        private void Form2_Paint(object sender, PaintEventArgs e)
        {
           /*
                Graphics g = e.Graphics;
             
                cadre.desiner(ref g, Color.Green, 2);
           */
        }



        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }
       
    
    }
}
