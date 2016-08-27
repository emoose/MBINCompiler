using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkDynamicChainComponentData : NMSTemplate
    {
        public float AngularLimit;
        public float TwistLimit;
        public float MotorStrengthCone;
        public float MotorStrengthTwist;
        public float MaxMotorForce;
        public float Gravity;
        public float AirThickness;
        public float VertAirThickness;
        public float WindStrength;
        public float LinearDamping;
        public float AngularDamping;
        public float InitialBodyMass;
        public float BodyMassChange;
        public bool WeightByJointLength;

        public List<NMSString0x20> IgnoreJoints;
    }
}
