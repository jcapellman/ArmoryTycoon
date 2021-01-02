using ArmoryTycoon.lib.DAL.Base;
using ArmoryTycoon.lib.DAL.Objects;

using LiteDB;

namespace ArmoryTycoon.lib.DAL
{
    public class LiteDB : BaseDAL
    {
        private const string DB_FILENAME = "game.db";
        
        public override bool SaveNewGame(SaveGame game)
        {
            using var db = new LiteDatabase(DB_FILENAME);

            return db.GetCollection<SaveGame>().Insert(game) > 0;
        }
    }
}