namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA515C82DF9464B1, NameHash = 0x20941B5D)]
    public class GcScanType : NMSTemplate
    {
        // size: 0xB
        public enum ScanTypeEnum : uint {
            Tool,
            Beacon,
            RadioTower,
            Observatory,
            DistressSignal,
            Waypoint,
            Ship,
            DebugPlanet,
            DebugSpace,
            VisualOnly,
            VisualOnlyAerial,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScanTypeEnum ScanType;
    }
}
