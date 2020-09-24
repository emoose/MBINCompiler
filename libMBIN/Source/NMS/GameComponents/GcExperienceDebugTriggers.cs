using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, Alignment = 0x4, GUID = 0x918E66169D68BD5, NameHash = 0x9A25D50A4DAF5E37)]
    public class GcExperienceDebugTriggers : NMSTemplate
    {
        // 0x10 entries
        public enum ExperienceDebugTriggersEnum {
            None, Drones, FlyBy, PirateCargoAttack, FreighterAttack, SpawnShips, LaunchShips, Mechs, SpaceBattle, RespawnInShip,
            DebugWalker, SpawnNexus, Freighters, NPCs, Sandworm, SpacePOI
        }
        public ExperienceDebugTriggersEnum ExperienceDebugTriggers;
    }
}
