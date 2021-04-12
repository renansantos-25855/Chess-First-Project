﻿using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(TabuleiroClass tab, Cor cor) : base(tab, cor)
        {

        }


        public override string ToString()
        {
            return "T";
        }
    }
}
