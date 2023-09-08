using _XADREZ.tabuleiro;
using _XADREZ.xadrez;

namespace _XADREZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez a = new PosicaoXadrez('c', 7);

            Console.WriteLine(a);
            Console.WriteLine(a.toPosicao());
            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);
                    Console.WriteLine();
                    Console.Write("Digite a Posição Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Digite a Posição Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}