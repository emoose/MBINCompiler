namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEC337421BB94563, NameHash = 0x34D109FC6FD5709)]
    public class GcScanEventTableType : NMSTemplate
    {
        // size: 0x8
        public enum ScanTableEnum {
            Space,
            Planet ,
            Missions,
            Tutorial,
            MissionsCreative,
            Vehicle,
            NPCPlanetSite,
            Seasonal
        }
        /* 0x0 */ public ScanTableEnum ScanTable;
    }
}
