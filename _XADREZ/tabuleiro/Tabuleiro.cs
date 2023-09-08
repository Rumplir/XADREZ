using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _XADREZ.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }
        public Peca peca(int l, int c)
        {
            return pecas[l, c];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peça nessa posição!");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
        public Peca retirarPeca( Posicao pos )
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.Posicao = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        public bool verificarPosicao(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(Posicao pos)
        {
            if (!verificarPosicao(pos))
            {
                throw new TabuleiroException("Posição Invalida!");
            }
        }
    }
}
