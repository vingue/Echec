using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Dame : Piece
    {
        // constructeur
        public Dame(int horizontal, int vertical, bool white)
            : base(horizontal, vertical, white)
        {
        }

        public override void mouvement()
        {
            Console.WriteLine("Mouvement en diagonales et droits");
        }

        public override string display()
        {
            return String.Format("D");
        }

        public override void atteinte()
        {
            Piece blackOrWhite = null;
            int diffHori = 1;
            int diffVerti = 1;
            while ((horizontal + diffHori) < 8 && (vertical + diffVerti) < 8)
            {
                if ((!(Program.plateau[horizontal + diffHori, vertical + diffVerti] is Piece)))
                    listeMouv.Add(Program.plateau[horizontal + diffHori, vertical + diffVerti]);
                else if (Program.plateau[horizontal + diffHori, vertical + diffVerti] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[horizontal + diffHori, vertical + diffVerti];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[horizontal + diffHori, vertical + diffVerti]);
                    break;
                }
                else
                    break;
                diffHori++;
                diffVerti++;
            }

            diffHori = -1;
            diffVerti = 1;
            while ((horizontal + diffHori) >= 0 && (vertical + diffVerti) < 8)
            {
                if (!(Program.plateau[horizontal + diffHori, vertical + diffVerti] is Piece))
                    listeMouv.Add(Program.plateau[horizontal + diffHori, vertical + diffVerti]);
                else if (Program.plateau[horizontal + diffHori, vertical + diffVerti] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[horizontal + diffHori, vertical + diffVerti];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[horizontal + diffHori, vertical + diffVerti]);
                    break;
                }
                else
                    break;
                diffHori--;
                diffVerti++;
            }

            diffHori = -1;
            diffVerti = -1;
            while ((horizontal + diffHori) >= 0 && (vertical + diffVerti) >= 0)
            {
                if (!(Program.plateau[horizontal + diffHori, vertical + diffVerti] is Piece))
                    listeMouv.Add(Program.plateau[horizontal + diffHori, vertical + diffVerti]);
                else if (Program.plateau[horizontal + diffHori, vertical + diffVerti] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[horizontal + diffHori, vertical + diffVerti];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[horizontal + diffHori, vertical + diffVerti]);
                    break;
                }
                else
                    break;
                diffHori--;
                diffVerti--;
            }

            diffHori = 1;
            diffVerti = -1;
            while ((horizontal + diffHori) < 8 && (vertical + diffVerti) >= 0)
            {
                if (!(Program.plateau[horizontal + diffHori, vertical + diffVerti] is Piece))
                    listeMouv.Add(Program.plateau[horizontal + diffHori, vertical + diffVerti]);
                else if (Program.plateau[horizontal + diffHori, vertical + diffVerti] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[horizontal + diffHori, vertical + diffVerti];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[horizontal + diffHori, vertical + diffVerti]);
                    break;
                }
                else
                    break;
                diffHori++;
                diffVerti--;
            }

            for (int var = horizontal - 1; var >= 0; var--)
            {
                if (!(Program.plateau[var, vertical] is Piece))
                    listeMouv.Add(Program.plateau[var, vertical]);
                else if (Program.plateau[var, vertical] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[var, vertical];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[var, vertical]);
                    break;
                }
                else
                    break;
            }

            for (int var = horizontal + 1; var < 8; var++)
            {
                if (!(Program.plateau[var, vertical] is Piece))
                    listeMouv.Add(Program.plateau[var, vertical]);
                else if (Program.plateau[var, vertical] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[var, vertical];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[var, vertical]);
                    break;
                }
                else
                    break;
            }

            for (int var = vertical - 1; var >= 0; var--)
            {
                if (!(Program.plateau[horizontal, var] is Piece))
                    listeMouv.Add(Program.plateau[horizontal, var]);
                else if (Program.plateau[horizontal, var] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[horizontal, var];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[horizontal, var]);
                    break;
                }
                else
                    break;
            }

            for (int var = vertical + 1; var < 8; var++)
            {
                if (!(Program.plateau[horizontal, var] is Piece))
                    listeMouv.Add(Program.plateau[horizontal, var]);
                else if (Program.plateau[horizontal, var] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[horizontal, var];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[horizontal, var]);
                    break;
                }
                else
                    break;
            }

            for (int i = 0; i < listeMouv.Count; i++)
            {
                Console.Write(listeMouv[i].ToString() + " ");
            }
            Console.WriteLine("");
        }
    }
}
