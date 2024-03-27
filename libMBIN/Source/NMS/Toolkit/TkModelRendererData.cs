using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x342F98A7F9398C24, NameHash = 0x53EC68060BE631FB)]
    public class TkModelRendererData : NMSTemplate
    {
        /* 0x00 */ public TkModelRendererCameraData Camera;
        /* 0x40 */ public float Fov;
        /* 0x44 */ public float AspectRatio;
        /* 0x48 */ public float LightIntensityMultiplier;
        // size: 0x3
        public enum ThumbnailModeEnum : uint {
            None,
            HUD,
            GUI,
        }
        /* 0x4C */ public ThumbnailModeEnum ThumbnailMode;
        // size: 0x4
        public enum FocusTypeEnum : uint {
            ResourceBounds,
            ResourceBoundingHeight,
            NodeBoundingBox,
            DiscoveryView,
        }
        /* 0x50 */ public FocusTypeEnum FocusType;
        /* 0x58 */ public NMSString0x20A FocusLocator;
        /* 0x80 */ public Vector3f FocusOffset;
        /* 0x90 */ public float FocusInterpTime;
        /* 0x94 */ public float BlendInTime;
        /* 0x98 */ public float BlendInOffset;
        /* 0xA0 */ public NMSString0x10 Anim;
        /* 0xB0 */ public float HeightOffset;
        /* 0xB4 */ public bool UsePlayerCameraInHmd;
        /* 0xB5 */ public bool AlignUIToCameraInHmd;
        /* 0xB6 */ public bool UseSensibleCameraFocusNodeIsNowOffsetNode;
        /* 0xB7 */ public bool LookForFocusInMasterModel;
        /* 0xB8 */ public bool FlipRotationIfNecessary;
    }
}
