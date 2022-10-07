namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B4BE3725C958468, NameHash = 0x30324FBB2A97B16E)]
    public class GcWordKnowledge : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Word;
        // size: 0x8
        public enum RacesEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(RacesEnum))]
        /* 0x10 */ public bool[] Races;
    }
}
