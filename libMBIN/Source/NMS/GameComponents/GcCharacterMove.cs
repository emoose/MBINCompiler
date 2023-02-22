namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8520F52F4D761738, NameHash = 0x7E96F40C0051D69C)]
    public class GcCharacterMove : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Input;
        /* 0x10 */ public float Strength;
        // size: 0x2
        public enum ModeEnum {
            SetVelocity,
            ApplyForce,
        }
        /* 0x14 */ public ModeEnum Mode;
    }
}
