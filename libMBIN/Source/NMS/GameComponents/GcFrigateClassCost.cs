namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25C9483BA5237DCE, NameHash = 0x8505F02597BABF0)]
    public class GcFrigateClassCost : NMSTemplate
    {
        // size: 0x8
        public enum CostEnum {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Support,
            Normandy,
            DeepSpace,
            DeepSpaceCommon
        }
        [NMS(Size = 0x8, EnumType = typeof(CostEnum))]
        /* 0x0 */ public int[] Cost;
    }
}
