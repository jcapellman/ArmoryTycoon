using System.Collections.Generic;

using ArmoryTycoon.lib.DAL.Objects;

namespace ArmoryTycoon.lib.DAL.Base
{
    public abstract class BaseDAL
    {
        public abstract bool SaveNewGame(Game game);

        public abstract Dictionary<int, string> GetSaveGameList();

        public abstract bool DeleteSaveGame(int gameId);

        public abstract Game LoadSaveGame(int gameId);
    }
}