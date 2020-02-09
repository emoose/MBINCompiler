using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB8, Alignment = 0x8, GUID = 0xA29DF80FC3C0D124, NameHash = 0x9166CF1D0ED63522)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        /* 0x00 */ public bool ScanCargo;
        /* 0x04 */ public int NumSquads;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string AttackDefinition;
        [NMS(Size = 0x20)]
        /* 0x18 */ public string RewardMessageOverride;
        [NMS(Size = 0x80)]
        /* 0x38 */ public string DebugText;
    }
}
