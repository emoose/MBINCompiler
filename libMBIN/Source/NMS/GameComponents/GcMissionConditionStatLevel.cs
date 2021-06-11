using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x40, GUID = 0x2BC80C07487546FC, NameHash = 0xA56864A865FEBE6D)]
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        public NMSString0x10 Stat;
        public NMSString0x10 StatGroup;
        public int Level;
        public NMSString0x10 CompareStat;
        public int DisplayMilestoneNumber;
        public TkEqualityEnum Test;
    }
}
