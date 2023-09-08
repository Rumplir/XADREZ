using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _XADREZ.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QntMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca( Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            this.tabuleiro = tabuleiro;
            QntMovimentos = 0;
        }
        
        public void incrementarQntMovimentos()
        {
            QntMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
        
    }
}
