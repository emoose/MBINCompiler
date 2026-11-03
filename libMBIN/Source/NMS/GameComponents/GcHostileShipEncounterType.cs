namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA0B641D28A4DE8D, NameHash = 0xE3307DE1)]
    public class GcHostileShipEncounterType : NMSTemplate
    {
        // size: 0x8
        public enum HostileShipEncounterTypeEnum : byte {
            None,
            CargoAttack,
            FreighterBattle,
            Bounty,
            PlanetaryRaid,
            PlanetaryFlyBy,
            SwarmDroneAttack,
            Any,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HostileShipEncounterTypeEnum HostileShipEncounterType;
    }
}
