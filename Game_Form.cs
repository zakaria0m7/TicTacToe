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
using System.IO;


namespace Our_Tic_Tac
{
    
    public partial class Game_Form : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        Form_Select form2 = new Form_Select();
        private NewGrille game;
        private Partie partie;
        bool verrou = true;
        Graphics win;
        bool ok = true;
        int click = 0;
        int p1_choix, p2_choix;
        int compteur_score=0;

        public Game_Form(int nbr_partie,int p1_ch,int p2_ch)
        {
            InitializeComponent();
            player.SoundLocation = "best.wav";
            player1.SoundLocation = "hawaii-five.wav";
            Point p = new Point(50, 50);
            game = new NewGrille(100, p,p1_ch,p2_ch);
            partie = new Partie(nbr_partie);
            //  win = this.CreateGraphics();
            p1_choix = p1_ch;
            p2_choix = p2_ch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();

            string createText = "New Game :" + Environment.NewLine;
            File.WriteAllText(@"C: \Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\var.txt", createText, Encoding.UTF8);

            Affichage_Avatar();
            Affichage_Tour();
            Affichage_label_info();
        }


        public void Affichage_Tour(int x=1)
        {
            
            if (x == 1)
            {
                switch (p1_choix)
                {
                    case 1:
                        {
                            Joueur_Tour.Text = "ALEX";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Orange;
                            label1.Text = "Click Left To Play";
                            label1.ForeColor = System.Drawing.Color.Orange;
                        }

                        break;

                    case 2:
                        {
                            Joueur_Tour.Text = "MARTY";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Orange;
                            label1.Text = "Click Left To Play";
                            label1.ForeColor = System.Drawing.Color.Orange;
                        }

                        break;
                    case 3:
                        {
                            Joueur_Tour.Text = "MELMAN";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Orange;
                            label1.Text = "Click Left To Play";
                            label1.ForeColor = System.Drawing.Color.Orange;
                        }

                        break;

                    case 4:
                        {
                            Joueur_Tour.Text = "MORTY";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Orange;
                            label1.Text = "Click Left To Play";
                            label1.ForeColor = System.Drawing.Color.Orange;
                        }

                        break;
                    case 5:
                        {
                            Joueur_Tour.Text = "GLORIA";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Orange;
                            label1.Text = "Click Left To Play";
                            label1.ForeColor = System.Drawing.Color.Orange;
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (p2_choix)
                {
                    case 1:
                        {
                            Joueur_Tour.Text = "ALEX";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Red;
                            label1.Text = "Click Right To Play";
                            label1.ForeColor = System.Drawing.Color.Red;

                        }

                        break;

                    case 2:
                        {
                            Joueur_Tour.Text = "MARTY";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Red;
                            label1.Text = "Click Right To Play";
                            label1.ForeColor = System.Drawing.Color.Red;
                        }

                        break;
                    case 3:
                        {
                            Joueur_Tour.Text = "MILMAN";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Red;
                            label1.Text = "Click Right To Play";
                            label1.ForeColor = System.Drawing.Color.Red;
                        }

                        break;

                    case 4:
                        {
                            Joueur_Tour.Text = "MORTY";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Red;
                            label1.Text = "Click Right To Play";
                            label1.ForeColor = System.Drawing.Color.Red;
                        }

                        break;
                    case 5:
                        {
                            Joueur_Tour.Text = "GLORIA";
                            Joueur_Tour.ForeColor = System.Drawing.Color.Red;
                            label1.Text = "Click Right To Play";
                            label1.ForeColor = System.Drawing.Color.Red;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public void Affichage_label_info()
        {
            if (partie.NombrePartie() == 3) { label3.Text = "3"; }
            else if (partie.NombrePartie() == 5) { label3.Text = "5"; }
            else { label3.Text = "7"; }

            J1_score.Text = partie.P1Score().ToString();
            J2_score.Text = partie.P2Score().ToString();
            Num_partie.Text = partie.PartieJoue().ToString();

          
           
        }
        public void Affichage_Avatar()
        {
            switch (p1_choix)
            {
                case 1:
                    {
                        pictureBox1.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\maxresdefault (2).png");
                    }

                    break;

                case 2:
                    {
                        pictureBox1.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\images (1).png");
                    }

                    break;
                case 3:
                    {
                        pictureBox1.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\EGijCT1X4AMUNQB.png");
                    }

                    break;

                case 4:
                    {

                        pictureBox1.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\bfe2e4ac3e7b039915d4bee6049b1824 (2).png");
                    }

                    break;
                case 5:
                    {
                        pictureBox1.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\unnamed.png");
                    }
                    break;
                default:
                    break;
            }
        
     
                switch (p2_choix)
                {
                    case 1:
                        {
                            pictureBox2.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\maxresdefault (2).png");
                        }

                        break;

                    case 2:
                        {
                            pictureBox2.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\images (1).png");
                        }

                        break;
                    case 3:
                        {
                            pictureBox2.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\EGijCT1X4AMUNQB.png");
                        }

                        break;

                    case 4:
                        {
                            pictureBox2.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\bfe2e4ac3e7b039915d4bee6049b1824 (2).png");
                        }

                        break;
                    case 5:
                        {
                            pictureBox2.Load(@"C:\Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\Pictures\unnamed.png");
                        }
                        break;
                    default:
                        break;
                }
            }

            
        
            public bool nombre_click() { if (click == 9) return true; return false; }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // if (ok) { win = e.Graphics; ok = false; }


            game.dessiner(ref g);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            string eventString = null;
            int i, j;
            bool test = false;
            Graphics g = this.CreateGraphics();
            Point p = e.Location;
           
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        bool ok = false;
                        eventString = "L";
                        // bool r = game.SeachRect(p, out i, out j);
                        if (verrou)
                        {
                            ok = this.game.PlayerA(ref g, p);

                            if (ok) { verrou = false;click += 1; Affichage_Tour(2); }
                        }
                        if (click >= 5) // Nombre de click Miniman pour un Win
                        {
                             test = game.CheckForGameOver(this,out compteur_score);
                            if (test) {
                                         verrou = true; click =0;
                              
                            }  
                        }
                        if (test) { partie.Score(compteur_score);
                         
                        }       
                             partie.EndGame(this,p1_choix,p2_choix);
                             Affichage_label_info();
                             
                    }

                    break;

                case MouseButtons.Right:
                    {
                        
                        eventString = "R";
                        bool ok = true;
                        eventString = "L";
                        // bool r = game.SeachRect(p, out i, out j);
                        if (!verrou)
                        {
                            ok = this.game.PlayerB(ref g, p);

                            if (ok) { verrou = true; click += 1; Affichage_Tour(); }
                           
                        }
                        if (click >= 5)
                        {
                             test = game.CheckForGameOver(this,out compteur_score);

                            if (test) {
                                         verrou = true; click = 0;
                                
                            }
                        }
                        if (test) { partie.Score(compteur_score);
                        }
                        partie.EndGame(this,p1_choix,p2_choix);
                        Affichage_label_info();
                        
                    }

                    break;
                default:

                    break;
            }
        }


        private void Joueur_Tour_Click(object sender, EventArgs e)
        {
                   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.Play();
            form2.Show();
            Hide();
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            player1.Stop();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.ResetGame(this);
            player.Play();
            // this.Close();
        }

      
    }
}