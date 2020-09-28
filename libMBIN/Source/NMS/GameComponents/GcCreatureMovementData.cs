using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, Alignment = 0x8, GUID = 0xC69CA2F5C4CD21B, NameHash = 0x1F15CCCBBBCEC86A)]
    public class GcCreatureMovementData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureMoveAnimData> Anims;
        /* 0x10 */ public float MoveRange;
        /* 0x14 */ public float MoveSpeedScale;
        /* 0x18 */ public float TurnRadiusScale;
        /* 0x1C */ public float HeightMin;
        /* 0x20 */ public float HeightMax;
        /* 0x24 */ public float HeightTime;
        /* 0x28 */ public bool Herd;
        [NMS(Size = 7, Ignore = true)]
        /* 0x29 */ public byte[] EndPadding;
    }
}
