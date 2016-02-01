using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Cavalier : Piece
    {
        // constructeur
        public Cavalier(int horizontal, int vertical, bool white)
            : base(horizontal, vertical, white)
        {
        }

        public override void mouvement()
        {
            Console.WriteLine("Mouvement en L");
        }

        public override string display()
        {
            return String.Format("C");
        }

        public override void atteinte()
        {
            Piece blackOrWhite = null;
            int[,] combinaison = new int[8, 2] { 
                { horizontal + 1, vertical + 2 },{ horizontal + 2, vertical + 1 },
                { horizontal + 1, vertical - 2 },{ horizontal + 2, vertical - 1 },
                {horizontal-1,vertical+2 }, {horizontal-2, vertical+1 },
                {horizontal-1,vertical-2 }, {horizontal-2, vertical-1 } };

            for(int i=0;i<8;i++)
            {
                if (combinaison[i, 0] < 0 || combinaison[i, 0] > 7 || combinaison[i, 1] < 0 || combinaison[i, 1] > 7)
                    continue;
                if (!(Program.plateau[combinaison[i,0], combinaison[i,1]] is Piece))
                {
                    listeMouv.Add(Program.plateau[combinaison[i, 0], combinaison[i, 1]]);
                }
                if (Program.plateau[combinaison[i, 0], combinaison[i, 1]] is Piece)
                {
                    blackOrWhite = (Piece)Program.plateau[combinaison[i, 0], combinaison[i, 1]];
                    if (blackOrWhite.getColor() != white)
                        listeMouv.Add(Program.plateau[combinaison[i, 0], combinaison[i, 1]]);
                }
            }

            for (int i = 0; i < listeMouv.Count; i++)
            {
                Console.Write(listeMouv[i].ToString() + " ");
            }
            Console.WriteLine("");
        }
    }
}
