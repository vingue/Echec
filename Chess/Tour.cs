﻿using System;
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
            throw new NotImplementedException();
        }
    }
}