using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x042D3903C03346A5, NameHash = 0x902E6B8A4F1B75A6)]
    public class GcExperienceDebugTriggerActionTypes : NMSTemplate
    {
        // size: 0x27
        public enum ExperienceDebugTriggerActionEnum { None, Drones, FlyBy, FrigateFlyByBegin, FrigateFlyByEnd, PirateCargoAttack,
            PirateRaid, FreighterAttack, SpawnShips, LaunchShips, Mechs, SpaceBattle,
            RespawnInShip, DebugWalker, DebugWalkerTitanFall, SpawnNexus, Freighters,
            NPCs, Sandworm, SpacePOI, Creatures, CameraPath, SummonFleet,
            SummonSquadron, ResetScene, ResetPlayerPos, CameraSpin, SpawnEnemyShips,
            PetHappy, PetSad, PetFollow, PetFollowClose, PetRest, PetNatural,
            PetMine, PetMineAndDeposit, RidePet, Normandy, UpgradeSettlement
        }
        /* 0x0 */ public ExperienceDebugTriggerActionEnum ExperienceDebugTriggerAction;
    }
}
