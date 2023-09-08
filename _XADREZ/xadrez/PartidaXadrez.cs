using _XADREZ.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _XADREZ.xadrez
{
    internal class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.White;
            Terminada = false;
            colocarPecas();
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQntMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);

            Tab.colocarPeca(p, destino);
        }
        public void colocarPecas()
        {

            Tab.colocarPeca(new Rei(Cor.White, Tab), new PosicaoXadrez('c', 1).toPosicao());
            Tab.colocarPeca(new Rei(Cor.Black, Tab), new PosicaoXadrez('c', 8).toPosicao());
            Tab.colocarPeca(new Torre(Cor.White, Tab), new PosicaoXadrez('d', 1).toPosicao());
            
        }
    }
}
