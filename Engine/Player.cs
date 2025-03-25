using System.Collections.Generic;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int gold, int experience, int level, int currentHitPoints, int maxHitPoints) : base(currentHitPoints, maxHitPoints)
        {
            Gold = gold;
            Experience = experience;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
