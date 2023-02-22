using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DA8BF75E7FFBA01, NameHash = 0x4B56CD3D914485CF)]
    public class GcSpringLink : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public NMSString0x40 Name;
        /* 0x048 */ public List<NMSString0x40> NodeNames;
        /* 0x060 */ public Vector3f CentreOfMassLocal;
        /* 0x070 */ public Vector3f PivotLocal;
        // size: 0x4
        public enum PivotAnchorsToEnum {
            Itself,
            Parent,
            Node,
            NodeWithAnchor,
        }
        /* 0x080 */ public PivotAnchorsToEnum PivotAnchorsTo;
        /* 0x090 */ public Vector3f PivotAnchorLocal;
        /* 0x0A0 */ public NMSString0x40 PivotAnchorNode;
        /* 0x0E0 */ public float ApplyGameGravity;
        /* 0x0E4 */ public float ApplyGameWind;
        /* 0x0E8 */ public float AirSpeedFromMovementSpeedScale;
        /* 0x0EC */ public bool PositionalSpringEnabled;
        /* 0x0F0 */ public float DampingCriticality;
        /* 0x0F4 */ public float NaturalFrequency;
        /* 0x0F8 */ public bool SpringPivots;
        /* 0x0F9 */ public bool ApplySpringInMovingFrame;
        // size: 0x5
        public enum ApplyMotionScaleInEnum {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        /* 0x0FC */ public ApplyMotionScaleInEnum ApplyMotionScaleIn;
        /* 0x100 */ public float MotionScale_Uniform;
        /* 0x110 */ public Vector3f MotionScale;
        // size: 0x5
        public enum ApplyMotionLimitsInEnum {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        /* 0x120 */ public ApplyMotionLimitsInEnum ApplyMotionLimitsIn;
        /* 0x124 */ public float MotionLimit_MaxDetachmentDistance;
        /* 0x130 */ public Vector3f MotionLimitMin;
        /* 0x140 */ public Vector3f MotionLimitMax;
        /* 0x150 */ public Vector3f MotionLimitBounciness;
        /* 0x160 */ public bool AngularSpringEnabled;
        /* 0x164 */ public float InfluenceOfTranslation;
        /* 0x168 */ public float ApplyInfluenceOfTranslationInMovingFrame;
        /* 0x16C */ public float DistanceWhereRotationMatchesLinear;
        /* 0x170 */ public float AngularDampingCriticality;
        /* 0x174 */ public float AngularNaturalFrequency;
        /* 0x178 */ public float ApplyAngularSpringInMovingFrame;
        // size: 0x5
        public enum ApplyAngularMotionScaleInEnum {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        /* 0x17C */ public ApplyAngularMotionScaleInEnum ApplyAngularMotionScaleIn;
        /* 0x180 */ public float AngularMotionScale_Uniform;
        /* 0x190 */ public Vector3f AngularMotionScale;
        // size: 0x4
        public enum ApplyAngularLimitsInEnum {
            Disabled,
            Itself,
            Parent,
            Component,
        }
        /* 0x1A0 */ public ApplyAngularLimitsInEnum ApplyAngularLimitsIn;
        /* 0x1B0 */ public Vector3f AngularLimitMinDeg;
        /* 0x1C0 */ public Vector3f AngularLimitMaxDeg;
        /* 0x1D0 */ public Vector3f AngularMotionLimitBounciness;
    }
}
