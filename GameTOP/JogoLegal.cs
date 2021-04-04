

using GameTOP.Interface;

namespace GameTOP
{
    public class JogoLegal
    {
        private readonly iJogador _jogador1;

        private readonly iJogador _jogador2;

        private readonly iJogador _jogador3;

        public JogoLegal(iJogador jogador1, iJogador jogador2, iJogador jogador3)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
            _jogador3 = jogador3;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogador1.Corre());
            System.Console.Write(_jogador1.Chuta());
            System.Console.Write(_jogador1.Passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.Write(_jogador2.Corre());
            System.Console.Write(_jogador2.Chuta());
            System.Console.Write(_jogador2.Passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.Write(_jogador3.Corre());
            System.Console.Write(_jogador3.Chuta());
            System.Console.Write(_jogador3.Passe());
        }
    }
}