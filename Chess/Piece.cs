using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Piece : Case
    {

        protected bool white;
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

        public void setColor(bool color)
        {
            this.white = color;
        }

        public List<Case> getList()
        {
            return this.listeMouv;
        }

        public static Piece construct(string nom, int horizontal, int vertical, bool color)
        {
            Piece obj;
            switch (nom)
            {
                case "Pion":
                    obj = new Pion(horizontal, vertical, color);
                    break;
                case "Tour":
                    obj = new Tour(horizontal, vertical, color);
                    break;
                case "Fou":
                    obj = new Fou(horizontal, vertical, color);
                    break;
                case "Cavalier":
                    obj = new Cavalier(horizontal, vertical, color);
                    break;
                case "Roi":
                    obj = new Roi(horizontal, vertical, color);
                    break;
                case "Dame":
                    obj = new Dame(horizontal, vertical, color);
                    break;
                default:
                    obj = null;
                    break;
            }
            return obj;
        }
    }
}
