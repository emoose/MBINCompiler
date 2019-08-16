using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x116261B17D1DA685, SubGUID = 0x184558FBF0A370E2)]
    public class GcOutpostComponentData : NMSTemplate
    {
        /* 0x00 */ public bool Anomaly;
        /* 0x01 */ public bool Frigate;
        /* 0x02 */ public bool SpaceStation;
        /* 0x03 */ public bool NexusExterior;
        /* 0x04 */ public bool NexusInterior;
        /* 0x05 */ public bool AIDestination;
        /* 0x06 */ public bool HasDoors;
        /* 0x07 */ public bool HasOwnGravity;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Door;
        /* 0x18 */ public bool CheckLandingAreaClear;
        /* 0x1C */ public int MagicDockIndex;
        /* 0x20 */ public float CircleRadius;
        /* 0x24 */ public float ApproachRange;
        /* 0x28 */ public float ApproachAngle;
        /* 0x2C */ public float ApproachSpeed;
        /* 0x30 */ public float PlayerAutoLandRange;
        /* 0x34 */ public float LandingSpeed;
        /* 0x38 */ public float LandingHeight;
        /* 0x3C */ public bool RotateToDock;
        /* 0x40 */ public float TakeOffHeight;
        /* 0x44 */ public float TakeOffFwdDist;
        /* 0x48 */ public float TakeOffTime;
        /* 0x4C */ public float TakeOffAlignTime;
        /* 0x50 */ public float TakeOffSpeed;
        /* 0x54 */ public float TakeOffBoost;
        /* 0x58 */ public float TakeOffExtraAIHeight;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x5C */ public byte[] Padding5C;
        /* 0x60 */ public List<GcOutpostLSystemPair> LSystems;
    }
}
