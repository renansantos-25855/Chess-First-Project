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
            try
            {
                TabuleiroClass tab = new TabuleiroClass(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 10));
                Tela.imprimirTabuleiro(tab);

                Console.WriteLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
