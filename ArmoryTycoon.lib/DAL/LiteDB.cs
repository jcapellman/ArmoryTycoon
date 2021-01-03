﻿using System.Collections.Generic;
using System.Linq;

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

        public override Dictionary<int, string> GetSaveGameList()
        {
            using var db = new LiteDatabase(DB_FILENAME);

            return db.GetCollection<Game>().FindAll().ToDictionary(a => a.Id, b => b.Name);
        }

        public override bool DeleteSaveGame(int gameId)
        {
            using var db = new LiteDatabase(DB_FILENAME);

            return db.GetCollection<Game>().Delete(gameId);
        }

        public override Game LoadSaveGame(int gameId)
        {
            using var db = new LiteDatabase(DB_FILENAME);

            return db.GetCollection<Game>().FindById(gameId);
        }
    }
}