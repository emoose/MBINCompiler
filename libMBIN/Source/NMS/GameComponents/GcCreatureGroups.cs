namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BCB512A8DC618E2, NameHash = 0xDC6AC60910C16B2D)]
    public class GcCreatureGroups : NMSTemplate
    {
        // size: 0x4
        public enum CreatureGroupEnum {
            Solo,
            Couple,
            Group,
            Herd
        }
        /* 0x0 */ public CreatureGroupEnum CreatureGroup;
    }
}
