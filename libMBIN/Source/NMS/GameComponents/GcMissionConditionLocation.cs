using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEDAE568E6A5A9223)]
    public class GcMissionConditionLocation : NMSTemplate
    {
		public enum MissionPlayerLocationEnum { OnPlanet, OnPlanetInVehicle, InShipLanded, InShipInPlanetOrbit, InShipInSpace, InSpaceStation, InFreighter, Underground, InBuilding, Frigate, Frigate_Damaged, FreighterConstructionArea, FriendsPlanetBase, OnPlanetSurface }
		public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
