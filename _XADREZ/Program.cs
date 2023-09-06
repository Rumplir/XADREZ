﻿using _XADREZ.tabuleiro;
using _XADREZ.xadrez;

namespace _XADREZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Rei(Cor.Black, tab), new Posicao(0, 0));
                tab.colocarPeca(new Rei(Cor.Black, tab), new Posicao(5, 4));
                tab.colocarPeca(new Rei(Cor.Black, tab), new Posicao(7, 4));
                Tela.ImprimirTabuleiro(tab);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}