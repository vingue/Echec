using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Reine : Piece
    {
        // constructeur
        public Reine(int horizontal, int vertical, bool white)
            : base(horizontal, vertical, white)
        {
        }

        public override void mouvement()
        {
            Console.WriteLine("Mouvement en diagonales et droits");
        }

        public override string display()
        {
            return String.Format("Q");
        }

        public override void atteinte()
        {
            throw new NotImplementedException();
        }
    }
}
