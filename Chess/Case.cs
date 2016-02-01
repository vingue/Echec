using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Case
    {
        protected int horizontal;
        protected int vertical;

        public Case(int horizontal, int vertical)
        {
            this.horizontal = horizontal;
            this.vertical = vertical;
        }

        // toString
        public override string ToString()
        {
            return String.Format("Piece[{0},{1}]", horizontal, vertical);
        }

        public virtual string display()
        {
            return String.Format("0");
        }

        public int getHorizontal()
        {
            return this.horizontal;
        }

        public int getVertical()
        {
            return this.vertical;
        }

        public void setHorizontal(int val)
        {
            this.horizontal = val;
        }

        public void setVertical(int val)
        {
            this.vertical = val;
        }
    }
}
