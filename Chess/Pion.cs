using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pion : Piece
    {
        // constructeur
        public Pion(int horizontal, int vertical, bool white)
            : base(horizontal, vertical, white) {
        }

        public override void mouvement()
        {
            Console.WriteLine("Mouvement de une case vers l'avant (2 si premier tour)");
        }

        public override string display()
        {
            return String.Format("P");
        }

        public override void atteinte()
        {
            int mov;
            if (white)
                mov=1;
            else
                mov=-1;
            Piece blackOrWhite = null;
            if (!(Program.plateau[horizontal + mov, vertical] is Piece))
            {
                listeMouv.Add(Program.plateau[horizontal + mov, vertical]);
            }
            if (Program.plateau[horizontal + mov, vertical+1] is Piece)
            {
                blackOrWhite = (Piece)Program.plateau[horizontal + mov, vertical+1];
                if (blackOrWhite.getColor() != white)
                    listeMouv.Add(Program.plateau[horizontal + mov, vertical+1]);
            }
            if (Program.plateau[horizontal + mov, vertical - 1] is Piece)
            {
                blackOrWhite = (Piece)Program.plateau[horizontal + mov, vertical - 1];
                if (blackOrWhite.getColor() != white)
                    listeMouv.Add(Program.plateau[horizontal + mov, vertical - 1]);
            }
            for (int i =0; i<listeMouv.Count; i++)
            {
                Console.Write(listeMouv[i].ToString()+" ");
            }
            Console.WriteLine("");
        }
    }
}
