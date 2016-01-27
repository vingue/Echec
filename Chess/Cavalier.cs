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
            throw new NotImplementedException();
        }
    }
}
