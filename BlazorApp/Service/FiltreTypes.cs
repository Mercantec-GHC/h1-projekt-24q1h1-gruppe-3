using DomainModels;

namespace Service
{
    public class FiltreTypes
    {

        public List<PC_Game> FiltreToPC_Games(List<Item> games)
        {
            List<PC_Game> Games = new List<PC_Game>();

            foreach (var game in games)
            {
                if (game is PC_Game pcGame)
                {
                    Games.Add(pcGame);
                }
            }
            return Games;
        }

        public List<PS_Game> FiltreToPS_Games(List<Item> games)
        {
            List<PS_Game> Games = new List<PS_Game>();

            foreach (var game in games)
            {
                if (game is PS_Game psGame)
                {
                    Games.Add(psGame);
                }
            }
            return Games;
        }

        public List<XBOX_Game> FiltreToXBOX_Games(List<Item> games)
        {
            List<XBOX_Game> Games = new List<XBOX_Game>();

            foreach (var game in games)
            {
                if (game is XBOX_Game xboxGame)
                {
                    Games.Add(xboxGame);
                }
            }
            return Games;
        }
    }
}
