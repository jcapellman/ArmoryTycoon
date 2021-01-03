using ArmoryTycoon.lib.DAL.Base;
using ArmoryTycoon.lib.DAL.Objects;

using LiteDB;

namespace ArmoryTycoon.lib.DAL
{
    public class LiteDB : BaseDAL
    {
        private const string DB_FILENAME = "game.db";
        
        public override bool SaveNewGame(Game game)
        {
            using var db = new LiteDatabase(DB_FILENAME);

            return db.GetCollection<Game>().Insert(game) > 0;
        }
    }
}