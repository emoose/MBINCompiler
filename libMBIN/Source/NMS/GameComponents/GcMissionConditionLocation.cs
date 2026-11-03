namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4ACF849308D748D, NameHash = 0x6226FC40)]
    public class GcMissionConditionLocation : NMSTemplate
    {
        // size: 0x23
        public enum MissionPlayerLocationEnum : uint {
            OnPlanet,
            OnPlanetInVehicle,
            AnywhereInPlanetAtmos,
            InShipLanded,
            InShipInPlanetOrbit,
            InShipInSpace,
            OnFootInSpace,
            OnFootInAnyCorvette,
            OnFootInYourCorvette,
            OnFootInOtherPlayerCorvette,
            OnFootInOtherPlayerCorvetteNotLanded,
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
            AbandonedFreighterDocked,
            AtlasStation,
            AtlasStationFinal,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
