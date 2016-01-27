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
            
            if (!(Program.plateau[horizontal + 1, vertical] is Piece))
            {
                listeMouv.Add(Program.plateau[horizontal + 1, vertical]);
            }
            for (int i =0; i<listeMouv.Count; i++)
            {
                Console.Write(listeMouv[i].ToString()+" ");
            }
            Console.WriteLine("");
        }
    }
}
