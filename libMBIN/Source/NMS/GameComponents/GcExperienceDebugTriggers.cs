using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, Alignment = 0x4, GUID = 0x7BAC8FCEDFAEF8CD, NameHash = 0x9A25D50A4DAF5E37)]
    public class GcExperienceDebugTriggers : NMSTemplate
    {
        public enum ExperienceDebugTriggersEnum { None, Drones, FlyBy, PirateCargoAttack, FreighterAttack, SpawnShips, LaunchShips, Mechs,
                                                  SpaceBattle, RespawnInShip, DebugWalker, SpawnNexus, Freighters}
        public ExperienceDebugTriggersEnum ExperienceDebugTriggers;
    }
}
