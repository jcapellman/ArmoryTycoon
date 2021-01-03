using System.Collections.Generic;

using ArmoryTycoon.lib.DAL.Base;
using ArmoryTycoon.lib.DAL.Objects;

namespace ArmoryTycoon.lib.Managers
{
    public class GameManager
    {
        private readonly BaseDAL _dal;

        public GameManager(BaseDAL dal)
        {
            _dal = dal;
        }
        
        public Game LoadGame(int gameId) => _dal.LoadSaveGame(gameId);

        public bool DeleteGame(int gameId) => _dal.DeleteSaveGame(gameId);

        public bool SaveNewGame(Game game) => _dal.SaveNewGame(game);

        public Dictionary<int, string> GetSaveGameList() => _dal.GetSaveGameList();
    }
}