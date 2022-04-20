using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xD5455CEE961F235E, NameHash = 0x64A394B637C25752)]
    public class GcMissionConditionLocation : NMSTemplate
    {
        // size: 0x18
        public enum MissionPlayerLocationEnum { OnPlanet, OnPlanetInVehicle, InShipLanded, InShipInPlanetOrbit, InShipInSpace,
            InShipAnywhere, InSpaceStation, InFreighter, Underground, InBuilding,
            Frigate, Underwater, DeepUnderwater, InSubmarine, Frigate_Damaged,
            FreighterConstructionArea, FriendsPlanetBase, OnPlanetSurface, InNexus,
            InNexusOnFoot, AbandonedFreighterExterior, AbandonedFreighterInterior,
            AbandonedFreighterAirlock, AtlasStation
        }
        /* 0x0 */ public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
