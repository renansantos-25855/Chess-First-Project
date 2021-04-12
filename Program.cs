using System;
using Tabuleiro;
using Xadrez;
using Tabuleiro.Exceptions;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadez pos = new PosicaoXadez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

        }

    }
}
