using DomainModels;

namespace Service
{
    public class FiltreTypes
    {
        public List<Item> FiltreToPC_Games(List<Item> games)
        {
            List<Item> Games = new List<Item>();

            foreach (var game in games)
            {
                if (game is PC_Game pcGame)
                {
                    Games.Add(pcGame);
                }
            }
            return Games;
        }
        public List<Item> FiltreToPS_Games(List<Item> games)
        {
            List<Item> Games = new List<Item>();

            foreach (var game in games)
            {
                if (game is PS_Game psGame)
                {
                    Games.Add(psGame);
                }
            }
            return Games;
        }
        public List<Item> FiltreToXBOX_Games(List<Item> games)
        {
            List<Item> Games = new List<Item>();

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
