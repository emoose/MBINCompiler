namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10D41904DB6F3321, NameHash = 0x8531B20A02DD0931)]
    public class GcScanData : NMSTemplate
    {
        // size: 0xB
        public enum ScanTypeEnum {
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
        /* 0x00 */ public ScanTypeEnum ScanType;
        /* 0x04 */ public float PulseRange;
        /* 0x08 */ public float PulseTime;
        /* 0x0C */ public bool PlayAudioOnMarkers;
        /* 0x10 */ public float ChargeTime;
    }
}
