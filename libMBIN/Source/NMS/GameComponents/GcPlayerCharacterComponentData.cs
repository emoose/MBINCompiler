using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x65BCE723D76BABBD, NameHash = 0xE8C3B2237C130170)]
    public class GcPlayerCharacterComponentData : NMSTemplate
    {
        public List<GcCharacterJetpackEffect> JetpackEffects;
    }
}