namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DD543F0DE5546C6, NameHash = 0xC2F4FABD9EDAFE6A)]
    public class GcMissionSequenceDetailMessagePoint : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Text;
        // size: 0x3
        public enum PointStateEnum {
            Statement,
            ObjectiveIncomplete,
            ObjectiveComplete,
        }
        /* 0x20 */ public PointStateEnum PointState;
        /* 0x28 */ public NMSString0x10 InsertItemName;
    }
}
