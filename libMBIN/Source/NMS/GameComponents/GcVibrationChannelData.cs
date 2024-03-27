using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1AA44B1E51F4564C, NameHash = 0xAF919B46C646D940)]
    public class GcVibrationChannelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0x4
        public enum VRAffectedHandsEnum : uint {
            Both,
            LeftOnly,
            RightOnly,
            DisableInVR,
        }
        /* 0x10 */ public VRAffectedHandsEnum VRAffectedHands;
        /* 0x14 */ public bool VROnly;
        /* 0x15 */ public bool VRSwapHandForLeftHanded;
        // size: 0x2
        public enum DataEnum {
            Left,
            Right,
        }
        [NMS(Size = 0x2, EnumType = typeof(DataEnum))]
        /* 0x18 */ public GcVibrationData[] Data;
    }
}
