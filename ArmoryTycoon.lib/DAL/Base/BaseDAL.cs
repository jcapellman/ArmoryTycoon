using ArmoryTycoon.lib.DAL.Objects;

namespace ArmoryTycoon.lib.DAL.Base
{
    public abstract class BaseDAL
    {
        public abstract bool SaveNewGame(SaveGame game);
    }
}