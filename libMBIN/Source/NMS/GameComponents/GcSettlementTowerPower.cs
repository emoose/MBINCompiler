namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x228ABBDEA1B0F7D2, NameHash = 0xDF187761)]
    public class GcSettlementTowerPower : NMSTemplate
    {
        // size: 0x4
        public enum SettlementTowerPowerEnum : uint {
            EarnNavigationData,
            ScanForBuildings,
            ScanForAnomalies,
            ScanForCrashedShips,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementTowerPowerEnum SettlementTowerPower;
    }
}
