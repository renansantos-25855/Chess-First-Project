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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);                            
                        Console.WriteLine("\n\nPressione ENTER para continuar...");

                        do
                        {
                        } while (Console.ReadKey().Key != ConsoleKey.Enter);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("\nValor de origem fora do padrão! Tente novamente");                            
                        Console.WriteLine("\n\nPressione ENTER para continuar...");

                        do
                        {   
                        } while (Console.ReadKey().Key != ConsoleKey.Enter);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("\nValor de origem fora do padrão! Tente novamente");
                        Console.WriteLine("\n\nPressione ENTER para continuar...");

                        do
                        {
                        } while (Console.ReadKey().Key != ConsoleKey.Enter);
                    }
                }
                Console.WriteLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
