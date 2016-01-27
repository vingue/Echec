using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Piece : Case
    {

        private bool white;
        protected List<Case> listeMouv;

        public Piece(int horizontal, int vertical, bool white) : base(horizontal, vertical)
        {
            this.white = white;
            listeMouv = new List<Case>();
        }

        // toString
        public override string ToString()
        {
            string color = "";
            if (white)
                color = "blanc";
            else
                color = "noir";
            return String.Format("{3} position: {0},{1} couleur: {2}", horizontal+1, vertical+1, color, this.GetType().Name);
        }

        // mouvement
        abstract public void mouvement();

        abstract public void atteinte();

        public bool getColor()
        {
            return this.white;
        }

        public int getHorizontal()
        {
            return this.horizontal;
        }

        public int getVertical()
        {
            return this.vertical;
        }

        public List<Case> getList()
        {
            return this.listeMouv;
        }
    }
}
