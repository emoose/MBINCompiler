using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C24ED3B2BDC1A7F, NameHash = 0x8BB9C425)]
    public class GcPlayerCharacterComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 IntialPlayerControlMode;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcCharacterJetpackEffect> JetpackEffects;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcPlayerControlModeEntry> PlayerControlModes;
    }
}
