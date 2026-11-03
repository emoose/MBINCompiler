namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BCC21C315EE3622, NameHash = 0x5009FB3B)]
    public class GcCreatureGroups : NMSTemplate
    {
        // size: 0x4
        public enum CreatureGroupEnum : uint {
            Solo,
            Couple,
            Group,
            Herd,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureGroupEnum CreatureGroup;
    }
}
