using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC867BC83010CF622, NameHash = 0x741554C15123D097)]
    public class GcCreatureFullBodyIKComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureIkData> JointData;
        /* 0x10 */ public List<GcIkPistonData> PistonData;
        // size: 0x6
        public enum HeadUpAxisEnum {
            X,
            XNeg,
            Y,
            YNeg,
            Z,
            ZNeg,
        }
        /* 0x20 */ public HeadUpAxisEnum HeadUpAxis;
        /* 0x24 */ public float MaxHeadPitch;
        /* 0x28 */ public float MaxHeadRoll;
        /* 0x2C */ public float MaxHeadYaw;
        /* 0x30 */ public float BodyMassWeight;
        /* 0x34 */ public float Omega;
        /* 0x38 */ public float OmegaDropOff;
        /* 0x3C */ public float MovementDamp;
        /* 0x40 */ public bool UseFootGlue;
        /* 0x44 */ public float FootPlantSpringTime;
        /* 0x48 */ public bool UseFootAngle;
        /* 0x4C */ public float FootAngleSpeed;
        /* 0x50 */ public float MaxFootAngle;
        /* 0x54 */ public bool UsePistons;
        /* 0x55 */ public bool Mech;
    }
}
