using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFE1C74A7BD0885A, NameHash = 0x45DFFC6E8B36F6B7)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        // size: 0x8
        public enum ArrayEnum {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Support,
            Normandy,
            DeepSpace,
            DeepSpaceCommon
        }
        [NMS(Size = 0x8, EnumType = typeof(ArrayEnum))]
        /* 0x0 */ public GcPassiveFrigateIncome[] Array;
    }
}
