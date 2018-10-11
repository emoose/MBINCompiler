using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x97C0EB4710F2C5C5)]
    public class GcRewardModifyStat : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Stat;
        public int Amount;
        public enum ModifyTypeEnum { Set, Add }
        public ModifyTypeEnum ModifyType;
    }
}
