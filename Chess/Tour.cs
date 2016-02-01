using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Tour : Piece
    {
        // constructeur
        public Tour(int horizontal, int vertical, bool white)
            : base(horizontal, vertical, white)
        {
        }

        public override void mouvement()
        {
            Console.WriteLine("Mouvement droits");
        }

        public override string display()
        {
            return String.Format("T");
        }

        public override void atteinte()
        {
            Piece blackOrWhite = null;
            for(int var = horizontal-1; var>=0;var--)
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

            for (int var = horizontal+1; var < 8; var++)
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
