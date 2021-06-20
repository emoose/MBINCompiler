using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x3A120DFE869BC529, NameHash = 0xC2F4FABD9EDAFE6A)]
    public class GcMissionSequenceDetailMessagePoint : NMSTemplate
    {
        public NMSString0x20A Text;
        public enum PointStateEnum { Statement, ObjectiveIncomplete, ObjectiveComplete }
        public PointStateEnum PointState;
        public NMSString0x10 InsertItemName;
    }
}
