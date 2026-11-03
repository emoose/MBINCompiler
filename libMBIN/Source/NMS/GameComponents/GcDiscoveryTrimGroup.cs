namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA4DF66B90F060E0, NameHash = 0xC7159317)]
    public class GcDiscoveryTrimGroup : NMSTemplate
    {
        // size: 0x4
        public enum DiscoveryTrimGroupEnum : uint {
            System,
            Planet,
            Interesting,
            Boring,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DiscoveryTrimGroupEnum DiscoveryTrimGroup;
    }
}
