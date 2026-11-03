namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F255FA53FE111A8, NameHash = 0x26C23ACD)]
    public class GcEnvironmentLocation : NMSTemplate
    {
        // size: 0x10
        public enum EnvironmentLocationEnum : uint {
            Invalid,
            Space,
            Space_SpaceStation,
            Planet,
            Planet_InShip,
            Planet_InVehicle,
            Planet_Underwater,
            Planet_Underground,
            Planet_Building,
            Corvette_OnFoot,
            Freighter,
            FreighterAbandoned,
            Frigate,
            Space_SpaceBase,
            Space_Nexus,
            Space_Anomaly,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EnvironmentLocationEnum EnvironmentLocation;
    }
}
