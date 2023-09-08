using _XADREZ.tabuleiro;

namespace _XADREZ.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) 
            : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.Cor != this.Cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.Colunas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0,0);

            // N
            Posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (tabuleiro.verificarPosicao(pos) && podeMover(pos) )
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // NE
            Posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // E
            Posicao.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // SE
            Posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // S
            Posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // SW
            Posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // W
            Posicao.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // NW
            Posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }
    }
}
