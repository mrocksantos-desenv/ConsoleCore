using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {

        public readonly string _Nome;
        public Jogador3 (string nome = "ANA CLARA")
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_Nome} está chutando \n";

        }
        //corre
        public string Corre()
        {
            return $"{_Nome} está correndo \n";
        }
        //passe
        public string Passe()
        {
            return $"{_Nome} está passando \n";
        }
    }
}