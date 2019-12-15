using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB8, GUID = 0xA29DF80FC3C0D124, NameHash = 0x9166CF1D0ED63522)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        public bool ScanCargo;
        public int NumSquads;
        [NMS(Size = 0x10)]
        public string AttackDefinition;
        [NMS(Size = 0x20)]
        public string RewardMessageOverride;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
