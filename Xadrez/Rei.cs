using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(TabuleiroClass tab, Cor cor) : base(tab, cor)
        {

        }


        public override string ToString()
        {
            return "R";
        }
    }
}
