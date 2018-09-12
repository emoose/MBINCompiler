using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x150, GUID = 0x6F1FB34176A068B0)]
    public class GcIkConstraint : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x100)]
        /* 0x010 */ public string JointName;
        /* 0x110 */ public GcCreatureIkType Type;                               // maybe??
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x114 */ public byte[] Padding114;
        /* 0x120 */ public GcPlayerCharacterIKOverrideData DefaultState;        // probably
        /* 0x140 */ public List<GcPlayerCharacterIKStateData> States;           // as a guess
    }
}
