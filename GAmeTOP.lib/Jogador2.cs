using GameTOP.Interface;

namespace GAmeTOP.lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando";
        }

        public string Corre()
        {
            return "Maradona estas corriendo";
        }

        public string Passe()
        {
            return "Maradona estas passando";
        }
    }
}