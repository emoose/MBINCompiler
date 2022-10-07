namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EAE70796B38879D, NameHash = 0x46AEF7A8E9B9A7D8)]
    public class GcGeneratedShipCounts : NMSTemplate
    {
        // size: 0x7
        public enum CountsEnum {
            Standard,
            PlayerSquadron,
            Freighter,
            CapitalFreighter,
            SmallFreighter,
            TinyFreighter,
            Frigate
        }
        [NMS(Size = 0x7, EnumType = typeof(CountsEnum))]
        /* 0x0 */ public int[] Counts;
    }
}
