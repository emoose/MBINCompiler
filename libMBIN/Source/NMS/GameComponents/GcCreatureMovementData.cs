using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x38581165919BEAC5, NameHash = 0x44F790BC)]
    public class GcCreatureMovementData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureMoveAnimData> Anims;
        [NMS(Index = 5)]
        /* 0x10 */ public float HeightMax;
        [NMS(Index = 4)]
        /* 0x14 */ public float HeightMin;
        [NMS(Index = 8)]
        /* 0x18 */ public float HeightRangeMax;
        [NMS(Index = 7)]
        /* 0x1C */ public float HeightRangeMin;
        [NMS(Index = 9)]
        /* 0x20 */ public float HeightTime;
        [NMS(Index = 1)]
        /* 0x24 */ public float MoveRange;
        [NMS(Index = 2)]
        /* 0x28 */ public float MoveSpeedScale;
        [NMS(Index = 3)]
        /* 0x2C */ public float TurnRadiusScale;
        [NMS(Index = 10)]
        /* 0x30 */ public bool Herd;
        [NMS(Index = 11)]
        /* 0x31 */ public bool IgnoreRotationInPounce;
        [NMS(Index = 6)]
        /* 0x32 */ public bool LimitHeightRange;
    }
}
