using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        public static Case[,] plateau = new Case[8, 8];
        static char[] colonne = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        static List<Case> list = null;

        static void Main(string[] args)
        {
            init();
            plateau[2, 2] = new Dame(2, 2, true);
            
            Piece test = (Piece)plateau[2, 2];
            test.atteinte();
            list = test.getList();
            affiche();
        }

        public static void init()
        {
            int j = 0;
            int i = 0;
            for (i = 0; i < 8; i++)
            {
                switch(i)
                {
                    case 0:
                        initPiece(i, true);
                        break;

                    //case 1:
                    //    initPion(i, true);
                    //    break;

                    //case 6:
                    //    initPion(i, false);
                    //    break;

                    //case 7:
                    //    initPiece(i, false);
                    //    break;

                    default:
                        initCaseVide(i);
                        break;
                }
            }
        }

        public static void initCaseVide(int ligne)
        {
            int j = 0;
            for (j = 0; j < 8; j++)
            {
                plateau[ligne, j] = new Case(ligne, j);
            }
        }

        public static void initPion(int ligne, bool color)
        {
            int j = 0;
            for (j = 0; j < 8; j++)
            {
                plateau[ligne, j] = new Pion(ligne, j, color);
            }
        }

        public static void initPiece(int ligne, bool color)
        {
            plateau[ligne, 0] = new Tour(ligne, 0, color);
            plateau[ligne, 1] = new Cavalier(ligne, 1, color);
            plateau[ligne, 2] = new Fou(ligne, 2, color);
            plateau[ligne, 3] = new Dame(ligne, 3, color);
            plateau[ligne, 4] = new Roi(ligne, 4, color);
            plateau[ligne, 5] = new Fou(ligne, 5, color);
            plateau[ligne, 6] = new Cavalier(ligne, 6, color);
            plateau[ligne, 7] = new Tour(ligne, 7, color);
        }

        public static void affiche()
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("  " + colonne[i]);
                        break;

                    case 7:
                        Console.WriteLine(" " + colonne[i]);
                        break;

                    default:
                        Console.Write(" " + colonne[i]);
                        break;
                }
            }
            for (i = 0; i < 8; i++)
            {
                Console.Write((i + 1));
                for (j = 0; j < 8; j++)
                {
                    Console.Write(" ");
                    if (list != null && list.Any(test => test.Equals(plateau[i,j])))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    if (plateau[i,j] is Piece)
                    {
                        affichePiece((Piece)plateau[i, j]);
                    }
                    else
                    {

                        Console.Write(plateau[i, j].display());
                    }
                    Console.BackgroundColor = ConsoleColor.Black;

                    if (j == 7)
                        Console.WriteLine("");
                }
            }
        }

        public static void affichePiece(Piece piece)
        {
            
            if (piece.getColor())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write( plateau[piece.getHorizontal(), piece.getVertical()].display());
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write( plateau[piece.getHorizontal(), piece.getVertical()].display());
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
        }

        public static void interroge()
        {
            Console.Write("Entrer la valeur horizontale: ");
            int horizontal = readHorizon();
            Console.Write("Entrer la valeur verticale: ");
            int vertical = readVertical();
            Console.WriteLine(plateau[horizontal, vertical].ToString());
        }

        public static int readHorizon()
        {
            string value = Console.ReadLine();
            int val = -1;
            if (!int.TryParse(value, out val))
                return 0;
            val--;
            return val;
        }

        public static int readVertical()
        {
            string value = Console.ReadLine();
            char val = 'a';
            int index = 0;
            if (!char.TryParse(value, out val))
                return 0;
            for(index=0; index<8;index++)
            {
                if(val == colonne[index])
                {
                    break;
                }
            }
            return index;
        }
    }
}
