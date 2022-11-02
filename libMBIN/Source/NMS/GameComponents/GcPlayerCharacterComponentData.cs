using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E8AE6E84D2716DE, NameHash = 0xE8C3B2237C130170)]
    public class GcPlayerCharacterComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcCharacterJetpackEffect> JetpackEffects;
        /* 0x10 */ public NMSString0x10 IntialPlayerControlMode;
        /* 0x20 */ public List<GcPlayerControlModeEntry> PlayerControlModes;
    }
}
