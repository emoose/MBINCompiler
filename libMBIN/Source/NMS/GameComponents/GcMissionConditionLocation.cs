using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x1F339A28452B7BDB, NameHash = 0x64A394B637C25752)]
    public class GcMissionConditionLocation : NMSTemplate
    {
        // 0x13 entries
		public enum MissionPlayerLocationEnum { OnPlanet, OnPlanetInVehicle, InShipLanded, InShipInPlanetOrbit, InShipInSpace, InSpaceStation, InFreighter, Underground,
            InBuilding, Frigate, Underwater, DeepUnderwater, InSubmarine, Frigate_Damaged, FreighterConstructionArea, FriendsPlanetBase, OnPlanetSurface, InNexus, InNexusOnFoot
        }
		public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
