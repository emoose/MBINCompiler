using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x135475BEC6A4BDE9, NameHash = 0x7AB4D686179F9F82)]
    public class GcCameraAerialViewData : NMSTemplate
    {
        /* 0x00 */ public float Time;
        // size: 0x3
        public enum AerialViewModeEnum {
            FaceDown,
            FaceOut,
            FaceDownThenOut
        }
        /* 0x04 */ public AerialViewModeEnum AerialViewMode;
        /* 0x08 */ public float TimeBack;
        /* 0x0C */ public float StartTime;
        /* 0x10 */ public float PauseTime;
        /* 0x14 */ public float Distance;
        /* 0x18 */ public float TargetOffsetAngle;
        /* 0x1C */ public int Stages;
        /* 0x20 */ public float SpeedLineDist;
        /* 0x24 */ public TkCurveType Curve;
        /* 0x28 */ public TkCurveType CurveDown;
        /* 0x2C */ public TkCurveType SlerpCurve;
    }
}
