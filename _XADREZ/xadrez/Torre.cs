using _XADREZ.tabuleiro;

namespace _XADREZ.xadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro)
            : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.Cor != this.Cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.Colunas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            // ACIMA
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            // ABAIXO
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }
            // DIREITA
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }
            // ESQUERDA
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (tabuleiro.verificarPosicao(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            return mat;

        }
    }
}
