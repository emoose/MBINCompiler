using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2AC2B030A133CE1C, NameHash = 0x161DC486)]
    public class GcClothComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcClothPiece> ClothPieces;
        [NMS(Index = 1)]
        /* 0x10 */ public float InitialOverSolveForConstraints;
        [NMS(Index = 2)]
        /* 0x14 */ public float InitialOverSolveForContacts;
        [NMS(Index = 5)]
        /* 0x18 */ public float MaxAngularSpeedFeltByDynamics;
        [NMS(Index = 4)]
        /* 0x1C */ public float MaxLinearSpeedFeltByDynamics;
        [NMS(Index = 0)]
        /* 0x20 */ public bool Enabled;
    }
}
