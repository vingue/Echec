using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Roi : Piece
    {
        // constructeur
        public Roi(int horizontal, int vertical, bool white)
            : base(horizontal, vertical, white)
        {
        }

        public override void mouvement()
        {
            Console.WriteLine("Mouvement de une case dans toute les directions");
        }

        public override string display()
        {
            return String.Format("K");
        }

        public override void atteinte()
        {
            throw new NotImplementedException();
        }
    }
}
