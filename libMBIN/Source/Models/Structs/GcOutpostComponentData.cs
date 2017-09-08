using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcOutpostComponentData : NMSTemplate
    {
        /* 0x000 */ public bool SpaceStation;
        /* 0x001 */ public bool AIDestination;
        /* 0x002 */ public bool HasOwnGravity;
        [NMS(Size = 5, Ignore = true)]
        /* 0x003 */ public byte[] Padding003;

        [NMS(Size = 0x10)]
        /* 0x008 */ public string Door;

        /* 0x018 */ public float CircleRadius;
        /* 0x01C */ public float ApproachRange;
        /* 0x020 */ public float ApproachAngle;
        /* 0x024 */ public float ApproachSpeed;
        /* 0x028 */ public float PlayerAutoLandRange;

        /* 0x02C */ public float LandingSpeed;
        /* 0x030 */ public float LandingHeight;
        /* 0x034 */ public bool RotateToDock;

        /* 0x038 */ public float TakeOffHeight;
        /* 0x03C */ public float TakeOffFwdDist;
        /* 0x040 */ public float TakeOffTime;
        /* 0x044 */ public float TakeOffAlignTime;
        /* 0x048 */ public float TakeOffSpeed;
        /* 0x04C */ public float TakeOffBoost;
        /* 0x050 */ public float TakeOffExtraAIHeight;

        [NMS(Size = 4, Ignore = true)]
        /* 0x054 */ public byte[] Padding054;
        /* 0x058 */
        public List<GcOutpostLSystemPair> LSystems;
    }
}
