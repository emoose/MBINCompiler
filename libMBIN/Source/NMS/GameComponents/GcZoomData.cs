namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF482232839FFF753, NameHash = 0x2E92A561CA97070C)]
    public class GcZoomData : NMSTemplate
    {
        // size: 0x4
        public enum ZoomTypeEnum {
            None,
            Far,
            Mid,
            Close,
        }
        /* 0x00 */ public ZoomTypeEnum ZoomType;
        /* 0x04 */ public float EffectStrength;
        /* 0x08 */ public float MoveSpeed;
        /* 0x0C */ public float FoV;
        /* 0x10 */ public float MinScanDistance;
        /* 0x14 */ public float MaxScanDistance;
        /* 0x18 */ public float WalkSpeed;
    }
}
