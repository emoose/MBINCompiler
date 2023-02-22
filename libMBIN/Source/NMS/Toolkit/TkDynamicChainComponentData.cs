using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2DD2D2E517ED0C52, NameHash = 0x380D960FAA1BF837)]
    public class TkDynamicChainComponentData : NMSTemplate
    {
        /* 0x00 */ public float AngularLimit;
        /* 0x04 */ public float TwistLimit;
        /* 0x08 */ public float MotorStrengthCone;
        /* 0x0C */ public float MotorStrengthTwist;
        /* 0x10 */ public float MaxMotorForce;
        /* 0x14 */ public float Gravity;
        /* 0x18 */ public float AirThickness;
        /* 0x1C */ public float VertAirThickness;
        /* 0x20 */ public float WindStrength;
        /* 0x24 */ public float LinearDamping;
        /* 0x28 */ public float AngularDamping;
        /* 0x2C */ public float InitialBodyMass;
        /* 0x30 */ public float BodyMassChange;
        /* 0x34 */ public bool WeightByJointLength;
        /* 0x38 */ public List<NMSString0x20> IgnoreJoints;
    }
}
