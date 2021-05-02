using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Our_Tic_Tac
{
    class NewGrille
    {
        int p1_choi, p2_choi,c=0;
        
        

        public NewGrille(int L, Point start,int p1_ch,int p2_ch)
        {
            p1_choi = p1_ch;
            p2_choi = p2_ch;
            grid = new Cellule[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j] = new Cellule(91 + j * L, 91 + i * L, 90);
        }
        

        public bool SeachRect(Point p, out int ix, out int jy)
        {
            ix = -1;
            jy = -1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (grid[i, j].PointInRect(p)) { ix = i; jy = j; return true; };

            return false;
        }

        public bool PlayerB(ref Graphics g, Point p)
        {
            int i = -1, j = -1;
            bool r = SeachRect(p, out i, out j);
            if (!r) { validatePlayerEntry(); return false; }
            if (r)
            {
                string appendText = "Player 2 :" + " : [" + i + "," + j + "]" + Environment.NewLine;
                File.AppendAllText(@"C: \Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\var.txt", appendText);

                grid[i, j].rond(ref g, p2_choi); return true;
            }
            return true;
        }

        public bool PlayerA(ref Graphics g, Point p)
        {
            int i = -1, j = -1;
            bool r = SeachRect(p, out i, out j);
            if (!r) { validatePlayerEntry(); return false; }
            if (r) {
                string appendText = "Player 1 :" + " : [" + i + "," + j + "]" + Environment.NewLine;
                File.AppendAllText(@"C: \Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\var.txt", appendText);


                grid[i, j].Croix(ref g,p1_choi); return true;
            }
            return true;
        }
        public void dessiner(ref Graphics g)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j].desiner(ref g,Color.DeepSkyBlue,5);

        }

 


        public void ResetGame(Game_Form f)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)               
                    grid[i, j].reset();

            string appendText = "*************************************************" + 
                Environment.NewLine +"New Game : " + Environment.NewLine;
            File.AppendAllText(@"C: \Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\var.txt", appendText);

            f.Refresh(); // redessiner
        }




        // is winner
        public int IsWinner()
        {
            
            // player A
            if (
                ((grid[0, 0].Player()==1) &&
                 (grid[1, 0].Player()==1) &&
                 (grid[2, 0].Player()==1)) 
                || 
                ((grid[0, 1].Player()==1) &&
                 (grid[1, 1].Player()==1) &&
                 (grid[2, 1].Player()==1))
                ||
                ((grid[0, 2].Player()==1) &&
                 (grid[1, 2].Player()==1) &&
                 (grid[2, 2].Player()==1))
                ||
                ((grid[0, 0].Player()==1) &&
                 (grid[0, 1].Player()==1) &&
                 (grid[0, 2].Player()==1))
                ||
                ((grid[1, 0].Player()==1) &&
                 (grid[1, 1].Player()==1) &&
                 (grid[1, 2].Player()==1))
                ||
                ((grid[2, 0].Player()==1) &&
                 (grid[2, 1].Player()==1) &&
                 (grid[2, 2].Player()==1))
                ||
                ((grid[0, 0].Player()==1) &&      //Diagonale
                 (grid[1, 1].Player()==1) &&
                 (grid[2, 2].Player()==1))
                ||
                ((grid[0, 2].Player()==1) &&        //DiagonaleInverse
                 (grid[1, 1].Player()==1) &&
                 (grid[2, 0].Player()==1))
                )
                return 1;

            // player B

           else if (
                ((grid[0, 0].Player() == -1) &&
                 (grid[1, 0].Player() == -1) &&
                 (grid[2, 0].Player() == -1))
                ||
                ((grid[0, 1].Player() == -1) &&
                 (grid[1, 1].Player() == -1) &&
                 (grid[2, 1].Player() == -1))
                ||
                ((grid[0, 2].Player() == -1) &&
                 (grid[1, 2].Player() == -1) &&
                 (grid[2, 2].Player() == -1))
                ||
                ((grid[0, 0].Player() == -1) &&
                 (grid[0, 1].Player() == -1) &&
                 (grid[0, 2].Player() == -1))
                ||
                ((grid[1, 0].Player() == -1) &&
                 (grid[1, 1].Player() == -1) &&
                 (grid[1, 2].Player() == -1))
                ||
                ((grid[2, 0].Player() == -1) &&
                 (grid[2, 1].Player() == -1) &&
                 (grid[2, 2].Player() == -1))
                 ||
                ((grid[0, 0].Player() == -1) &&      //Diagonale
                 (grid[1, 1].Player() == -1) &&
                 (grid[2, 2].Player() == -1))
                ||
                ((grid[0, 2].Player() == -1) &&        //DiagonaleInverse
                 (grid[1, 1].Player() == -1) &&
                 (grid[2, 0].Player() == -1))
                )
                return -1;

           else return 0;
        }


        private void validatePlayerEntry()
        {


            string message = "You did not click on the grid. Cancel this operation?";
            string caption = "Error Detected in Input given by " + "Player"  ;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);


        }

        //

        public bool CheckForGameOver(Game_Form f,out int compteur_score)
        {
            string messageA = "Player 1 Wins !";
            string messageB = "Player 2 Wins !";
            string messageC = "              Draw";
            string caption = "Ending Game bye !";
            MessageBoxButtons buttons = MessageBoxButtons.OK;           
            compteur_score = 0;

            int nWin = this.IsWinner();
            if (nWin == 1)
            {
                File.AppendAllText(@"C: \Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\var.txt", "GameOver" + Environment.NewLine);
                MessageBox.Show(messageA, caption, buttons);
                this.ResetGame(f);
                compteur_score = 1;
                return true;
            }
            else
                if (nWin == -1) {
                File.AppendAllText(@"C: \Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\var.txt", "GameOver" + Environment.NewLine);
                MessageBox.Show(messageB, caption, buttons); this.ResetGame(f);compteur_score = -1; return true; }
            // en cas d'égalité à ajouter :)
            else if ((nWin == 0)&&(f.nombre_click())) {
                File.AppendAllText(@"C: \Users\VEGA\Desktop\s2\poo\Our_Tic_Tac\var.txt", "GameOver"+ Environment.NewLine);
                MessageBox.Show(messageC, caption, buttons); this.ResetGame(f);compteur_score = 0; return true; }
            
            return false;
                 
        }


        private Cellule[,] grid;
        
       


    }


}