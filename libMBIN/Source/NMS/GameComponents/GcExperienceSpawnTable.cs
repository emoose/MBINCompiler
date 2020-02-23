﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE0, GUID = 0x68FDE9A04645C86D, NameHash = 0x5F4CA33999F0D259)]
    public class GcExperienceSpawnTable : NMSTemplate
    {
        public List<GcAIShipSpawnData> FlybySpawns;
        public List<GcAIShipSpawnData> OutpostSpawns;
        public List<GcAIShipSpawnData> SpaceFlybySpawns;
        public List<GcAIShipSpawnData> PirateSpawns;
        public List<GcAIShipSpawnData> PirateBattleSpawns;
        public List<GcAIShipSpawnData> PoliceSpawns;
        public List<GcAIShipSpawnData> TraderSpawns;
        public List<GcAIShipSpawnData> AmbientSpawns;
        public List<GcAIShipSpawnData> BattleSpawns;
        public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
        public List<GcBountySpawnInfo> PirateBountySpawns;
        public List<GcPulseEncounterInfo> PulseEncounters;
    }
}
