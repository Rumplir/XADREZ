using _XADREZ.tabuleiro;
using _XADREZ.xadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _XADREZ
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas;  i++)
            {
                Console.Write($"{8-i} ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i,j) == null)
                    {
                        Console.Write($"- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write($" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");

        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.White)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
