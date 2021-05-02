using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_Tic_Tac
{
    class Partie
    {
        int p1_score, p2_score, partie_joue, nombre_partie;
        int p1_Fscore, p2_Fscore;

        public Partie(int nb_partie)
        {
            p1_score = 0;
            p2_score = 0;
            nombre_partie = nb_partie;
            partie_joue = 1;
        }

        public void Score(int compteur_score)
        {
            if (compteur_score == 1)
            {
                p1_score++;
             
            }
            if (compteur_score == -1)
            {
                p2_score++;
                
            }
                partie_joue++;

            if(partie_joue==nombre_partie+1)
            {
                p1_Fscore = p1_score;
                p2_Fscore = p2_score;
            }
        }
       

        public void EndGame(Game_Form f,int p1,int p2)
        {
            if (partie_joue == nombre_partie+1)
            {
                if(p1_Fscore>p2_Fscore)
                {
                    Winner w = new Winner(f,p1);
                    w.Show();
                }
                else if (p1_Fscore < p2_Fscore)
                {
                    Winner w = new Winner(f,p2);
                    w.Show();
                }
                else
                {
                    Winner w = new Winner(f,0);
                    w.Show();
                }
                
                p1_score = 0; p2_score = 0; partie_joue = 1;
            }
        }

        public int NombrePartie()
        {
            if (nombre_partie == 3)
                return 3;
            else if (nombre_partie == 5)
                return 5;
            else
                return 7;
        }

        public int P1Score()
        {
            switch (p1_score)
            {
                case 0:
                    {
                        return 0;
                    }
                case 1:
                    {
                        return 1;
                    }
                case 2:
                    {
                        return 2;
                    }
                case 3:
                    {
                        return 3;
                    }
                case 4:
                    {
                        return 4;
                    }
                case 5:
                    {
                        return 5;
                    }
                case 6:
                    {
                        return 6;
                    }
                default:
                    return 7;
            }
        }

        public int P2Score()
        {
            switch (p2_score)
            {
                case 0:
                    {
                        return 0;
                    }
                case 1:
                    {
                        return 1;
                    }
                case 2:
                    {
                        return 2;
                    }
                case 3:
                    {
                        return 3;
                    }
                case 4:
                    {
                        return 4;
                    }
                case 5:
                    {
                        return 5;
                    }
                case 6:
                    {
                        return 6;
                    }
                default:
                    { return 7; }
            }
        }

        public int PartieJoue()
        {
            switch (partie_joue)
            {
                case 1:
                    {
                        return 1;
                    }
                case 2:
                    {
                        return 2;
                    }
                case 3:
                    {
                        return 3;
                    }
                case 4:
                    {
                        return 4;
                    }
                case 5:
                    {
                        return 5;
                    }
                case 6:
                    {
                        return 6;
                    }
                case 7:
                    {
                        return 7;
                    }
                default:
                    return 1;
            }
        }

        public int P1_F_Score()
        {
            switch (p1_Fscore)
            {
                case 0:
                    {
                        return 0;
                    }
                case 1:
                    {
                        return 1;
                    }
                case 2:
                    {
                        return 2;
                    }
                case 3:
                    {
                        return 3;
                    }
                case 4:
                    {
                        return 4;
                    }
                case 5:
                    {
                        return 5;
                    }
                case 6:
                    {
                        return 6;
                    }
                default:
                    { return 7; }
            }
        }

        public int P2_F_Score()
        {
            switch (p2_Fscore)
            {
                case 0:
                    {
                        return 0;
                    }
                case 1:
                    {
                        return 1;
                    }
                case 2:
                    {
                        return 2;
                    }
                case 3:
                    {
                        return 3;
                    }
                case 4:
                    {
                        return 4;
                    }
                case 5:
                    {
                        return 5;
                    }
                case 6:
                    {
                        return 6;
                    }
                default:
                    { return 7; }
            }
        }

    }
}
