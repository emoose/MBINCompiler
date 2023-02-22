namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x745240DB2AE8DCE0, NameHash = 0x64A394B637C25752)]
    public class GcMissionConditionLocation : NMSTemplate
    {
        // size: 0x1B
        public enum MissionPlayerLocationEnum {
            OnPlanet,
            OnPlanetInVehicle,
            InShipLanded,
            InShipInPlanetOrbit,
            InShipInSpace,
            InShipAnywhere,
            InSpaceStation,
            InFreighter,
            InYourFreighter,
            InOtherPlayerFreighter,
            Underground,
            InBuilding,
            Frigate,
            Underwater,
            UnderwaterSwimming,
            DeepUnderwater,
            InSubmarine,
            Frigate_Damaged,
            FreighterConstructionArea,
            FriendsPlanetBase,
            OnPlanetSurface,
            InNexus,
            InNexusOnFoot,
            AbandonedFreighterExterior,
            AbandonedFreighterInterior,
            AbandonedFreighterAirlock,
            AtlasStation,
        }
        /* 0x0 */ public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
